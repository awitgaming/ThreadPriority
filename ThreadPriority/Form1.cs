using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread2);
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            Thread ThreadD = new Thread(MyThreadClass.Thread2);

            

            ThreadA.Priority = System.Threading.ThreadPriority.Highest;
            ThreadB.Priority = System.Threading.ThreadPriority.Normal;
            ThreadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            ThreadD.Priority = System.Threading.ThreadPriority.BelowNormal;


            
            ThreadA.Name = "Thread A: ";
            ThreadB.Name = "Thread B: ";
            ThreadC.Name = "Thread C: ";
            ThreadD.Name = "Thread D: ";

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();


            lblDisplay.Text = "     -End of Thread-";
            Console.WriteLine("-End Of Thread-");
        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {

        }
    }
}
