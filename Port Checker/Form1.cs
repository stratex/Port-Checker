using System;
using System.Drawing;
using System.Windows.Forms;
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

        private void cmdStart_Click(object sender, EventArgs e)
        {
            listPort.Items.Clear();
            Thread oThread = new Thread(new ThreadStart(CheckPorts));
            oThread.IsBackground = true;
            oThread.Start();
        }

        private void CheckPorts()
        {
            for (int i = (int)PortMin.Value; i <= (int)PortMax.Value; i++)
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult connectTimeout = s.BeginConnect(txtIP.Text, i, null, null);
                connectTimeout.AsyncWaitHandle.WaitOne(500);
                if (s.Connected)
                    AddItem(i, "Open");
                else
                    AddItem(i, "Closed");
            }
        }

        private void AddItem(int port, string state)
        {
            if (!InvokeRequired)
            {
                if(state == "Open")
                    listPort.Items.Add(new ListViewItem(new string[] { port.ToString(), "Open" })).ForeColor = Color.Green;
                else if(state == "Closed")
                    listPort.Items.Add(new ListViewItem(new string[] { port.ToString(), "Closed" })).ForeColor = Color.Red;
            }
            else
            {
                Invoke(new Action<int, string>(AddItem), port, state);
            }
        }

        void I(Action a)
        {
            Invoke((MethodInvoker)delegate ()
            {
                a.Invoke();
            });

        }
    }

}
