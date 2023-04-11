using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromTesst
{
    public partial class Frmhihi : Form
    {
        public Frmhihi()
        {
            InitializeComponent();
        }
        int Time = 600;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time--;
            textBox1.Text = $"{Time}";
        }
    }
}
