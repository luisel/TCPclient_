using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

// CLIENT APP

namespace TCPclient_
{
    
    public partial class Form1 : Form
    {        
        private TcpClient _client;
        private NetworkStream _stream;
        private Thread _thread;
        IPHostEntry _host = Dns.GetHostEntry(Dns.GetHostName());
        string IP_address;
        int port = 11000;        

        public Form1()
        {
            InitializeComponent();
            IP_address = _host.AddressList[1].ToString();
            send_button.Enabled = false;
            disconnect_button.Enabled = false;


        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            //Create a Tcpclient object.
            _client = new TcpClient();

            //Try to connect to the Server
            try
            {
                _client.Connect(IP_address, port);

                if (_client.Connected)
                {
                    // If connection is successful then turn off the Connect button
                    // and turn on the Send button and Disconnect button.
                    connect_button.Enabled = false;                   
                    disconnect_button.Enabled = true;
                    send_button.Enabled = true;

                    //IP address of the server that we are trying to connect will be displayed.
                    serverIP_address.Text = IP_address;

                    //Client will start listening to the server.
                    _stream = _client.GetStream();                   
                    _thread = new Thread(Listening);
                    _thread.Start();
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }                       
        }
       
        private void Disconnect_button_Click(object sender, EventArgs e)
        {           
            
            try
            {   //Must be doing something wrong. Everytime I disconnect it throws an exception. Dispose? Misplaced Close calls?
                _stream.Close();
                _client.Close();
                _thread.Abort();
                

                //turn on the connect button and turn off Send and disconnect. Set the IP_address label to null.
                serverIP_address.Text = null;
                send_button.Enabled = false;
                connect_button.Enabled = true;
                disconnect_button.Enabled = false;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

        }
        private void Send_button_Click(object sender, EventArgs e)
        {
            //I put the text in a list so I can use a for loop instead of writing it all out.
            List<string> list = new List<string>
            {
                x1.Text,
                y1.Text,
                z1.Text,
                x2.Text,
                y2.Text,
                z2.Text
            };
            //This will write to the server the coordinates entered in the coordinate text boxes.
            if (_client.Connected)
            {                
                _stream = _client.GetStream();
                //Wish I knew why I need this buffer (not doing something right).
                send_button.Enabled = true; byte[] msg0 = Encoding.ASCII.GetBytes("buff");
                _stream.Write(msg0, 0, msg0.Length);
                for (int i = 0; i < list.Count; i++)
                {
                    //send coordinate
                    byte[] msg = Encoding.ASCII.GetBytes(list[i]);
                    _stream.Write(msg, 0, msg.Length);
                    
                    //parse indicator to use when on server side
                    byte[] msg_parse = Encoding.ASCII.GetBytes(",");
                    _stream.Write(msg_parse, 0, msg_parse.Length);
                    _stream.Flush();
                }               
            }            
        }
        private void Listening()
        {
            //client will continue to listen for the distance calculated by the server.
            while (_client.Connected)
            {
                try
                {
                    //get message from server
                    byte[] msg = new byte[_client.ReceiveBufferSize];
                    _stream.Read(msg, 0, msg.Length);
                    string listener = Encoding.ASCII.GetString(msg);

                    //display the results to the distance label.
                    distance_result.Text = listener;
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace);
                }                
            }
        }


        private void Client_label_Click(object sender, EventArgs e) { }

        //Coordinate group box and labels
        private void Coordinates_groupBox_Enter(object sender, EventArgs e) { }
        private void Coordinate_label_1_Click(object sender, EventArgs e) { }
        private void Coordinate_label_2_Click(object sender, EventArgs e) { }
        private void Distance_label_Click(object sender, EventArgs e) { }
        private void X_label_Click(object sender, EventArgs e) { }
        private void Y_label_Click(object sender, EventArgs e) { }
        private void Z_label_Click(object sender, EventArgs e) { }

        //Coordinates textboxes
        private void X1_TextChanged(object sender, EventArgs e) { }
        private void Y1_TextChanged(object sender, EventArgs e) { }
        private void Z1_TextChanged(object sender, EventArgs e) { }
        private void X2_TextChanged(object sender, EventArgs e) { }
        private void Y2_TextChanged(object sender, EventArgs e) { }
        private void Z2_TextChanged(object sender, EventArgs e) { }

        //Server IP groupbox and label
        private void Server_groupBox_Enter(object sender, EventArgs e) { }
        private void ServerIP_label_Click(object sender, EventArgs e) { }


    }
}
