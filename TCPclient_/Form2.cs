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
        bool _accept = false;
        Form1 form1 = new Form1();
        


        public Form2()
        {
            InitializeComponent();
           // Get local server details.
            IPHostEntry _host = Dns.GetHostEntry(Dns.GetHostName());
            IP_address.Text = _host.AddressList[1].ToString();
            host_name.Text = _host.HostName.ToString();
            port.Text = "11000";

            //Stop button should be off initially.
            stop_Server.Enabled = false;
        }

        private void Start_server_Click(object sender, EventArgs e)
        {
            try
            {
                
                CheckForIllegalCrossThreadCalls = false;
                _server = new TcpListener(IPAddress.Parse(IP_address.Text), Convert.ToInt32(port.Text));
                _server.Start();
                _thread = new Thread(AcceptClientSystem);
                _thread.Start();
                form1.Show();
                

                start_server.Enabled = false;
                stop_Server.Enabled = true;               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.StackTrace);
            }

        }
       

        private void AcceptClientSystem()
        {
            int count = 0;
            List<int> vs = new List<int>();


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
                    message.Text = coord_msg;


                    byte[] distance_bytes = Encoding.ASCII.GetBytes(coord_msg);
                    _netstream.Write(distance_bytes, 0, distance_bytes.Length);
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }
               
                
            }
                //Add result into list and update counter
                //vs.Append(result);
                //count++;

                /*double distance = calculate_distance(vs);
                string dist_msg = distance.ToString();
                byte[] distance_bytes = Encoding.ASCII.GetBytes(dist_msg);
                _netstream.Write(distance_bytes, 0, distance_bytes.Length);
                    
                vs.Clear();
                */
                //count = 0;
         
        }

        private double Calculate_distance(List<int> vs)
        {
            try
            {
                double distance = 0;
                double deltaX = vs[3] - vs[0];
                double deltaY = vs[4] - vs[1];
                double deltaZ = vs[5] - vs[2];
                distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                return distance;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            
            return double.NaN;
        }

        private void Stop_Server_Click(object sender, EventArgs e)
        {
            try
            {
                _thread.Abort();
                _client.Close();
                _server.Stop();
                
                start_server.Enabled = true;
                stop_Server.Enabled = false;
            }
            catch (Exception ex)
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
        
        
    }
}
