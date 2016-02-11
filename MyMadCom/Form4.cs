using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMadCom
{
  
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           // Program.name = textBox1.Text;
                    Form1 f = new Form1();
                    this.Hide();
                    f.Show();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
