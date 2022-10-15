using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public static string name = "";

        private void main_Load(object sender, EventArgs e)
        {
            labelname.Text = name;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
