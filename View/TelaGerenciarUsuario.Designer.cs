namespace KittensSports.View
{
    partial class TelaGerenciarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerencie o Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procure pelo nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.Green;
            this.btnAlterar.Location = new System.Drawing.Point(440, 143);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(86, 31);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Blue;
            this.btnBuscar.Location = new System.Drawing.Point(440, 181);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Location = new System.Drawing.Point(33, 243);
            this.DgvUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.RowHeadersWidth = 51;
            this.DgvUsuario.RowTemplate.Height = 25;
            this.DgvUsuario.Size = new System.Drawing.Size(485, 299);
            this.DgvUsuario.TabIndex = 5;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(56, 143);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(196, 27);
            this.tbBuscar.TabIndex = 6;
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.Location = new System.Drawing.Point(440, 104);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(86, 31);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(296, 119);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(115, 24);
            this.rbTodos.TabIndex = 8;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Buscar todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(296, 152);
            this.rbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(142, 24);
            this.rbNome.TabIndex = 9;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Buscar por nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // TelaGerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 600);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.DgvUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaGerenciarUsuario";
            this.Text = "TelaGerenciarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btnAlterar;
        private Button btnBuscar;
        private DataGridView DgvUsuario;
        private TextBox tbBuscar;
        private Button btnRemover;
        private RadioButton rbTodos;
        private RadioButton rbNome;
    }
}