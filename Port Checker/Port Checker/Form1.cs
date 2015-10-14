using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Port_Checker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            listPort.View = View.Details;
            listPort.Columns.Add("Port");
            listPort.Columns.Add("State");
        }

        #region Port Check
        public class PortChecker : IDisposable
        {
            Socket _socket;
            public PortChecker()
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            public bool PortOpen(string ip, int port, int timeout)
            {
                try
                {
                    _socket.Connect(ip, port);
                    return _socket.Connected;
                }
                catch
                {
                    return _socket.Connected;
                }
            }

            void IDisposable.Dispose()
            {
                _socket.Dispose();
            }
        }
        #endregion

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(CheckPorts));
            oThread.IsBackground = true;
            oThread.Start();
        }

        private void CheckPorts()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    listPort.Items.Clear();
                }));
            }
            else
                listPort.Items.Clear();
            using (PortChecker pc = new PortChecker())
            {
                for (int i = (int)PortMin.Value; i <= (int)PortMax.Value; i++)
                {
                    if (pc.PortOpen(txtIP.Text, i, 1000))
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new EventHandler(delegate
                            {
                                listPort.Items.Add(new ListViewItem(new string[] { i.ToString(), "Open" })).ForeColor = Color.Green;
                            }));
                        }
                        else
                            listPort.Items.Add(new ListViewItem(new string[] { i.ToString(), "Open" })).ForeColor = Color.Green;
                    }
                    else
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new EventHandler(delegate
                            {
                                listPort.Items.Add(new ListViewItem(new string[] { i.ToString(), "Closed" })).ForeColor = Color.Red;
                            }));
                        }
                        else
                            listPort.Items.Add(new ListViewItem(new string[] { i.ToString(), "Closed" })).ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}

