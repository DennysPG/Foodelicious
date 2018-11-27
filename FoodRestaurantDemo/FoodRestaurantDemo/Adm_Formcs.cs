using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRestaurantDemo
{
    public partial class Adm_Formcs : Form
    {
        public Adm_Formcs()
        {
            InitializeComponent();
            monitorar1.Visible = true;
            dados1.Visible = false;
            upd_Dados1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem a certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monitorar1.Visible = true;
            dados1.Visible = false;
            upd_Dados1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monitorar1.Visible = false;
            dados1.Visible = true;
            upd_Dados1.Visible = false;
        }

        private void Adm_Formcs_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            monitorar1.Visible = false;
            dados1.Visible = false;
            upd_Dados1.Visible = true;
        }
    }
}
