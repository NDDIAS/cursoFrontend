using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlDireita.BackColor = Color.FromArgb(120, 120, 120);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.Funcionarios form = new Cadastros.Funcionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.Cargo form = new Cadastros.Cargo();
            form.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }
    }
}
