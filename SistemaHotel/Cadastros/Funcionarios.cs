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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtNIF.Enabled = true;
            txtEndereco.Enabled = true;
            txtContacto.Enabled = true;
            cbCargo.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtNIF.Enabled = false;
            txtEndereco.Enabled = false;
            txtContacto.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNIF.Text = "";
            txtEndereco.Text = "";
            txtContacto.Text = "";
            cbCargo.Text = "";
        }



        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtProcurarNome.Visible = true;
            txtProcurarNIF.Visible = false;

            txtProcurarNome.Text = "";
            txtProcurarNIF.Text = "";
            txtProcurarNome.Focus();

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
        }

        private void rbNIF_CheckedChanged(object sender, EventArgs e)
        {
            txtProcurarNome.Visible = false;
            txtProcurarNIF.Visible = true;
            txtProcurarNIF.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo do Nome!" , "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            
            if (txtNIF.Text == "        ")
            {
                MessageBox.Show("Preencha o campo do NIF!" , "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIF.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO SALVAR

            MessageBox.Show("Registo salvo com sucesso!" , "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnApagar.Enabled = true;
            btnSalvar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtNome.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if(txtNIF.ToString().Trim() == "        ")
            {
                MessageBox.Show("Preencha o campo NIF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIF.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO EDITAR

            MessageBox.Show("Registo editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza apagar o registo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("carregou em SIM");
            }

            //CÓDIGO DO BOTÃO APAGAR

            MessageBox.Show("Registo eliminado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }
    }
}
