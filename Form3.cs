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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void gestionDesEmployesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Show();
        }

        private void gestionDesPiecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Show();
        }
    }
}
