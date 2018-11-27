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
    public partial class Monitorar : UserControl
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public Monitorar()
        {
            InitializeComponent();
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Server=localhost;Database=db;Uid=root;Pwd= ");
            try
            {
                mConn.Open();
            }
            catch (System.Exception e)
            {
                //MessageBox.Show(e.Message.ToString());
            }
            if (mConn.State == ConnectionState.Open)
            {
                mAdapter = new MySqlDataAdapter("SELECT * FROM log_full", mConn);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource=dt;
                dataGridView1.DataSource = bs;
                mAdapter.Update(dt);
            }
        }

        private void Monitorar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            mAdapter = new MySqlDataAdapter("SELECT * FROM log_full", mConn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            mAdapter.Update(dt);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mAdapter = new MySqlDataAdapter("SELECT * FROM log_full WHERE `TABELA` = '" + comboBox1.Text+"'", mConn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            mAdapter.Update(dt);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mAdapter = new MySqlDataAdapter("SELECT * FROM log_full WHERE `USER` = '" + comboBox2.Text + "'", mConn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            mAdapter.Update(dt);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            mAdapter = new MySqlDataAdapter("SELECT * FROM log_full WHERE `COMANDO` = '" + comboBox3.Text + "'", mConn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            mAdapter.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mAdapter = new MySqlDataAdapter("SELECT * FROM log_full WHERE CONCAT (`ID`, `TABELA`, `DATA_HORA`, `COMANDO`, `USER`) like '%" + textBox1.Text + "%'", mConn);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            mAdapter.Update(dt);
        }
    }
}
