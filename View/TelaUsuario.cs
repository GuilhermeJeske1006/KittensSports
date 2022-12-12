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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvTreinamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAssociar_Click(object sender, EventArgs e)
        {
            {
                if (DgvTreinamento.CurrentRow.Cells != null)
                {
                    //Montar objeto
                   // TreinamentoUsuario Treinamento = new TreinamentoUsuario();

                    new TreinamentoAssociados().ShowDialog();

                    //DgvTreinamento.DataSource = new TreinamentoAssociados().BuscarTreinamentoAssociados();
                }
            }
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
    }
}
