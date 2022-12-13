namespace KittensSports.View
{
    partial class TreinamentoAssociados
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.ttbBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbTreino = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Treinos associados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veja quais são os treinos que voce esta associado";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(376, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dessassociar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBusca
            // 
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Location = new System.Drawing.Point(14, 306);
            this.dgvBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.RowHeadersWidth = 51;
            this.dgvBusca.RowTemplate.Height = 25;
            this.dgvBusca.Size = new System.Drawing.Size(476, 281);
            this.dgvBusca.TabIndex = 5;
            this.dgvBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusca_CellContentClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.Blue;
            this.btnConsulta.Location = new System.Drawing.Point(370, 228);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(120, 35);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // ttbBusca
            // 
            this.ttbBusca.Location = new System.Drawing.Point(30, 236);
            this.ttbBusca.Name = "ttbBusca";
            this.ttbBusca.Size = new System.Drawing.Size(168, 27);
            this.ttbBusca.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Consultar Nome - Treino";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(215, 198);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(145, 24);
            this.rdbNome.TabIndex = 12;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Buscar por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbTreino
            // 
            this.rdbTreino.AutoSize = true;
            this.rdbTreino.Location = new System.Drawing.Point(215, 233);
            this.rdbTreino.Name = "rdbTreino";
            this.rdbTreino.Size = new System.Drawing.Size(145, 24);
            this.rdbTreino.TabIndex = 13;
            this.rdbTreino.TabStop = true;
            this.rdbTreino.Text = "Buscar por Treino";
            this.rdbTreino.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(215, 165);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(117, 24);
            this.rdbTodos.TabIndex = 14;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Buscar Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // TreinamentoAssociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 600);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbTreino);
            this.Controls.Add(this.rdbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbBusca);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dgvBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreinamentoAssociados";
            this.Text = "TreinamentoAssociados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView dgvBusca;
        private Button btnConsulta;
        private TextBox ttbBusca;
        private Label label3;
        private RadioButton rdbNome;
        private RadioButton rdbTreino;
        private RadioButton rdbTodos;
    }
}