using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NetcatApplication
{
    public partial class Form1 : Form
    {
        public static Form1 f1 = null;
        delegate void SetTextCallback(string text);

        class netcat 
        {
            class netcatUdp 
            {
                class netcatUdpServer 
                {
                    UdpClient client = new UdpClient(int.Parse(f1.LPortText.Text));
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                    void tx(Object sender, EventArgs Event)
                    {
                            String txMessage = f1.txTextBox.Text;
                            if (txMessage != "")
                            {
                                f1.rxTextBox.AppendText("server > " + txMessage + Environment.NewLine);
                                client.Send(Encoding.ASCII.GetBytes(txMessage), txMessage.Length, RemoteIpEndPoint.Address.ToString(), Convert.ToInt32(RemoteIpEndPoint.Port));
                               
                            }
                    }

                    String rx()
                    {
                        String rxMessage = Encoding.ASCII.GetString(client.Receive(ref RemoteIpEndPoint));
                        return rxMessage;
                    }

                    void sendText() 
                    {
                        if (rx() != "")
                        {
                            f1.sendButton.Click += tx;
                        }
                    }

                    void recieveText() 
                    {
                        while (true) 
                        {
                            f1.rxTextBox.AppendText("Client > " + rx() + Environment.NewLine);
                        }
                    }

                    public netcatUdpServer()
                    {
                        new Thread(recieveText).Start();
                        new Thread(sendText).Start();
                        f1.rxTextBox.AppendText("UdpServerActive" + Environment.NewLine);

                    }
                }

                class netcatUdpClient 
                {
                    UdpClient client = new UdpClient();
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
               

                   void tx(Object sender, EventArgs Event)
                   {
                           String txMessage = f1.txTextBox.Text;
                           if (txMessage != "")
                           {
                               f1.rxTextBox.AppendText("client > " + txMessage + Environment.NewLine);
                               client.Send(Encoding.ASCII.GetBytes(txMessage), txMessage.Length, f1.RAddressText.Text, int.Parse(f1.RPortText.Text));
                           }
                   }

                    string rx()
                    {
                            String rxMessage = Encoding.ASCII.GetString(client.Receive(ref RemoteIpEndPoint));
                            return rxMessage;
                    }

                    void sendText()
                    {
                            f1.sendButton.Click += tx;
                    }

                    void recieveText()
                    {
                        while (true)
                        {
                            f1.rxTextBox.AppendText("Server > " + rx() + Environment.NewLine);
                        }
                    }


                    public netcatUdpClient()
                    {
                        client.Client.Bind(RemoteIpEndPoint);
                        new Thread(recieveText).Start();
                        new Thread(sendText).Start();
                        f1.rxTextBox.AppendText("UdpClientActive" + Environment.NewLine);
                        
                    }

                }

                public netcatUdp() 
                {
                    if (f1.roleList.SelectedIndex == 0) 
                    {
                        new netcatUdpServer();
                        
                    }
                    else if (f1.roleList.SelectedIndex == 1)
                    {
                        new netcatUdpClient();

                    }
                }
            }

            public netcat() 
            {

                if (f1.roleList.SelectedIndex == 0 || f1.roleList.SelectedIndex == 1)
                {
                    new netcatUdp();
                }
            }
        }


       

        public Form1()
        {
            InitializeComponent();
            f1 = this;
            
        }

        private void startButton_Click(Object sender, EventArgs Event)
        {
           if(RAddressText.Text != "" && RPortText.Text != "" || LPortText.Text != "")
            new netcat();

        }

        
        
        

        private void quitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        

       
    }
}
