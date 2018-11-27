using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace FoodRestaurantDemo
{
    public partial class Dados : UserControl
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*string constring = "Server=localhost;Database=db;Uid=root;Pwd= ";
            // string query = "INSERT INTO cliente (CPF, NOME, TEL, ENDEREÇO) VALUES ('"+textBox1.Text+ "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            string query = "INSERT INTO cliente (CPF, NOME, TEL, ENDEREÇO) VALUES ('12345678', 'kkkkkkkkkk', '83626327362', 'kkkkkkkkk')";
            MySqlConnection condb = new MySqlConnection(constring);
            //  MySqlCommand comdb = new MySqlCommand(query, condb);
            condb.Open();
            MySqlCommand comdb = condb.CreateCommand();
            comdb.CommandText = query;
            comdb.ExecuteNonQuery();
            condb.Close();
            */
            MessageBox.Show("Salvo");

        }
    }
}
