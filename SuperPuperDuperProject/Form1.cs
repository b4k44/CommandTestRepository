using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPuperDuperProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            this.Text = "Aboba Time!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Path.GetRandomFileName();
        }
    }
}
