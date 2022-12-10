using KittensSports.View;

namespace KittensSports
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuario().ShowDialog();
        }

        private void cadastroDeTreinamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroTreinamento().ShowDialog();
        }

        private void relatorioTreinamnetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaConsultaTreinamento().ShowDialog();
        }

        private void associarAosTreinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaUsuario().ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaGerenciarUsuario().ShowDialog();
        }
    }
}
