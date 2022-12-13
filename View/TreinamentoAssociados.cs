using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KittensSports.Controller;

namespace KittensSports.View
{
    public partial class TreinamentoAssociados : Form
    {
        public TreinamentoAssociados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBusca.CurrentRow.Cells != null)
            {
                int IdTreinam = Convert.ToInt32(dgvBusca.CurrentRow.Cells[0].Value);
                string username = dgvBusca.CurrentRow.Cells[1].Value.ToString();

                //Gerando uma mensagem para confirmação do usuário
                if (MessageBox.Show("Deseja realmente excluir o " + username + " do sistema?",
                        "Mensagem de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                    DialogResult.Yes)
                {
                    if (new TreinamentoUsuarioController().Excluir(IdTreinam))
                        MessageBox.Show("Registro excluído com sucesso!");
                    else
                        MessageBox.Show("Erro ao excluir o registro!");
                }
                //Após exclusão, atualizar o dataGrid
                dgvBusca.DataSource = new TreinamentoUsuarioController().BuscarTodos();
            }
        }

        private void dgvBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreinamentoUsuarioController TreiusuController = new TreinamentoUsuarioController();
            DataTable resultadoConsulta = new DataTable();

            if (rdbNome.Checked)
            {
                
                try
                {
                    resultadoConsulta = TreiusuController.BuscarPorNome(ttbBusca.Text);
                    string Name = ttbBusca.Text;
                    if (resultadoConsulta.Rows.Count > 0)
                    {
                        dgvBusca.DataSource = resultadoConsulta;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado resultado para a chave informada!");
                        return;
                    }
                }
                catch //Caso tenha algum erro na conexão com o banco
                {
                    MessageBox.Show("Falha ao conectar com o banco de dados. Tente novamente!");
                }
            }

            if (rdbTreino.Checked)
            {
                try
                {
                    resultadoConsulta = TreiusuController.BuscarPortreino(ttbBusca.Text);
                    string Nome = ttbBusca.Text;
                    if (resultadoConsulta.Rows.Count > 0)
                        dgvBusca.DataSource = resultadoConsulta;
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
            if (rdbTodos.Checked)
            {
                //Fazer busca por siga do estado
                try
                {
                    resultadoConsulta = TreiusuController.BuscarTodos();
                    if (resultadoConsulta.Rows.Count > 0)
                        dgvBusca.DataSource = resultadoConsulta;
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

            MessageBox.Show("Selecione uma opção de busca!");
        }
    }
}
