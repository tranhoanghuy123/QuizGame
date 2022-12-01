namespace QuizServer
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IPServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Show = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DbServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DbPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listClientIP = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Server:";
            // 
            // txt_IPServer
            // 
            this.txt_IPServer.Location = new System.Drawing.Point(120, 59);
            this.txt_IPServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IPServer.Name = "txt_IPServer";
            this.txt_IPServer.Size = new System.Drawing.Size(175, 26);
            this.txt_IPServer.TabIndex = 1;
            this.txt_IPServer.Text = "192.168.1.30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(120, 104);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(175, 26);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "8888";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(881, 59);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(145, 27);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(881, 102);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(145, 26);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_Show
            // 
            this.txt_Show.Location = new System.Drawing.Point(2, 225);
            this.txt_Show.Multiline = true;
            this.txt_Show.Name = "txt_Show";
            this.txt_Show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Show.Size = new System.Drawing.Size(673, 361);
            this.txt_Show.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server Database:";
            // 
            // txt_DbServer
            // 
            this.txt_DbServer.Location = new System.Drawing.Point(679, 40);
            this.txt_DbServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DbServer.Name = "txt_DbServer";
            this.txt_DbServer.Size = new System.Drawing.Size(175, 26);
            this.txt_DbServer.TabIndex = 1;
            this.txt_DbServer.Text = "VPS\\\\SQLEXPRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Database Name:";
            // 
            // txt_DbName
            // 
            this.txt_DbName.Location = new System.Drawing.Point(679, 76);
            this.txt_DbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DbName.Name = "txt_DbName";
            this.txt_DbName.Size = new System.Drawing.Size(175, 26);
            this.txt_DbName.TabIndex = 1;
            this.txt_DbName.Text = "Quizz_Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // txt_DbUsername
            // 
            this.txt_DbUsername.Location = new System.Drawing.Point(679, 112);
            this.txt_DbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DbUsername.Name = "txt_DbUsername";
            this.txt_DbUsername.Size = new System.Drawing.Size(175, 26);
            this.txt_DbUsername.TabIndex = 1;
            this.txt_DbUsername.Text = "sa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // txt_DbPass
            // 
            this.txt_DbPass.Location = new System.Drawing.Point(679, 148);
            this.txt_DbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DbPass.Name = "txt_DbPass";
            this.txt_DbPass.Size = new System.Drawing.Size(175, 26);
            this.txt_DbPass.TabIndex = 1;
            this.txt_DbPass.Text = "123456a@";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thông  Tin Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thông  Tin Database";
            // 
            // listClientIP
            // 
            this.listClientIP.FormattingEnabled = true;
            this.listClientIP.ItemHeight = 20;
            this.listClientIP.Location = new System.Drawing.Point(681, 225);
            this.listClientIP.Name = "listClientIP";
            this.listClientIP.Size = new System.Drawing.Size(336, 364);
            this.listClientIP.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Client IP:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 598);
            this.Controls.Add(this.listClientIP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Show);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_DbPass);
            this.Controls.Add(this.txt_DbName);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DbServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IPServer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "Sever";
            this.Activated += new System.EventHandler(this.Server_Activated);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txt_Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DbServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DbPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listClientIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

