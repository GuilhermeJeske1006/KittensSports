﻿namespace KittensSports.View
{
    partial class TelaUsuario
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
            this.DgvTreinamento = new System.Windows.Forms.DataGridView();
            this.BtnAssociar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnTreino = new System.Windows.Forms.Button();
            this.ttbUsuario = new System.Windows.Forms.TextBox();
            this.ttbTreino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTreinamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela do Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Associea-se com algum treinamento";
            // 
            // DgvTreinamento
            // 
            this.DgvTreinamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTreinamento.Location = new System.Drawing.Point(535, 215);
            this.DgvTreinamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvTreinamento.Name = "DgvTreinamento";
            this.DgvTreinamento.RowTemplate.Height = 25;
            this.DgvTreinamento.Size = new System.Drawing.Size(368, 217);
            this.DgvTreinamento.TabIndex = 3;
            this.DgvTreinamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTreinamento_CellContentClick);
            // 
            // BtnAssociar
            // 
            this.BtnAssociar.Location = new System.Drawing.Point(40, 95);
            this.BtnAssociar.Name = "BtnAssociar";
            this.BtnAssociar.Size = new System.Drawing.Size(75, 23);
            this.BtnAssociar.TabIndex = 6;
            this.BtnAssociar.Text = "Associar";
            this.BtnAssociar.UseVisualStyleBackColor = true;
            this.BtnAssociar.Click += new System.EventHandler(this.BtnAssociar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(809, 127);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Location = new System.Drawing.Point(46, 215);
            this.DgvUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.RowHeadersWidth = 51;
            this.DgvUsuario.RowTemplate.Height = 25;
            this.DgvUsuario.Size = new System.Drawing.Size(421, 289);
            this.DgvUsuario.TabIndex = 8;
            this.DgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuario_CellContentClick);
            // 
            // btnTreino
            // 
            this.btnTreino.Location = new System.Drawing.Point(323, 127);
            this.btnTreino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTreino.Name = "btnTreino";
            this.btnTreino.Size = new System.Drawing.Size(144, 31);
            this.btnTreino.TabIndex = 9;
            this.btnTreino.Text = "Buscar Usuario";
            this.btnTreino.UseVisualStyleBackColor = true;
            this.btnTreino.Click += new System.EventHandler(this.ttbTreino_Click);
            // 
            // ttbUsuario
            // 
            this.ttbUsuario.Location = new System.Drawing.Point(46, 563);
            this.ttbUsuario.Name = "ttbUsuario";
            this.ttbUsuario.Size = new System.Drawing.Size(125, 27);
            this.ttbUsuario.TabIndex = 10;
            // 
            // ttbTreino
            // 
            this.ttbTreino.Location = new System.Drawing.Point(535, 563);
            this.ttbTreino.Name = "ttbTreino";
            this.ttbTreino.Size = new System.Drawing.Size(125, 27);
            this.ttbTreino.TabIndex = 11;
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 602);
            this.Controls.Add(this.ttbTreino);
            this.Controls.Add(this.ttbUsuario);
            this.Controls.Add(this.btnTreino);
            this.Controls.Add(this.DgvUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.BtnAssociar);
            this.Controls.Add(this.DgvTreinamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaUsuario";
            this.Text = "TelaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTreinamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView DgvTreinamento;
        private Button BtnAssociar;
        private Button btnBuscar;
        private DataGridView DgvUsuario;
        private Button btnTreino;
        private TextBox ttbUsuario;
        private TextBox ttbTreino;
    }
}