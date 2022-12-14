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
    public partial class TelaCadastroTreinamento : Form
    {
        public TelaCadastroTreinamento()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            lbBpm.Clear();
            lbInclinacao.Clear();
            lbNome.Clear();
            lbTempo.Clear();
            lbVelocidade.Clear();
        }
        public TelaCadastroTreinamento(Treinamento obj, bool alterando)
        {
            InitializeComponent();
            if (alterando)
            {
                button1.Visible = false;
                button2.Visible = false;
                BtnAlterar.Visible = true;
            }
            else
            {
                BtnAlterar.Enabled = true;
                button2.Visible = true;
                button1.Visible = true;
                lbId.Visible = false;
            }
            lbNome.Text = obj.NomeExercicio;
            lbBpm.Text = obj.Bpm.ToString();
            lbInclinacao.Text = obj.Inclinacao.ToString();
            lbTempo.Text = obj.Tempo.ToString();
            lbVelocidade.Text = obj.Velocidade.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!TemEntradasValidas())
                return;

            //Montar o objeto para gravação gergasdasd
            Treinamento objTreinamento = new Treinamento(0, lbNome.Text, float.Parse(lbVelocidade.Text), float.Parse(lbTempo.Text),
               float.Parse(lbInclinacao.Text), float.Parse(lbBpm.Text));

            //Gravar objeto no banco
            if (objTreinamento.Gravar())
            {
                MessageBox.Show("Registro inserido com sucesso!");
                LimparTela();
                return;
            }
            else
                MessageBox.Show("Erro ao gravar Treinamento. Tente novamente!");
            this.Close();

        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrWhiteSpace(lbNome.Text))
                listaErros.Add("\nPreencha o campo Nome!");
            if (string.IsNullOrWhiteSpace(lbTempo.Text))
                listaErros.Add("\nPreencha o campo Tempo!");
            if (string.IsNullOrWhiteSpace(lbVelocidade.Text))
                listaErros.Add("\nPreencha o campo Velocidade!");
            if (listaErros.Count > 0)
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                //Montar objeto
                Treinamento objTreinamento = new Treinamento(0, lbNome.Text, float.Parse(lbVelocidade.Text), float.Parse(lbTempo.Text),
                float.Parse(lbInclinacao.Text), float.Parse(lbBpm.Text));
                //Alterar no banco
                bool ok = objTreinamento.Alterar();

                if (ok)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                else
                    MessageBox.Show("Erro ao alterar registro no banco de dados! Tente novamente!");
                this.Close();
            }
        }

        private void lbVelocidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbVelocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbInclinacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbBpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
