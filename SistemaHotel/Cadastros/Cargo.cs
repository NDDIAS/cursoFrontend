using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            txtCargo.Enabled = true;
            txtCargo.Focus();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo do Nome!" , "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            MessageBox.Show("Registo gravado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtCargo.Text = "";
            txtCargo.Enabled = false;
            
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnApagar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo do Nome!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Text = "";
                txtCargo.Focus();
                return;
            }

            
            //CÓDIGO DO BOTÃO EDITAR

            MessageBox.Show("Registo editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            txtCargo.Text = "";
            txtCargo.Enabled = false;
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza apagar o registo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                MessageBox.Show("carregou em SIM");
            }

            //CÓDIGO DO BOTÃO EDITAR

            MessageBox.Show("Registo eliminado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            txtCargo.Text = "";
            txtCargo.Enabled = false;
        }
    }
}
