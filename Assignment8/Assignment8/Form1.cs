using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Employee Registration Form");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string Desig = textBox3.Text;

            fs = new FileStream(@"C:\Users\test\Downloads\EData.txt", FileMode.Append, FileAccess.Write);

            sw = new StreamWriter(fs);

            sw.Write(id+" ");
            sw.Write(name + " ");
            sw.Write(Desig + "\n ");

            MessageBox.Show("Your information is saved!!");
            sw.Close();
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream(@"C:\Users\test\Downloads\EData.txt", FileMode.Open, FileAccess.Read);

            sr = new StreamReader(fs);

            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }
}
