using KittensSports.Controller;
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
    public partial class TelaUsuario : Form
    {


        public TelaUsuario()
        {
            InitializeComponent();
            ttbTreino.Enabled = false;
            ttbUsuario.Enabled = false;
        }

        public TelaUsuario(TreinamentoUsuario obj, bool alterando)
        {
            InitializeComponent();
            ttbUsuario.Text = obj.Usuario;
            ttbTreino.Text = obj.Treinamento.ToString();
        }
            private void BtnAssociar_Click(object sender, EventArgs e)
            {
                 if (!TemEntradasValidas())
                return;

                 //Montar objeto 
                 TreinamentoUsuario Treinamento = new TreinamentoUsuario(0, ttbUsuario.Text, float.Parse(ttbTreino.Text));
                   if (DgvUsuario.CurrentRow.Cells != null)
                        if(DgvTreinamento.CurrentRow.Cells != null)

                    if (Treinamento.Gravar())
                        MessageBox.Show("Registro inserido com sucesso!");
                    else
                        MessageBox.Show("Erro ao gravar Treinamento. Tente novamente!");
                    this.Close();                
            }
        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(ttbUsuario.Text))
                listaErros.Add("\nPreencha o campo Nome!");
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TreinamentoController TreiController = new TreinamentoController();
            DataTable resultadoConsulta = new DataTable();

                try
                {
                    resultadoConsulta = TreiController.BuscarTodos();
                    if (resultadoConsulta.Rows.Count > 0)
                        DgvTreinamento.DataSource = resultadoConsulta;
                    else
                        MessageBox.Show("Não foi encontrado resultados para esta chave de busca!");
                    return;
                }
                catch
                {
                    MessageBox.Show("Erro ao comunicar com o banco de dados! Tente novamente!");
                    return;
                }
        }

        private void ttbTreino_Click(object sender, EventArgs e)
        {
            UsuarioController UsuController = new UsuarioController();
            DataTable resultadoConsulta = new DataTable();
            try
            {
                resultadoConsulta = UsuController.BuscarUsuarios();
                if (resultadoConsulta.Rows.Count > 0)
                    DgvUsuario.DataSource = resultadoConsulta;
                else
                    MessageBox.Show("Não foi encontrado resultados para esta chave de busca!");
                return;
            }
            catch
            {
                MessageBox.Show("Erro ao comunicar com o banco de dados! Tente novamente!");
                return;
            }
        }

        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DgvUsuario.Rows[e.RowIndex];
            dgUsuario(row);
        }
        public void dgUsuario(DataGridViewRow row)
        {
            ttbUsuario.Text = row.Cells["username"].Value.ToString();
        }

        private void DgvTreinamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DgvTreinamento.Rows[e.RowIndex];
            dgtreino(row);
        }
        public void dgtreino(DataGridViewRow row)
        {
            ttbTreino.Text = row.Cells["Id"].Value.ToString();
        }
    }
}
