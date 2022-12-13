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
using KittensSports.Model;

namespace KittensSports.View
{
    public partial class TelaDeTreinos : Form
    {
        public TelaDeTreinos()
        {
            InitializeComponent();
        }

        public TelaDeTreinos(Usuario obj, bool v)
        {
            InitializeComponent();
            if(v)
            {
                ttbUsuario.Enabled = false;
            }
            ttbUsuario.Text = obj.Username.ToString();
            var senha= obj.Password.ToString();
            var name= obj.NomeCompleto.ToString();
            var email= obj.Email.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            TreinamentoUsuarioController TreiusuController = new TreinamentoUsuarioController();
            DataTable resultadoConsulta = new DataTable();

            if (rdbTreinos.Checked)
            {
                try
                {
                    
                    resultadoConsulta = TreiusuController.BuscarPortreinos(ttbBuscar.Text, ttbUsuario.Text);
                    string Nome = ttbBuscar.Text;
                    string users = ttbUsuario.Text; 
                    if (resultadoConsulta.Rows.Count > 0)
                    {
                        dgvBuscar.DataSource = resultadoConsulta;
                        ttbBuscar.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado resultados para esta chave de busca!");
                        return;

                    }
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
                    resultadoConsulta = TreiusuController.BuscarTodosu(ttbUsuario.Text);
                    string users = ttbUsuario.Text;
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
