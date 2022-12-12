using KittensSports.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittensSports.View
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        public TelaCadastroUsuario(Usuario obj, bool alterando)
        {
            InitializeComponent();
            if (alterando)
            {

                ttbUsername.Enabled = false;
                btnGravar.Visible = false;
                btnAlterar.Visible = true;

            }
            else
            {
                btnGravar.Visible = true;
                btnAlterar.Visible = false;
            }
            ttbNome.Text = obj.NomeCompleto.ToString();
            ttbEmail.Text = obj.Email.ToString();
            ttbUsername.Text = obj.Username.ToString();
            ttbSenha.Text = obj.Password.ToString();
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(ttbSenha.UseSystemPasswordChar==true)
            {
                ttbSenha.UseSystemPasswordChar=false;
                btnVer.Text = "Ocultar";
            }
            else
            {
                ttbSenha.UseSystemPasswordChar=true;
                btnVer.Text = "Ver";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!TemEntradasValidas())
                return;

            //Montar o objeto para gravaçãoasd
            Usuario objUsuario = new Usuario(ttbUsername.Text,
                ttbSenha.Text, ttbNome.Text, ttbEmail.Text);

            //Gravar objeto no banco
            if (objUsuario.Gravar())
                MessageBox.Show("Registro inserido com sucesso!");
            else
                MessageBox.Show("Erro ao gravar usuário. Tente novamente!");
            this.Close();

        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            string email = ttbEmail.Text;
                bool validacao1 = email.Contains("@") && email.Contains(".com");
            if (validacao1 == false)
                listaErros.Add("\nE-Mail Invalido!");
            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\nPreencha o campo Nome!");
            if (string.IsNullOrEmpty(ttbEmail.Text))
                listaErros.Add("\nPreencha o campo E-Mail!");
            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\nPreencha o campo Senha!");
            if(string.IsNullOrEmpty(ttbUsername.Text))
                listaErros.Add("\nPreencha o campo Username!");

            if(listaErros.Count > 0)
            {
                string erros = "";
                foreach (var item in listaErros)
                    erros = erros + item;
                MessageBox.Show(erros, "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                //Montar objeto
                Usuario objUsuario = new Usuario(ttbUsername.Text,
                ttbSenha.Text, ttbNome.Text, ttbEmail.Text);
                //Alterar no banco
                bool ok = objUsuario.Alterar();

                if (ok)
                {
                    MessageBox.Show("Usuario alterado com sucesso!");
                    //LimpaTela();
                }
                else
                    MessageBox.Show("Erro ao alterar registro no banco de dados! Tente novamente!");
                this.Close();
            }
        }
    }
}
