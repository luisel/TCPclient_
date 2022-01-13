namespace TCPclient_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.server_label = new System.Windows.Forms.Label();
            this.client_group_box = new System.Windows.Forms.GroupBox();
            this.client_IP_6 = new System.Windows.Forms.Label();
            this.client_label_6 = new System.Windows.Forms.Label();
            this.client_IP_5 = new System.Windows.Forms.Label();
            this.client_label_5 = new System.Windows.Forms.Label();
            this.client_IP_4 = new System.Windows.Forms.Label();
            this.client_IP_3 = new System.Windows.Forms.Label();
            this.client_label_4 = new System.Windows.Forms.Label();
            this.client_label_3 = new System.Windows.Forms.Label();
            this.client_IP_2 = new System.Windows.Forms.Label();
            this.client_label_2 = new System.Windows.Forms.Label();
            this.client_IP_1 = new System.Windows.Forms.Label();
            this.client_label_1 = new System.Windows.Forms.Label();
            this.server_system_details_box = new System.Windows.Forms.GroupBox();
            this.port = new System.Windows.Forms.Label();
            this.host_name = new System.Windows.Forms.Label();
            this.IP_address = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.host_name_label = new System.Windows.Forms.Label();
            this.IP_address_label = new System.Windows.Forms.Label();
            this.stop_Server = new System.Windows.Forms.Button();
            this.coordinates_received = new System.Windows.Forms.Label();
            this.start_server = new System.Windows.Forms.Button();
            this.Coordinates_received_label = new System.Windows.Forms.Label();
            this.Create_client_button = new System.Windows.Forms.Button();
            this.client_group_box.SuspendLayout();
            this.server_system_details_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Location = new System.Drawing.Point(339, 21);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(51, 13);
            this.server_label.TabIndex = 0;
            this.server_label.Text = "SERVER";
            // 
            // client_group_box
            // 
            this.client_group_box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.client_group_box.Controls.Add(this.Create_client_button);
            this.client_group_box.Controls.Add(this.client_IP_6);
            this.client_group_box.Controls.Add(this.client_label_6);
            this.client_group_box.Controls.Add(this.client_IP_5);
            this.client_group_box.Controls.Add(this.client_label_5);
            this.client_group_box.Controls.Add(this.client_IP_4);
            this.client_group_box.Controls.Add(this.client_IP_3);
            this.client_group_box.Controls.Add(this.client_label_4);
            this.client_group_box.Controls.Add(this.client_label_3);
            this.client_group_box.Controls.Add(this.client_IP_2);
            this.client_group_box.Controls.Add(this.client_label_2);
            this.client_group_box.Controls.Add(this.client_IP_1);
            this.client_group_box.Controls.Add(this.client_label_1);
            this.client_group_box.Location = new System.Drawing.Point(189, 196);
            this.client_group_box.Name = "client_group_box";
            this.client_group_box.Size = new System.Drawing.Size(377, 202);
            this.client_group_box.TabIndex = 1;
            this.client_group_box.TabStop = false;
            this.client_group_box.Text = "Clients";
            this.client_group_box.Enter += new System.EventHandler(this.Client_group_box_Enter);
            // 
            // client_IP_6
            // 
            this.client_IP_6.AutoSize = true;
            this.client_IP_6.Location = new System.Drawing.Point(218, 162);
            this.client_IP_6.Name = "client_IP_6";
            this.client_IP_6.Size = new System.Drawing.Size(0, 13);
            this.client_IP_6.TabIndex = 12;
            // 
            // client_label_6
            // 
            this.client_label_6.AutoSize = true;
            this.client_label_6.Location = new System.Drawing.Point(158, 162);
            this.client_label_6.Name = "client_label_6";
            this.client_label_6.Size = new System.Drawing.Size(42, 13);
            this.client_label_6.TabIndex = 11;
            this.client_label_6.Text = "Client 6";
            this.client_label_6.Click += new System.EventHandler(this.Client_label_6_Click);
            // 
            // client_IP_5
            // 
            this.client_IP_5.AutoSize = true;
            this.client_IP_5.Location = new System.Drawing.Point(218, 111);
            this.client_IP_5.Name = "client_IP_5";
            this.client_IP_5.Size = new System.Drawing.Size(0, 13);
            this.client_IP_5.TabIndex = 10;
            // 
            // client_label_5
            // 
            this.client_label_5.AutoSize = true;
            this.client_label_5.Location = new System.Drawing.Point(158, 111);
            this.client_label_5.Name = "client_label_5";
            this.client_label_5.Size = new System.Drawing.Size(42, 13);
            this.client_label_5.TabIndex = 9;
            this.client_label_5.Text = "Client 5";
            this.client_label_5.Click += new System.EventHandler(this.Client_label_5_Click);
            // 
            // client_IP_4
            // 
            this.client_IP_4.AutoSize = true;
            this.client_IP_4.Location = new System.Drawing.Point(218, 55);
            this.client_IP_4.Name = "client_IP_4";
            this.client_IP_4.Size = new System.Drawing.Size(0, 13);
            this.client_IP_4.TabIndex = 8;
            // 
            // client_IP_3
            // 
            this.client_IP_3.AutoSize = true;
            this.client_IP_3.Location = new System.Drawing.Point(64, 162);
            this.client_IP_3.Name = "client_IP_3";
            this.client_IP_3.Size = new System.Drawing.Size(0, 13);
            this.client_IP_3.TabIndex = 7;
            // 
            // client_label_4
            // 
            this.client_label_4.AutoSize = true;
            this.client_label_4.Location = new System.Drawing.Point(158, 55);
            this.client_label_4.Name = "client_label_4";
            this.client_label_4.Size = new System.Drawing.Size(42, 13);
            this.client_label_4.TabIndex = 6;
            this.client_label_4.Text = "Client 4";
            this.client_label_4.Click += new System.EventHandler(this.Client_label_4_Click);
            // 
            // client_label_3
            // 
            this.client_label_3.AutoSize = true;
            this.client_label_3.Location = new System.Drawing.Point(6, 162);
            this.client_label_3.Name = "client_label_3";
            this.client_label_3.Size = new System.Drawing.Size(42, 13);
            this.client_label_3.TabIndex = 4;
            this.client_label_3.Text = "Client 3";
            this.client_label_3.Click += new System.EventHandler(this.Client_label_3_Click);
            // 
            // client_IP_2
            // 
            this.client_IP_2.AutoSize = true;
            this.client_IP_2.Location = new System.Drawing.Point(64, 111);
            this.client_IP_2.Name = "client_IP_2";
            this.client_IP_2.Size = new System.Drawing.Size(0, 13);
            this.client_IP_2.TabIndex = 3;
            // 
            // client_label_2
            // 
            this.client_label_2.AutoSize = true;
            this.client_label_2.Location = new System.Drawing.Point(6, 111);
            this.client_label_2.Name = "client_label_2";
            this.client_label_2.Size = new System.Drawing.Size(42, 13);
            this.client_label_2.TabIndex = 2;
            this.client_label_2.Text = "Client 2";
            this.client_label_2.Click += new System.EventHandler(this.Client_label_2_Click);
            // 
            // client_IP_1
            // 
            this.client_IP_1.AutoSize = true;
            this.client_IP_1.Location = new System.Drawing.Point(64, 55);
            this.client_IP_1.Name = "client_IP_1";
            this.client_IP_1.Size = new System.Drawing.Size(0, 13);
            this.client_IP_1.TabIndex = 1;
            // 
            // client_label_1
            // 
            this.client_label_1.AutoSize = true;
            this.client_label_1.Location = new System.Drawing.Point(6, 55);
            this.client_label_1.Name = "client_label_1";
            this.client_label_1.Size = new System.Drawing.Size(42, 13);
            this.client_label_1.TabIndex = 0;
            this.client_label_1.Text = "Client 1";
            this.client_label_1.Click += new System.EventHandler(this.Client_label_1_Click);
            // 
            // server_system_details_box
            // 
            this.server_system_details_box.Controls.Add(this.port);
            this.server_system_details_box.Controls.Add(this.host_name);
            this.server_system_details_box.Controls.Add(this.IP_address);
            this.server_system_details_box.Controls.Add(this.port_label);
            this.server_system_details_box.Controls.Add(this.host_name_label);
            this.server_system_details_box.Controls.Add(this.IP_address_label);
            this.server_system_details_box.Location = new System.Drawing.Point(12, 12);
            this.server_system_details_box.Name = "server_system_details_box";
            this.server_system_details_box.Size = new System.Drawing.Size(225, 153);
            this.server_system_details_box.TabIndex = 2;
            this.server_system_details_box.TabStop = false;
            this.server_system_details_box.Text = "Server System Details";
            this.server_system_details_box.Enter += new System.EventHandler(this.Server_system_details_box_Enter);
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(80, 124);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(0, 13);
            this.port.TabIndex = 7;
            // 
            // host_name
            // 
            this.host_name.AutoSize = true;
            this.host_name.Location = new System.Drawing.Point(87, 74);
            this.host_name.Name = "host_name";
            this.host_name.Size = new System.Drawing.Size(0, 13);
            this.host_name.TabIndex = 6;
            // 
            // IP_address
            // 
            this.IP_address.AutoSize = true;
            this.IP_address.Location = new System.Drawing.Point(87, 25);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(0, 13);
            this.IP_address.TabIndex = 3;
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(7, 124);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(40, 13);
            this.port_label.TabIndex = 5;
            this.port_label.Text = "PORT:";
            this.port_label.Click += new System.EventHandler(this.Port_label_Click);
            // 
            // host_name_label
            // 
            this.host_name_label.AutoSize = true;
            this.host_name_label.Location = new System.Drawing.Point(6, 74);
            this.host_name_label.Name = "host_name_label";
            this.host_name_label.Size = new System.Drawing.Size(74, 13);
            this.host_name_label.TabIndex = 4;
            this.host_name_label.Text = "HOST NAME:";
            this.host_name_label.Click += new System.EventHandler(this.Host_name_label_Click);
            // 
            // IP_address_label
            // 
            this.IP_address_label.AutoSize = true;
            this.IP_address_label.Location = new System.Drawing.Point(6, 25);
            this.IP_address_label.Name = "IP_address_label";
            this.IP_address_label.Size = new System.Drawing.Size(75, 13);
            this.IP_address_label.TabIndex = 3;
            this.IP_address_label.Text = "IP ADDRESS:";
            this.IP_address_label.Click += new System.EventHandler(this.IP_address_label_Click);
            // 
            // stop_Server
            // 
            this.stop_Server.Location = new System.Drawing.Point(637, 278);
            this.stop_Server.Name = "stop_Server";
            this.stop_Server.Size = new System.Drawing.Size(71, 23);
            this.stop_Server.TabIndex = 3;
            this.stop_Server.Text = "Stop Server";
            this.stop_Server.UseVisualStyleBackColor = true;
            this.stop_Server.Click += new System.EventHandler(this.Stop_Server_Click);
            // 
            // coordinates_received
            // 
            this.coordinates_received.AutoSize = true;
            this.coordinates_received.Location = new System.Drawing.Point(389, 107);
            this.coordinates_received.Name = "coordinates_received";
            this.coordinates_received.Size = new System.Drawing.Size(0, 13);
            this.coordinates_received.TabIndex = 4;
            // 
            // start_server
            // 
            this.start_server.Location = new System.Drawing.Point(637, 229);
            this.start_server.Name = "start_server";
            this.start_server.Size = new System.Drawing.Size(71, 23);
            this.start_server.TabIndex = 5;
            this.start_server.Text = "Start Server";
            this.start_server.UseVisualStyleBackColor = true;
            this.start_server.Click += new System.EventHandler(this.Start_server_Click);
            // 
            // Coordinates_received_label
            // 
            this.Coordinates_received_label.AutoSize = true;
            this.Coordinates_received_label.Location = new System.Drawing.Point(380, 74);
            this.Coordinates_received_label.Name = "Coordinates_received_label";
            this.Coordinates_received_label.Size = new System.Drawing.Size(112, 13);
            this.Coordinates_received_label.TabIndex = 6;
            this.Coordinates_received_label.Text = "Coordinates Received";
            this.Coordinates_received_label.Click += new System.EventHandler(this.Coordinates_received_label_Click);
            // 
            // Create_client_button
            // 
            this.Create_client_button.Location = new System.Drawing.Point(294, 10);
            this.Create_client_button.Name = "Create_client_button";
            this.Create_client_button.Size = new System.Drawing.Size(77, 30);
            this.Create_client_button.TabIndex = 7;
            this.Create_client_button.Text = "Create Client";
            this.Create_client_button.UseVisualStyleBackColor = true;
            this.Create_client_button.Click += new System.EventHandler(this.Create_client_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coordinates_received_label);
            this.Controls.Add(this.start_server);
            this.Controls.Add(this.coordinates_received);
            this.Controls.Add(this.stop_Server);
            this.Controls.Add(this.server_system_details_box);
            this.Controls.Add(this.client_group_box);
            this.Controls.Add(this.server_label);
            this.Location = new System.Drawing.Point(800, 200);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Server";
            this.client_group_box.ResumeLayout(false);
            this.client_group_box.PerformLayout();
            this.server_system_details_box.ResumeLayout(false);
            this.server_system_details_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.GroupBox client_group_box;
        private System.Windows.Forms.Label client_label_6;
        private System.Windows.Forms.Label client_label_5;
        private System.Windows.Forms.Label client_label_4;
        private System.Windows.Forms.Label client_label_3;
        private System.Windows.Forms.Label client_label_2;
        private System.Windows.Forms.Label client_label_1;
        public System.Windows.Forms.Label client_IP_6;
        public System.Windows.Forms.Label client_IP_5;
        public System.Windows.Forms.Label client_IP_4;
        public System.Windows.Forms.Label client_IP_3;
        public System.Windows.Forms.Label client_IP_2;
        public System.Windows.Forms.Label client_IP_1;
        private System.Windows.Forms.GroupBox server_system_details_box;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Label host_name;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label host_name_label;
        private System.Windows.Forms.Label IP_address_label;
        public System.Windows.Forms.Label IP_address;
        private System.Windows.Forms.Button stop_Server;
        public System.Windows.Forms.Label coordinates_received;
        private System.Windows.Forms.Button start_server;
        private System.Windows.Forms.Label Coordinates_received_label;
        private System.Windows.Forms.Button Create_client_button;
    }
}