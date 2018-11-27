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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem a certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Login ou Senha Invalidos!", "Alerta");
                textBox2.Text = "";
            }
            if(textBox1.Text.Equals("CLI") && textBox2.Text.Equals("CLI"))
            {
                Cli_Form cli = new Cli_Form();
                cli.Show();
                this.Hide();
            }
            if (textBox1.Text.Equals("ADMIN") && textBox2.Text.Equals("ADMIN"))
            {
                Adm_Formcs adm = new Adm_Formcs();
                adm.Show();
                this.Hide();
            }
            if (textBox1.Text.Equals("FUNC") && textBox2.Text.Equals("FUNC"))
            {
                FuncForm func = new FuncForm();
                func.Show();
                this.Hide();
            }

        }
    }
}
