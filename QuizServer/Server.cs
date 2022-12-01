using SuperSimpleTcp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizServer
{
    public partial class Server : Form
    {
        private string contentReceived;
        SimpleTcpServer server1;
        SqlDataReader MyReader2;
        public Server()
        {
            InitializeComponent();
            server1 = new SimpleTcpServer(txt_IPServer.Text, Convert.ToInt32(txt_Port.Text));
            server1.Events.DataReceived += Events_DataReceived;
            server1.Events.ClientConnected += Events_ClientConnected;
            server1.Events.ClientDisconnected += Events_ClientDisconnected;
        }
        public string getCaptcha()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
        public bool queryDatabase(string query)
        {
            string MyConnection2 = "Data Source=VPS\\SQLEXPRESS;Initial Catalog=Quizz_Project;User ID=sa;Password=123456a@";
            SqlConnection MyConn2 = new SqlConnection(MyConnection2);
            SqlCommand MyCommand2 = new SqlCommand(query, MyConn2);           
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();        
            bool check = MyReader2.Read();
            return check;
        }
        private void Server_Load(object sender, EventArgs e)
        {
            
        }      
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            // Please read file IDFunctions.txt to understand what is --11XX 
            contentReceived = Encoding.UTF8.GetString(e.Data.Array);
            showMessage(contentReceived);
            if (contentReceived.Contains("--1111"))
            {
                bool check = queryDatabase(contentReceived);
                string captcha = getCaptcha();
                server1.SendAsync(e.IpPort, check ? captcha : "Fail");
                string email = check ? MyReader2.GetValue(0).ToString() : null;
                if (email != null)
                {
                    MailServices mailServices = new MailServices(email);
                    mailServices.sendMail(captcha);
                }
                showMessage(MyReader2.GetValue(0).ToString());
            } 
            else if((contentReceived.Contains("--1114")) || contentReceived.Contains("--1112"))
            {
                queryDatabase(contentReceived);
                server1.SendAsync(e.IpPort, MyReader2.RecordsAffected > 0 ? "Successfully" : "Fail");
            }
            else if ((contentReceived.Contains("--1110")) || (contentReceived.Contains("--1113")))
            {
                server1.SendAsync(e.IpPort, queryDatabase(contentReceived) ? "Successfully" : "Fail");
            }
            else if(contentReceived.Contains("--1115"))
            {
                string captcha = getCaptcha();
                server1.SendAsync(e.IpPort, captcha);              
                MailServices mailServices = new MailServices(contentReceived.Substring(0,contentReceived.IndexOf('-')));
                mailServices.sendMail(captcha);
            }
            else if(contentReceived.Contains("--1116"))
            {
                queryDatabase(contentReceived);
                string respone = MyReader2.GetValue(0) + " </> " + MyReader2.GetValue(1);
                server1.SendAsync(e.IpPort,respone);
            }
            else if (contentReceived.Contains("--1117"))
            {
                queryDatabase(contentReceived);
                while (MyReader2.Read())
                {
                    QuestAndAnswer quest = new QuestAndAnswer(MyReader2.GetValue(1).ToString(), MyReader2.GetValue(3).ToString(), MyReader2.GetValue(4).ToString(), MyReader2.GetValue(5).ToString(), MyReader2.GetValue(6).ToString(), MyReader2.GetValue(2).ToString());
                    server1.SendAsync(e.IpPort, quest.ToBytesArray());
                    Thread.Sleep(100);
                }
            }
            else if (contentReceived.Contains("--1118"))
            {
                string query = "select max(roomID) from room";
                bool check = queryDatabase(query);
                string IDRoom = ((int)MyReader2.GetValue(0)+1).ToString();             
                showMessage(IDRoom);
                server1.SendAsync(e.IpPort, IDRoom);
            }
            else if (contentReceived.Contains("--1119") || contentReceived.Contains("--1120") || contentReceived.Contains("--1121"))
            {
                queryDatabase(contentReceived);
            }
            else if(contentReceived.Contains("--1122"))
            {
                bool checkQuery = queryDatabase(contentReceived);
                if(checkQuery)
                {
                    while(MyReader2.Read())
                    {
                        RankUser rankUser = new RankUser(MyReader2.GetValue(1).ToString(), MyReader2.GetValue(0).ToString(), Convert.ToInt32(MyReader2.GetValue(2)));
                        server1.SendAsync(e.IpPort, rankUser.ToBytesArray());
                        Thread.Sleep(100);
                    }
                }
            }
            else if (contentReceived.Contains("--1123"))
            {
                server1.SendAsync(e.IpPort,queryDatabase(contentReceived) ? "Successfully" : "Fail");
            }
        }
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            showMessage(e.IpPort + " Disconnected ");
            listClientIP.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            showMessage(e.IpPort + " Connected ");
            listClientIP.Items.Add(e.IpPort);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {                   
            //srcDB = "Data Source=" + txt_DbServer.Text + ";Initial Catalog=" + txt_DbName.Text + ";User ID=" + txt_DbUsername.Text + ";Password=" + txt_DbPass.Text;           
            server1.Start();
            showMessage("Server Started...");
            showMessage("Waiting For Clients...");
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true; 
        
        }
        public void showMessage(string mess)
        {
            txt_Show.Text += "\r\n"+mess ;
        }     
        private void Server_Activated(object sender, EventArgs e)
        {         
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            showMessage("Server Is Going To Stop...");
            foreach(string item in listClientIP.Items)
            {
                server1.DisconnectClient(item);
            }
            server1.Stop();
            showMessage("Server Stopped...");
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
        }
    }
}
