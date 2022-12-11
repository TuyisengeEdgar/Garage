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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");

            try
            {
                string K1, K2, K3;
                K1 = textBox1.Text;
                K2 = textBox2.Text;
                K3 = textBox3.Text;

                string req = "INSERT INTO garage.employer(N0matricule,nom,prenom)VALUES('" + K1 + "','" + K2 + "','" + K3 + "')";
                connection.Open();

                MySqlCommand command = new MySqlCommand(req, connection);// initialisation et if(command.ExecuteNonquery() == 1)

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bravo!!!Les donnees ont ete inserees avec succes!!!!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                   
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

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            try
            {
                string K1, K2, K3;
                K1 = textBox1.Text;
                K2 = textBox2.Text;
                K3 = textBox3.Text;
                
                string req = "DELETE FROM garage.employer WHERE N0matricule='" + textBox1.Text + "'";
                connection.Open();

                MySqlCommand command = new MySqlCommand(req, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bravo l'element a ete supprimer avec succes");
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
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string K1, K2, K3;
            K1 = textBox1.Text;
            K2 = textBox2.Text;
            K3 = textBox3.Text;
            
            connection.Open();
            string req = "UPDATE garage.employer SET nom='" + textBox2.Text + "', prenom='" + textBox3.Text + "' WHERE N0matricule=" + textBox1.Text + "";
            /*MySqlCommand cmd = new MySqlCommand(req);*/
            MySqlCommand command = new MySqlCommand(req,connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bravo la modification a ete Reussie avec succes");
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
            string req = "SELECT*FROM garage.employer ";
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        }
    }
