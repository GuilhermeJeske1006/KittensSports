namespace KittensSports.View
{
    partial class TelaCadastroTreinamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVelocidade = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.TextBox();
            this.lbInclinacao = new System.Windows.Forms.TextBox();
            this.lbTempo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBpm = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de cadastro de Treinamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "velocidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Treinamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo";
            // 
            // lbVelocidade
            // 
            this.lbVelocidade.Location = new System.Drawing.Point(300, 148);
            this.lbVelocidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbVelocidade.Name = "lbVelocidade";
            this.lbVelocidade.Size = new System.Drawing.Size(140, 27);
            this.lbVelocidade.TabIndex = 4;
            this.lbVelocidade.TextChanged += new System.EventHandler(this.lbVelocidade_TextChanged);
            this.lbVelocidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbVelocidade_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.Location = new System.Drawing.Point(41, 148);
            this.lbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(240, 27);
            this.lbNome.TabIndex = 5;
            // 
            // lbInclinacao
            // 
            this.lbInclinacao.Location = new System.Drawing.Point(172, 252);
            this.lbInclinacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbInclinacao.Name = "lbInclinacao";
            this.lbInclinacao.Size = new System.Drawing.Size(131, 27);
            this.lbInclinacao.TabIndex = 6;
            this.lbInclinacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbInclinacao_KeyPress);
            // 
            // lbTempo
            // 
            this.lbTempo.Location = new System.Drawing.Point(41, 252);
            this.lbTempo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(114, 27);
            this.lbTempo.TabIndex = 7;
            this.lbTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbTempo_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(354, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(169, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inclinação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "BPM";
            // 
            // lbBpm
            // 
            this.lbBpm.Location = new System.Drawing.Point(326, 252);
            this.lbBpm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbBpm.Name = "lbBpm";
            this.lbBpm.Size = new System.Drawing.Size(114, 27);
            this.lbBpm.TabIndex = 12;
            this.lbBpm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbBpm_KeyPress);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.ForeColor = System.Drawing.Color.Green;
            this.BtnAlterar.Location = new System.Drawing.Point(41, 335);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(86, 31);
            this.BtnAlterar.TabIndex = 13;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cadastre um novo treinamento";
            // 
            // TelaCadastroTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(518, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.lbBpm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.lbInclinacao);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbVelocidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaCadastroTreinamento";
            this.Text = "TelaCadastroTreinamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox lbVelocidade;
        private TextBox lbNome;
        private TextBox lbInclinacao;
        private TextBox lbTempo;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox lbBpm;
        private TextBox lbId;
        private Button BtnAlterar;
        private Label label7;
    }
}