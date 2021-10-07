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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width/2-166,this.Height/2-170);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }

        }

        private void ChamarLogin()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Preencha o campo do Utilizador!");
                txtUser.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Preencha o campo Password");
                txtPassword.Focus();
                return;
            }



            FrmMenu form = new FrmMenu();
            //this.Hide();
            Limpar();
            form.Show();          
        }

        private void Limpar()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            //166 é metade do tamanho do painel na largura e 170 é metade da altura
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
