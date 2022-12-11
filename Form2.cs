using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "claude" && textBox2.Text == "1234" || textBox1.Text == "Edgar" && textBox2.Text == "567")
            {
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            else { 
            
                MessageBox.Show("Permission denied");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
