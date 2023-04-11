using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("alo");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
        int Time = 600;
        private void timerTime_Tick(object sender, EventArgs e)
        {
            Time--;
            string strTime = $"{Time / 60}:{Time % 60}";
            txtTime.Text = strTime;
        }
    }
}
