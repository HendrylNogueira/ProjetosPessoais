namespace versao01
{
    partial class ConfigurarCarnesForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_AdicionarCarnes = new System.Windows.Forms.Button();
            this.btn_EditarCarnes = new System.Windows.Forms.Button();
            this.btn_ResetarCarnes = new System.Windows.Forms.Button();
            this.btn_LimparOpcoes = new System.Windows.Forms.Button();
            this.tb_Campo_add_carnes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Boi",
            "Frango",
            "Porco",
            "Ovo"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(153, 174);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btn_AdicionarCarnes
            // 
            this.btn_AdicionarCarnes.Location = new System.Drawing.Point(229, 198);
            this.btn_AdicionarCarnes.Name = "btn_AdicionarCarnes";
            this.btn_AdicionarCarnes.Size = new System.Drawing.Size(189, 24);
            this.btn_AdicionarCarnes.TabIndex = 1;
            this.btn_AdicionarCarnes.Text = "Adicionar carnes";
            this.btn_AdicionarCarnes.UseVisualStyleBackColor = true;
            this.btn_AdicionarCarnes.Click += new System.EventHandler(this.btn_AdicionarCarnes_Click);
            // 
            // btn_EditarCarnes
            // 
            this.btn_EditarCarnes.Location = new System.Drawing.Point(229, 12);
            this.btn_EditarCarnes.Name = "btn_EditarCarnes";
            this.btn_EditarCarnes.Size = new System.Drawing.Size(189, 23);
            this.btn_EditarCarnes.TabIndex = 2;
            this.btn_EditarCarnes.Text = "Editar carnes";
            this.btn_EditarCarnes.UseVisualStyleBackColor = true;
            // 
            // btn_ResetarCarnes
            // 
            this.btn_ResetarCarnes.Location = new System.Drawing.Point(229, 41);
            this.btn_ResetarCarnes.Name = "btn_ResetarCarnes";
            this.btn_ResetarCarnes.Size = new System.Drawing.Size(189, 23);
            this.btn_ResetarCarnes.TabIndex = 3;
            this.btn_ResetarCarnes.Text = "Resetar Carnes";
            this.btn_ResetarCarnes.UseVisualStyleBackColor = true;
            this.btn_ResetarCarnes.Click += new System.EventHandler(this.btn_ResetarCarnes_Click);
            // 
            // btn_LimparOpcoes
            // 
            this.btn_LimparOpcoes.Location = new System.Drawing.Point(229, 70);
            this.btn_LimparOpcoes.Name = "btn_LimparOpcoes";
            this.btn_LimparOpcoes.Size = new System.Drawing.Size(189, 23);
            this.btn_LimparOpcoes.TabIndex = 4;
            this.btn_LimparOpcoes.Text = "Limpar Opcoes";
            this.btn_LimparOpcoes.UseVisualStyleBackColor = true;
            this.btn_LimparOpcoes.Visible = false;
            this.btn_LimparOpcoes.Click += new System.EventHandler(this.btn_LimparOpcoes_Click);
            // 
            // tb_Campo_add_carnes
            // 
            this.tb_Campo_add_carnes.Location = new System.Drawing.Point(229, 228);
            this.tb_Campo_add_carnes.Name = "tb_Campo_add_carnes";
            this.tb_Campo_add_carnes.Size = new System.Drawing.Size(223, 22);
            this.tb_Campo_add_carnes.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfigurarCarnesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Campo_add_carnes);
            this.Controls.Add(this.btn_LimparOpcoes);
            this.Controls.Add(this.btn_ResetarCarnes);
            this.Controls.Add(this.btn_EditarCarnes);
            this.Controls.Add(this.btn_AdicionarCarnes);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "ConfigurarCarnesForm";
            this.Text = "ConfigurarCarnesForm";
            this.Load += new System.EventHandler(this.ConfigurarCarnesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_AdicionarCarnes;
        private System.Windows.Forms.Button btn_EditarCarnes;
        private System.Windows.Forms.Button btn_ResetarCarnes;
        private System.Windows.Forms.Button btn_LimparOpcoes;
        private System.Windows.Forms.TextBox tb_Campo_add_carnes;
        private System.Windows.Forms.Button button1;
    }
}