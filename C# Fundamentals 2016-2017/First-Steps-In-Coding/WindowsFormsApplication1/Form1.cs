using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox cont = this.Controls.Find("TextBox3", true).FirstOrDefault() as TextBox;

            //input.Text = "Button clicked";
            TextBox firstTB = this.Controls.Find("textBox1", true).FirstOrDefault() as TextBox;
            TextBox secondTB = this.Controls.Find("textBox2", true).FirstOrDefault() as TextBox;
            int result = int.Parse(firstTB.Text) + int.Parse(secondTB.Text);
            cont.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
