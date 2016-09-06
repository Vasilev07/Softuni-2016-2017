using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.CatchTheButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations! You win!");
        }

     

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.Width - btnCatchMe.ClientSize.Width;
            var maxHeight = this.Height - btnCatchMe.ClientSize.Height;
            this.btnCatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
        }
    }
}
