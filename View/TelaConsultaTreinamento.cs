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
    public partial class TelaConsultaTreinamento : Form
    {
        public TelaConsultaTreinamento()
        {
            InitializeComponent();
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TreinamentoController TreiController = new TreinamentoController();
            DataTable resultadoConsulta = new DataTable();

            if (rbNome.Checked)
            {
                //Fazer busca por nome de cidade
                try
                {
                    //executando consulta no banco
                    resultadoConsulta = TreiController.BuscarPorNome(ttbBusca.Text);

                    //verificando se encontrou alguma coisa kseisu
                    if (resultadoConsulta.Rows.Count > 0)
                    {
                        dataGridView.DataSource = resultadoConsulta;
                        ttbBusca.Clear();
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

            if (rbId.Checked)
            {
                //Fazer busca por siga do estado
                try
                {
                    resultadoConsulta = TreiController.BuscarPorId(int.Parse(ttbBusca.Text));
                    if (resultadoConsulta.Rows.Count > 0)
                    {
                        dataGridView.DataSource = resultadoConsulta;
                        ttbBusca.Clear();
                        return;
                    }
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
            if (tbTodos.Checked)
            {
                //Fazer busca por siga do estado
                try
                {
                    resultadoConsulta = TreiController.BuscarTodos();
                    if (resultadoConsulta.Rows.Count > 0)
                        dataGridView.DataSource = resultadoConsulta;
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

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView.CurrentRow.Cells != null)
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                    string nome = dataGridView.CurrentRow.Cells[1].Value.ToString();

                    //Gerando uma mensagem para confirmação do usuário
                    if (MessageBox.Show("Deseja realmente excluir o treinamento " + nome + " do sistema?",
                            "Mensagem de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                        DialogResult.Yes)
                    {
                        if (new TreinamentoController().Excluir(id))
                            MessageBox.Show("Registro excluído com sucesso!");
                        else
                            MessageBox.Show("Erro ao excluir o registro!");
                    }
                    //Após exclusão, atualizar o dataGrid
                    dataGridView.DataSource = new TreinamentoController().BuscarTodos();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verificar se o usuário selecionou algum registro no dgv
            if (dataGridView.CurrentRow.Cells != null)
            {
                //Montar objeto
                Treinamento Treinamento = new Treinamento(
                    Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value),
                    dataGridView.CurrentRow.Cells[1].Value.ToString(),
                    Convert.ToSingle(dataGridView.CurrentRow.Cells[2].Value),
                    Convert.ToSingle(dataGridView.CurrentRow.Cells[3].Value),
                    Convert.ToSingle(dataGridView.CurrentRow.Cells[4].Value),
                    Convert.ToSingle(dataGridView.CurrentRow.Cells[4].Value));

                //Chamar a tela com os valores preenchidos
                new TelaCadastroTreinamento(Treinamento, true).ShowDialog();

                //Fazendo uma nova consulta no banco para atualizar o DataGrid
                dataGridView.DataSource = new TreinamentoController().BuscarTreinamento();
            }
        }
    }
}
