namespace KittensSports.View
{
    partial class TelaDeTreinos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbBuscar = new System.Windows.Forms.TextBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTreinos = new System.Windows.Forms.RadioButton();
            this.ttbUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(362, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToOrderColumns = true;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(72, 236);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 29;
            this.dgvBuscar.Size = new System.Drawing.Size(384, 188);
            this.dgvBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treinos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttbBuscar
            // 
            this.ttbBuscar.Location = new System.Drawing.Point(72, 181);
            this.ttbBuscar.Name = "ttbBuscar";
            this.ttbBuscar.Size = new System.Drawing.Size(125, 27);
            this.ttbBuscar.TabIndex = 3;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(215, 149);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(113, 24);
            this.rdbTodos.TabIndex = 4;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "BuscarTodos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Treino";
            // 
            // rdbTreinos
            // 
            this.rdbTreinos.AutoSize = true;
            this.rdbTreinos.Location = new System.Drawing.Point(215, 182);
            this.rdbTreinos.Name = "rdbTreinos";
            this.rdbTreinos.Size = new System.Drawing.Size(120, 24);
            this.rdbTreinos.TabIndex = 6;
            this.rdbTreinos.TabStop = true;
            this.rdbTreinos.Text = "BuscarTreinos";
            this.rdbTreinos.UseVisualStyleBackColor = true;
            // 
            // ttbUsuario
            // 
            this.ttbUsuario.Location = new System.Drawing.Point(21, 12);
            this.ttbUsuario.Name = "ttbUsuario";
            this.ttbUsuario.Size = new System.Drawing.Size(125, 27);
            this.ttbUsuario.TabIndex = 7;
            // 
            // TelaDeTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.ttbUsuario);
            this.Controls.Add(this.rdbTreinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.ttbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "TelaDeTreinos";
            this.Text = "TelaDeTreinos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private DataGridView dgvBuscar;
        private Label label1;
        private TextBox ttbBuscar;
        private RadioButton rdbTodos;
        private Label label2;
        private RadioButton rdbTreinos;
        private TextBox ttbUsuario;
    }
}