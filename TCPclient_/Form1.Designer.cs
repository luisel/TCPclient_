using System;

namespace TCPclient_
{
    partial class Form1
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
            this.coordinates_groupBox = new System.Windows.Forms.GroupBox();
            this.distance_result = new System.Windows.Forms.Label();
            this.distance_label = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.coordinate_label_2 = new System.Windows.Forms.Label();
            this.coordinate_label_1 = new System.Windows.Forms.Label();
            this.z_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.z2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.z1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.server_groupBox = new System.Windows.Forms.GroupBox();
            this.serverIP_address = new System.Windows.Forms.Label();
            this.serverIP_label = new System.Windows.Forms.Label();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.client_label = new System.Windows.Forms.Label();
            this.coordinates_groupBox.SuspendLayout();
            this.server_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coordinates_groupBox
            // 
            this.coordinates_groupBox.Controls.Add(this.distance_result);
            this.coordinates_groupBox.Controls.Add(this.distance_label);
            this.coordinates_groupBox.Controls.Add(this.send_button);
            this.coordinates_groupBox.Controls.Add(this.coordinate_label_2);
            this.coordinates_groupBox.Controls.Add(this.coordinate_label_1);
            this.coordinates_groupBox.Controls.Add(this.z_label);
            this.coordinates_groupBox.Controls.Add(this.y_label);
            this.coordinates_groupBox.Controls.Add(this.x_label);
            this.coordinates_groupBox.Controls.Add(this.z2);
            this.coordinates_groupBox.Controls.Add(this.y2);
            this.coordinates_groupBox.Controls.Add(this.x2);
            this.coordinates_groupBox.Controls.Add(this.z1);
            this.coordinates_groupBox.Controls.Add(this.y1);
            this.coordinates_groupBox.Controls.Add(this.x1);
            this.coordinates_groupBox.Location = new System.Drawing.Point(221, 107);
            this.coordinates_groupBox.Name = "coordinates_groupBox";
            this.coordinates_groupBox.Size = new System.Drawing.Size(378, 229);
            this.coordinates_groupBox.TabIndex = 0;
            this.coordinates_groupBox.TabStop = false;
            this.coordinates_groupBox.Text = "Enter Coordinates";
            this.coordinates_groupBox.Enter += new System.EventHandler(this.Coordinates_groupBox_Enter);
            // 
            // distance_result
            // 
            this.distance_result.AutoSize = true;
            this.distance_result.Location = new System.Drawing.Point(312, 76);
            this.distance_result.Name = "distance_result";
            this.distance_result.Size = new System.Drawing.Size(0, 13);
            this.distance_result.TabIndex = 13;
            // 
            // distance_label
            // 
            this.distance_label.AutoSize = true;
            this.distance_label.Location = new System.Drawing.Point(306, 48);
            this.distance_label.Name = "distance_label";
            this.distance_label.Size = new System.Drawing.Size(49, 13);
            this.distance_label.TabIndex = 12;
            this.distance_label.Text = "Distance";
            this.distance_label.Click += new System.EventHandler(this.Distance_label_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(144, 185);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(87, 31);
            this.send_button.TabIndex = 11;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // coordinate_label_2
            // 
            this.coordinate_label_2.AutoSize = true;
            this.coordinate_label_2.Location = new System.Drawing.Point(192, 48);
            this.coordinate_label_2.Name = "coordinate_label_2";
            this.coordinate_label_2.Size = new System.Drawing.Size(96, 13);
            this.coordinate_label_2.TabIndex = 10;
            this.coordinate_label_2.Text = "2nd 3D Coordinate";
            this.coordinate_label_2.Click += new System.EventHandler(this.Coordinate_label_2_Click);
            // 
            // coordinate_label_1
            // 
            this.coordinate_label_1.AutoSize = true;
            this.coordinate_label_1.Location = new System.Drawing.Point(85, 48);
            this.coordinate_label_1.Name = "coordinate_label_1";
            this.coordinate_label_1.Size = new System.Drawing.Size(92, 13);
            this.coordinate_label_1.TabIndex = 9;
            this.coordinate_label_1.Text = "1st 3D Coordinate";
            this.coordinate_label_1.Click += new System.EventHandler(this.Coordinate_label_1_Click);
            // 
            // z_label
            // 
            this.z_label.AutoSize = true;
            this.z_label.Location = new System.Drawing.Point(74, 158);
            this.z_label.Name = "z_label";
            this.z_label.Size = new System.Drawing.Size(14, 13);
            this.z_label.TabIndex = 8;
            this.z_label.Text = "Z";
            this.z_label.Click += new System.EventHandler(this.Z_label_Click);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(74, 119);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(14, 13);
            this.y_label.TabIndex = 7;
            this.y_label.Text = "Y";
            this.y_label.Click += new System.EventHandler(this.Y_label_Click);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(74, 79);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 13);
            this.x_label.TabIndex = 6;
            this.x_label.Text = "X";
            this.x_label.Click += new System.EventHandler(this.X_label_Click);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(221, 155);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(41, 20);
            this.z2.TabIndex = 5;
            this.z2.TextChanged += new System.EventHandler(this.Z2_TextChanged);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(221, 116);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(41, 20);
            this.y2.TabIndex = 4;
            this.y2.TextChanged += new System.EventHandler(this.Y2_TextChanged);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(221, 76);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(41, 20);
            this.x2.TabIndex = 3;
            this.x2.TextChanged += new System.EventHandler(this.X2_TextChanged);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(112, 155);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(41, 20);
            this.z1.TabIndex = 2;
            this.z1.TextChanged += new System.EventHandler(this.Z1_TextChanged);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(112, 116);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(41, 20);
            this.y1.TabIndex = 1;
            this.y1.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(112, 76);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(41, 20);
            this.x1.TabIndex = 0;
            this.x1.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // server_groupBox
            // 
            this.server_groupBox.Controls.Add(this.serverIP_address);
            this.server_groupBox.Controls.Add(this.serverIP_label);
            this.server_groupBox.Controls.Add(this.disconnect_button);
            this.server_groupBox.Controls.Add(this.connect_button);
            this.server_groupBox.Location = new System.Drawing.Point(221, 342);
            this.server_groupBox.Name = "server_groupBox";
            this.server_groupBox.Size = new System.Drawing.Size(378, 109);
            this.server_groupBox.TabIndex = 1;
            this.server_groupBox.TabStop = false;
            this.server_groupBox.Text = "Server";
            this.server_groupBox.Enter += new System.EventHandler(this.Server_groupBox_Enter);
            // 
            // serverIP_address
            // 
            this.serverIP_address.AutoSize = true;
            this.serverIP_address.Location = new System.Drawing.Point(150, 79);
            this.serverIP_address.Name = "serverIP_address";
            this.serverIP_address.Size = new System.Drawing.Size(0, 13);
            this.serverIP_address.TabIndex = 14;
            // 
            // serverIP_label
            // 
            this.serverIP_label.AutoSize = true;
            this.serverIP_label.Location = new System.Drawing.Point(87, 79);
            this.serverIP_label.Name = "serverIP_label";
            this.serverIP_label.Size = new System.Drawing.Size(51, 13);
            this.serverIP_label.TabIndex = 3;
            this.serverIP_label.Text = "Server IP";
            this.serverIP_label.Click += new System.EventHandler(this.ServerIP_label_Click);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(206, 33);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.disconnect_button.TabIndex = 1;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(88, 33);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Location = new System.Drawing.Point(379, 28);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(45, 13);
            this.client_label.TabIndex = 2;
            this.client_label.Text = "CLIENT";
            this.client_label.Click += new System.EventHandler(this.Client_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.client_label);
            this.Controls.Add(this.server_groupBox);
            this.Controls.Add(this.coordinates_groupBox);
            this.Location = new System.Drawing.Point(0, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Client";
            this.coordinates_groupBox.ResumeLayout(false);
            this.coordinates_groupBox.PerformLayout();
            this.server_groupBox.ResumeLayout(false);
            this.server_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox coordinates_groupBox;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label coordinate_label_2;
        private System.Windows.Forms.Label coordinate_label_1;
        private System.Windows.Forms.Label z_label;
        private System.Windows.Forms.GroupBox server_groupBox;
        private System.Windows.Forms.Label serverIP_label;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label distance_label;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.Label distance_result;
        private System.Windows.Forms.Label serverIP_address;
    }
}

