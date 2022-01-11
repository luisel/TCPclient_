﻿using System;
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
        //Form2 form_2 = new Form2();
        private TcpClient _client;
        private NetworkStream _stream;
        IPHostEntry _host = Dns.GetHostEntry(Dns.GetHostName());
        string IP_address;
        int port = 11000;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            IP_address = _host.AddressList[1].ToString();
            send_button.Enabled = false;
            disconnect_button.Enabled = false;


        }


        private void connect_button_Click(object sender, EventArgs e)
        {
            //Create a Tcpclient object.
            _client = new TcpClient();

            //Try to connect to the Server
            try
            {
                _client.Connect(IP_address, port);



                if (_client.Connected)
                {
                    //IP address of the server that we are trying to connect will be displayed.
                    serverIP_address.Text = IP_address;

                    _stream = _client.GetStream();
                    byte[] msg = Encoding.ASCII.GetBytes("Connected!");
                    _stream.Write(msg, 0, msg.Length);


                    //If connection is successful then turn off the Connect button and turn on the Send button and Disconnect button.
                    connect_button.Enabled = false;
                    send_button.Enabled = true;
                    disconnect_button.Enabled = true;

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
            {
                _stream.Close();
                _client.Close();

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
            try
            {
                _client = new TcpClient();
                _client.Connect(IPAddress.Parse(IP_address), port);

                if (_client.Connected)
                {
                    _stream = _client.GetStream();

                    byte[] msg0 = Encoding.ASCII.GetBytes("send");
                    _stream.Write(msg0, 0, msg0.Length);

                    byte[] msg = Encoding.ASCII.GetBytes(x1.Text);
                    _stream.Write(msg, 0, msg.Length);

                    byte[] msg1 = Encoding.ASCII.GetBytes(y1.Text);
                    _stream.Write(msg1, 0, msg1.Length);

                    byte[] msg2 = Encoding.ASCII.GetBytes(z1.Text);
                    _stream.Write(msg2, 0, msg2.Length);

                    byte[] msg3 = Encoding.ASCII.GetBytes(x2.Text);
                    _stream.Write(msg3, 0, msg3.Length);

                    byte[] msg4 = Encoding.ASCII.GetBytes(y2.Text);
                    _stream.Write(msg4, 0, msg4.Length);

                    byte[] msg5 = Encoding.ASCII.GetBytes(z2.Text);
                    _stream.Write(msg5, 0, msg5.Length);


                    byte[] responsedata = new byte[256];
                    string response = string.Empty;

                    int bytes = _stream.Read(responsedata, 0, responsedata.Length);
                    response = Encoding.ASCII.GetString(responsedata, 0, bytes);
                    distance_result.Text = response;

                    _stream.Close();
                    _client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
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