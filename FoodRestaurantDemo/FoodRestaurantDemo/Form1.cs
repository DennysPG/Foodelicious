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
    public partial class Cli_Form : Form
    {
        public Cli_Form()
        {
            InitializeComponent();
            firstProduct11.Visible = true;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = false;
            pedido61.Visible = false;
            cupom71.Visible = false;
            help1.Visible = false;
            news1.Visible = false;
        }

        private void Cli_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem a certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
            {
                Application.Exit();
            }
    }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstProduct11.Visible == true) { firstProduct11.Visible = false; thirdProduct31.Visible = true; }
            else if (thirdProduct31.Visible == true) { thirdProduct31.Visible = false; secondProduct21.Visible = true; }
            else if (secondProduct21.Visible == true) { secondProduct21.Visible = false; firstProduct11.Visible = true; }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = true;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = false;
            pedido61.Visible = false;
            cupom71.Visible = false;
            button9.Visible = true;
            button8.Visible = true;
            help1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = false;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = true;
            menu51.Visible = false;
            pedido61.Visible = false;
            cupom71.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            help1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstProduct11.Visible == true) { firstProduct11.Visible = false; secondProduct21.Visible = true; }
            else if (secondProduct21.Visible == true) { secondProduct21.Visible = false; thirdProduct31.Visible = true; }
            else if (thirdProduct31.Visible == true) { thirdProduct31.Visible = false; firstProduct11.Visible = true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = false;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = true;
            pedido61.Visible = false;
            cupom71.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            help1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = false;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = false;
            pedido61.Visible = true;
            cupom71.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            help1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = false;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = false;
            pedido61.Visible = false;
            cupom71.Visible = true;
            button9.Visible = false;
            button8.Visible = false;
            help1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            firstProduct11.Visible = false;
            secondProduct21.Visible = false;
            thirdProduct31.Visible = false;
            offers41.Visible = false;
            menu51.Visible = false;
            pedido61.Visible = false;
            cupom71.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            help1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(news1.Visible == false)news1.Visible = true;
            else news1.Visible = false;
        }
    }
}
