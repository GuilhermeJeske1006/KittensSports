namespace KittensSports
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeTreinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioTreinamnetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associarAosTreinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.treinamentoToolStripMenuItem,
            this.associarAosTreinosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.gerenciarToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // treinamentoToolStripMenuItem
            // 
            this.treinamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeTreinamentoToolStripMenuItem,
            this.relatorioTreinamnetoToolStripMenuItem});
            this.treinamentoToolStripMenuItem.Name = "treinamentoToolStripMenuItem";
            this.treinamentoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.treinamentoToolStripMenuItem.Text = "Treinamento";
            // 
            // cadastroDeTreinamentoToolStripMenuItem
            // 
            this.cadastroDeTreinamentoToolStripMenuItem.Name = "cadastroDeTreinamentoToolStripMenuItem";
            this.cadastroDeTreinamentoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cadastroDeTreinamentoToolStripMenuItem.Text = "Cadastro de treinamento";
            this.cadastroDeTreinamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeTreinamentoToolStripMenuItem_Click);
            // 
            // relatorioTreinamnetoToolStripMenuItem
            // 
            this.relatorioTreinamnetoToolStripMenuItem.Name = "relatorioTreinamnetoToolStripMenuItem";
            this.relatorioTreinamnetoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.relatorioTreinamnetoToolStripMenuItem.Text = "RelatorioTreinamneto";
            this.relatorioTreinamnetoToolStripMenuItem.Click += new System.EventHandler(this.relatorioTreinamnetoToolStripMenuItem_Click);
            // 
            // associarAosTreinosToolStripMenuItem
            // 
            this.associarAosTreinosToolStripMenuItem.Name = "associarAosTreinosToolStripMenuItem";
            this.associarAosTreinosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.associarAosTreinosToolStripMenuItem.Text = "Associar aos treinos";
            this.associarAosTreinosToolStripMenuItem.Click += new System.EventHandler(this.associarAosTreinosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(161, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kittens Sports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem treinamentoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeTreinamentoToolStripMenuItem;
        private ToolStripMenuItem relatorioTreinamnetoToolStripMenuItem;
        private ToolStripMenuItem associarAosTreinosToolStripMenuItem;
    }
}