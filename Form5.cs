using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Garage
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

            try
            {
                string K1, K2, K3, K4;
                K1 = textBox1.Text;
                K2 = textBox2.Text;
                K3 = textBox3.Text;
                K4 = textBox4.Text;
                string req = "INSERT INTO garage.client(Idclient,nom,prenom,telephone)VALUES('" + K1 + "','" + K2 + "','" + K3 + "','" + K4 + "')";
                connection.Open();

                MySqlCommand command = new MySqlCommand(req, connection);// initialisation et if(command.ExecuteNonquery() == 1)

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bravo!!!Les donnees ont ete inserees avec succes!!!!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Echec d'insertion");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connexion echouée:" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

   

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            try
            {
                string K1, K2, K3, K4;
                K1 = textBox1.Text;
                K2 = textBox2.Text;
                K3 = textBox3.Text;
                K4 = textBox4.Text;
                string req = "DELETE FROM garage.client WHERE Idclient='" + textBox1.Text + "'";
                connection.Open();

                MySqlCommand command = new MySqlCommand(req, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bravo l'AuthenticationPluginConfigurationElement a ete supprimer avec succes");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {

                    MessageBox.Show("la suppression a ete echoue");
                    

                }



            }
            catch
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string K1, K2, K3, K4;
            K1 = textBox1.Text;
            K2 = textBox2.Text;
            K3 = textBox3.Text;
            K4 = textBox4.Text;
            connection.Open();
            string req = "UPDATE garage.client SET nom='" + textBox2.Text + "', prenom='" + textBox3.Text + "', telephone='" + textBox4.Text + "' WHERE Idclient=" + textBox1.Text + "";
            /*MySqlCommand cmd = new MySqlCommand(req);*/
            MySqlCommand command = new MySqlCommand(req, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bravo la modification a ete Reussie avec succes");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {

                MessageBox.Show("la modification a echoue");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            connection.Open();
            string req = "SELECT*FROM garage.client ";
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter adap = new MySqlDataAdapter(req, connection);
                adap = new MySqlDataAdapter(req, connection);
                adap.Fill(ds, "req");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "req";
            }   
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
        
    }

}
