using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Produtos
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedores.Enabled = true;
            txtStock.Enabled = true;
            txtNome.Focus();
            btnImg.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            txtStock.Enabled = false;
            cbFornecedores.Enabled = false;
            btnImg.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtStock.Text = "";
            LimparFoto();
            cbFornecedores.Text = "";
        }

        private void LimparFoto()
        {
            img.Image = Properties.Resources.sem_foto;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
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
                MessageBox.Show("Preencha o campo do Nome!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o campo do valor!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO SALVAR

            MessageBox.Show("Registo salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (txtValor.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo NIF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
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

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*)";
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                string foto = dialogo.FileName.ToString().Trim();
                img.ImageLocation = foto;
            }
        }
    }
}
