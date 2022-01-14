using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCPclient_
{
    public partial class Form2 : Form
    {
        private TcpListener _server;
        private TcpClient _client;
        private NetworkStream _netstream;
        private Thread _thread;
        private Form1 form1 = new Form1();
        
        List<Form1> form = new List<Form1>();
        List<Label> client_IP = new List<Label>();
        


        public Form2()
        {
            InitializeComponent();

           // Get local server details.
            IPHostEntry _host = Dns.GetHostEntry(Dns.GetHostName());
            IP_address.Text = _host.AddressList[1].ToString();
            host_name.Text = _host.HostName.ToString();
            port.Text = "11000";
            

            client_IP.Add(client_IP_1);
            client_IP.Add(client_IP_2);
            client_IP.Add(client_IP_3);
            client_IP.Add(client_IP_4);
            client_IP.Add(client_IP_5);
            client_IP.Add(client_IP_6);

            

            //Stop button should be off initially.
            stop_Server.Enabled = false;
        }

        private void Start_server_Click(object sender, EventArgs e)
        {
            try
            {
                //create server and start listening.
                CheckForIllegalCrossThreadCalls = false;
                _server = new TcpListener(IPAddress.Parse(IP_address.Text), Convert.ToInt32(port.Text));
                _server.Start();
                
                //buttons for start should be turned off and stop should be on
                start_server.Enabled = false;
                stop_Server.Enabled = true;                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.StackTrace);
            }

        }
        private void Create_client_button_Click(object sender, EventArgs e)
        {
            try
            {   
                //create 6 different clients and stop after reaching 6
                if (form.Count() <=5)
                {
                    form1 = new Form1();
                    _thread = new Thread(AcceptClientSystem);
                    _thread.Start();
                    //show a new form everytime a new client is created.
                    form.Add(form1);
                    form1.Show();
                    //Didn't know how to get unique IP addresses for clients so I used this as a place holder.
                    for (int i = 0; i < form.Count(); i++)
                    {
                        string IP = Convert.ToString(i + 1);
                        client_IP[i].Text = IP;
                    }                                                                             
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

        }
        private void AcceptClientSystem()
        {
            //create client and get stream to write/read
            _client = _server.AcceptTcpClient();
            _netstream = _client.GetStream();

            // Continue to read messages while Client is connected
            while (_client.Connected)
            {
                try
                {
                    
                    byte[] coord_bytes = new byte[_client.ReceiveBufferSize];
                    _netstream.Read(coord_bytes, 0, coord_bytes.Length);
                    string coord_msg = Encoding.ASCII.GetString(coord_bytes);
                    string[] coord_msg_list = coord_msg.Split('\0');

                    //this throws a looping error when I have a client disconnect from the server. Not sure how to fix it. Closing in wrong order?                       
                    coordinates_received.Text = coord_msg_list[0].Substring(0, coord_msg_list[0].Length - 1);

                    //This is where I send the message from the client and parse it so that the method Calculate_distance can give me a result
                    if (coord_msg.Substring(0, 4) != "buff")
                    {
                        string[] coordinates = coord_msg.Split(',');

                        double distance = Calculate_distance(coordinates);
                        string distance_string = distance.ToString();
                        byte[] distance_bytes = Encoding.ASCII.GetBytes(distance_string);

                        //I write the result back to the client
                        _netstream.Write(distance_bytes, 0, distance_bytes.Length);
                        _netstream.Flush();
                    }                                        
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message, e.StackTrace);
                }
            }
        }
        private double Calculate_distance(string[] vs)
        {
            try
            {
                //I convert list of string into double before doing the calculations
                double distance = 0;
                double deltaX = Convert.ToDouble(vs[3]) - Convert.ToDouble(vs[0]);
                double deltaY = Convert.ToDouble(vs[4]) - Convert.ToDouble(vs[1]);
                double deltaZ = Convert.ToDouble(vs[5]) - Convert.ToDouble(vs[2]);
                distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                return Math.Round(distance, 4);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

            return double.NaN;
        }
        private void Stop_Server_Click(object sender, EventArgs e)
        {
            try
            {
                   //I must be doing this wrong. I keep getting error when I close the client.
                    _client.Close();
                    _thread.Abort();
                    _server.Stop();
                    start_server.Enabled = true;
                    stop_Server.Enabled = false;
                
                
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }


        //Client label's created to hold each respective client's IP_address
        private void Client_group_box_Enter(object sender, EventArgs e) { }
        private void Client_label_1_Click(object sender, EventArgs e) { }
        private void Client_label_2_Click(object sender, EventArgs e) { }
        private void Client_label_3_Click(object sender, EventArgs e) { }
        private void Client_label_4_Click(object sender, EventArgs e) { }
        private void Client_label_5_Click(object sender, EventArgs e) { }
        private void Client_label_6_Click(object sender, EventArgs e) { }

        //Server system details
        private void Server_system_details_box_Enter(object sender, EventArgs e) { }
        private void IP_address_label_Click(object sender, EventArgs e) { }
        private void Host_name_label_Click(object sender, EventArgs e) { }
        private void Port_label_Click(object sender, EventArgs e) { }
        private void Coordinates_received_label_Click(object sender, EventArgs e) { }        
    }   
}
