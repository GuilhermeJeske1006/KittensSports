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
    public partial class TelaGerenciarUsuario : Form
    {
        public TelaGerenciarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            UsuarioController UsuController = new UsuarioController();
            DataTable resultadoConsulta = new DataTable();

            if (rbNome.Checked)
            {
                //Fazer busca por nome de cidade
                try
                {
                    //executando consulta no banco
                    resultadoConsulta = UsuController.BuscarPorNome(tbBuscar.Text);

                    //verificando se encontrou alguma coisa kseisu
                    if (resultadoConsulta.Rows.Count > 0)
                    {
                        DgvUsuario.DataSource = resultadoConsulta;
                        tbBuscar.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado resultado para a chave informada!");
                        DgvUsuario.DataSource = " ";
                        return;
                    }
                }
                catch //Caso tenha algum erro na conexão com o banco
                {
                    MessageBox.Show("Falha ao conectar com o banco de dados. Tente novamente!");
                    DgvUsuario.DataSource = " ";
                }
            }

          
            if (rbTodos.Checked)
            {
                //Fazer busca por siga do estado
                try
                {
                    resultadoConsulta = UsuController.BuscarUsuarios();
                    if (resultadoConsulta.Rows.Count > 0)
                        DgvUsuario.DataSource = resultadoConsulta;
                    else
                    {
                        MessageBox.Show("Não foi encontrado resultados para esta chave de busca!");
                        DgvUsuario.DataSource = " ";
                    }
                    return;
                }
                catch
                {
                    MessageBox.Show("Erro ao comunicar com o banco de dados! Tente novamente!");
                    DgvUsuario.DataSource = " ";
                    return;
                }
            }

            MessageBox.Show("Selecione uma opção de busca!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se o usuário selecionou algum registro no dgv
            if (DgvUsuario.CurrentRow.Cells != null)
            {
                //Montar objeto
                Usuario Usuario = new Usuario(
                    DgvUsuario.CurrentRow.Cells[0].Value.ToString(),
                    DgvUsuario.CurrentRow.Cells[1].Value.ToString(),
                    DgvUsuario.CurrentRow.Cells[2].Value.ToString(),
                    DgvUsuario.CurrentRow.Cells[3].Value.ToString());
                  

                //Chamar a tela com os valores preenchidos
                new TelaCadastroUsuario(Usuario, true).ShowDialog();

                //Fazendo uma nova consulta no banco para atualizar o DataGrid
                DgvUsuario.DataSource = new TreinamentoController().BuscarTreinamento();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
            {
                if (DgvUsuario.CurrentRow.Cells != null)
                {
                    string nome = DgvUsuario.CurrentRow.Cells[0].Value.ToString();

                    //Gerando uma mensagem para confirmação do usuário
                    if (MessageBox.Show("Deseja realmente excluir o Usuario " + nome + " do sistema?",
                            "Mensagem de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                        DialogResult.Yes)
                    {
                        if (new UsuarioController().Excluir(nome))
                            MessageBox.Show("Usuario excluído com sucesso!");
                        else
                            MessageBox.Show("Erro ao excluir o registro!");
                    }
                    //Após exclusão, atualizar o dataGrid
                    DgvUsuario.DataSource = new UsuarioController().BuscarUsuarios();
                }
            }
    }
}
