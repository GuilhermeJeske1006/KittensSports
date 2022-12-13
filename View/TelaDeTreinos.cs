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
    public partial class TelaDeTreinos : Form
    {
        public TelaDeTreinos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TreinamentoUsuarioController TreiusuController = new TreinamentoUsuarioController();
            DataTable resultadoConsulta = new DataTable();

           // if (rdbTreinos.Checked)
            //{
             //   try
              //  {
              //      resultadoConsulta = TreiusuController.BuscarPortreinos(ttbBuscar.Text, );
              //      string Nome = ttbBuscar.Text;
              //      string user = 
               //     if (resultadoConsulta.Rows.Count > 0)
                //    {
                //        dgvBuscar.DataSource = resultadoConsulta;
                //        ttbBuscar.Clear();
                 //       return;
                 //   }
                 //   else
                //        MessageBox.Show("Não foi encontrado resultados para esta chave de busca!");
                 //   return;
               // }
              //  catch
               // {
              //      MessageBox.Show("Erro ao comunicar com o banco de dados! Tente novamente!");
              //      return;
              //  }
            //}
            if (rdbTodos.Checked)
            {
                //Fazer busca por siga do estado
                try
                {
                    resultadoConsulta = TreiusuController.BuscarTodosu();
                    if (resultadoConsulta.Rows.Count > 0)
                        dgvBuscar.DataSource = resultadoConsulta;
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
}
