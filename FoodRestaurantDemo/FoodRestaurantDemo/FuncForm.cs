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
    public partial class FuncForm : Form
    {
        public FuncForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem a certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
