using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;

namespace MyMadCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bst b;
        private void Form1_Load(object sender, EventArgs e)
        {
           // label1.Text = Program.name;
            this.MaximumSize = this.MinimumSize = this.Size;
            string[] arr = File.ReadAllLines("ques.txt");
            string[] arr2 = File.ReadAllLines("ans.txt");

             b = new bst();
            for (int i = 0; i < arr.Length; i++)
            {

                QA ab = new QA(arr[i],arr2[i]);
                b.add(ab);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                listBox1.Items.Add( textBox1.Text);
                b.Print(listBox1, textBox1.Text);
                SpeechSynthesizer say = new SpeechSynthesizer();
                say.Speak(listBox1.Items[listBox1.Items.Count - 1].ToString());
                textBox1.Clear();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listBox2.Items.Clear();
        }
    }
}
