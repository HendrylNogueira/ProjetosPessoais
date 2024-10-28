using System.Windows.Forms;

namespace versao01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.impressora_combo_box = new System.Windows.Forms.ComboBox();
            this.label_selecione_impressora = new System.Windows.Forms.Label();
            this.carne1 = new System.Windows.Forms.CheckBox();
            this.carne2 = new System.Windows.Forms.CheckBox();
            this.carne3 = new System.Windows.Forms.CheckBox();
            this.carne4 = new System.Windows.Forms.CheckBox();
            this.label_selecione_carnes = new System.Windows.Forms.Label();
            this.label_forma_pagamento = new System.Windows.Forms.Label();
            this.caixa_de_texto_obs = new System.Windows.Forms.TextBox();
            this.label_obs = new System.Windows.Forms.Label();
            this.label_endereco = new System.Windows.Forms.Label();
            this.caixa_de_texto_endereco = new System.Windows.Forms.TextBox();
            this.Box_forma_de_pagamento = new System.Windows.Forms.CheckedListBox();
            this.Box_tamanho_marmitas = new System.Windows.Forms.CheckedListBox();
            this.label_tamanho_marmitas = new System.Windows.Forms.Label();
            this.quantidade_marmitas = new System.Windows.Forms.NumericUpDown();
            this.caixa_de_texto_valor_total = new System.Windows.Forms.TextBox();
            this.label_valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_marmitas)).BeginInit();
            this.SuspendLayout();
            // 
            // botao_imprimir
            // 
            this.botao_imprimir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botao_imprimir.Location = new System.Drawing.Point(22, 603);
            this.botao_imprimir.Name = "botao_imprimir";
            this.botao_imprimir.Size = new System.Drawing.Size(202, 59);
            this.botao_imprimir.TabIndex = 0;
            this.botao_imprimir.Text = "Imprimir";
            this.botao_imprimir.UseVisualStyleBackColor = false;
            this.botao_imprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // impressora_combo_box
            // 
            this.impressora_combo_box.FormattingEnabled = true;
            this.impressora_combo_box.Location = new System.Drawing.Point(22, 573);
            this.impressora_combo_box.Name = "impressora_combo_box";
            this.impressora_combo_box.Size = new System.Drawing.Size(202, 24);
            this.impressora_combo_box.TabIndex = 1;
            // 
            // label_selecione_impressora
            // 
            this.label_selecione_impressora.AutoSize = true;
            this.label_selecione_impressora.Location = new System.Drawing.Point(19, 554);
            this.label_selecione_impressora.Name = "label_selecione_impressora";
            this.label_selecione_impressora.Size = new System.Drawing.Size(150, 16);
            this.label_selecione_impressora.TabIndex = 2;
            this.label_selecione_impressora.Text = "Selecione a impressora";
            // 
            // carne1
            // 
            this.carne1.AutoSize = true;
            this.carne1.Location = new System.Drawing.Point(22, 149);
            this.carne1.Name = "carne1";
            this.carne1.Size = new System.Drawing.Size(111, 20);
            this.carne1.TabIndex = 3;
            this.carne1.Text = "Filé de frango";
            this.carne1.UseVisualStyleBackColor = true;
            // 
            // carne2
            // 
            this.carne2.AutoSize = true;
            this.carne2.Location = new System.Drawing.Point(22, 175);
            this.carne2.Name = "carne2";
            this.carne2.Size = new System.Drawing.Size(52, 20);
            this.carne2.TabIndex = 4;
            this.carne2.Text = "Bife";
            this.carne2.UseVisualStyleBackColor = true;
            // 
            // carne3
            // 
            this.carne3.AutoSize = true;
            this.carne3.Location = new System.Drawing.Point(22, 201);
            this.carne3.Name = "carne3";
            this.carne3.Size = new System.Drawing.Size(74, 20);
            this.carne3.TabIndex = 5;
            this.carne3.Text = "Bisteca";
            this.carne3.UseVisualStyleBackColor = true;
            // 
            // carne4
            // 
            this.carne4.AutoSize = true;
            this.carne4.Location = new System.Drawing.Point(22, 227);
            this.carne4.Name = "carne4";
            this.carne4.Size = new System.Drawing.Size(54, 20);
            this.carne4.TabIndex = 6;
            this.carne4.Text = "Ovo";
            this.carne4.UseVisualStyleBackColor = true;
            // 
            // label_selecione_carnes
            // 
            this.label_selecione_carnes.AutoSize = true;
            this.label_selecione_carnes.Location = new System.Drawing.Point(19, 130);
            this.label_selecione_carnes.Name = "label_selecione_carnes";
            this.label_selecione_carnes.Size = new System.Drawing.Size(130, 16);
            this.label_selecione_carnes.TabIndex = 7;
            this.label_selecione_carnes.Text = "Selecione as carnes";
            // 
            // label_forma_pagamento
            // 
            this.label_forma_pagamento.AutoSize = true;
            this.label_forma_pagamento.Location = new System.Drawing.Point(19, 305);
            this.label_forma_pagamento.Name = "label_forma_pagamento";
            this.label_forma_pagamento.Size = new System.Drawing.Size(207, 16);
            this.label_forma_pagamento.TabIndex = 8;
            this.label_forma_pagamento.Text = "Selecione a forma de pagamento";
            // 
            // caixa_de_texto_obs
            // 
            this.caixa_de_texto_obs.Location = new System.Drawing.Point(22, 423);
            this.caixa_de_texto_obs.Multiline = true;
            this.caixa_de_texto_obs.Name = "caixa_de_texto_obs";
            this.caixa_de_texto_obs.Size = new System.Drawing.Size(238, 65);
            this.caixa_de_texto_obs.TabIndex = 12;
            // 
            // label_obs
            // 
            this.label_obs.AutoSize = true;
            this.label_obs.Location = new System.Drawing.Point(19, 404);
            this.label_obs.Name = "label_obs";
            this.label_obs.Size = new System.Drawing.Size(89, 16);
            this.label_obs.TabIndex = 13;
            this.label_obs.Text = "Observacoes";
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Location = new System.Drawing.Point(19, 500);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(66, 16);
            this.label_endereco.TabIndex = 14;
            this.label_endereco.Text = "Endereco";
            // 
            // caixa_de_texto_endereco
            // 
            this.caixa_de_texto_endereco.Location = new System.Drawing.Point(22, 519);
            this.caixa_de_texto_endereco.Name = "caixa_de_texto_endereco";
            this.caixa_de_texto_endereco.Size = new System.Drawing.Size(238, 22);
            this.caixa_de_texto_endereco.TabIndex = 15;
            // 
            // Box_forma_de_pagamento
            // 
            this.Box_forma_de_pagamento.BackColor = System.Drawing.SystemColors.Window;
            this.Box_forma_de_pagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_forma_de_pagamento.CheckOnClick = true;
            this.Box_forma_de_pagamento.FormattingEnabled = true;
            this.Box_forma_de_pagamento.Items.AddRange(new object[] {
            "Pix",
            "Dinheiro",
            "Cartao"});
            this.Box_forma_de_pagamento.Location = new System.Drawing.Point(22, 324);
            this.Box_forma_de_pagamento.Name = "Box_forma_de_pagamento";
            this.Box_forma_de_pagamento.Size = new System.Drawing.Size(238, 68);
            this.Box_forma_de_pagamento.TabIndex = 16;
            // 
            // Box_tamanho_marmitas
            // 
            this.Box_tamanho_marmitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_tamanho_marmitas.CheckOnClick = true;
            this.Box_tamanho_marmitas.FormattingEnabled = true;
            this.Box_tamanho_marmitas.Items.AddRange(new object[] {
            "Pequena",
            "Media",
            "Grande"});
            this.Box_tamanho_marmitas.Location = new System.Drawing.Point(22, 59);
            this.Box_tamanho_marmitas.Name = "Box_tamanho_marmitas";
            this.Box_tamanho_marmitas.Size = new System.Drawing.Size(238, 68);
            this.Box_tamanho_marmitas.TabIndex = 16;
            // 
            // label_tamanho_marmitas
            // 
            this.label_tamanho_marmitas.AutoSize = true;
            this.label_tamanho_marmitas.Location = new System.Drawing.Point(19, 9);
            this.label_tamanho_marmitas.Name = "label_tamanho_marmitas";
            this.label_tamanho_marmitas.Size = new System.Drawing.Size(216, 16);
            this.label_tamanho_marmitas.TabIndex = 18;
            this.label_tamanho_marmitas.Text = "Selecione o tamanho e quantidade";
            // 
            // quantidade_marmitas
            // 
            this.quantidade_marmitas.Location = new System.Drawing.Point(23, 31);
            this.quantidade_marmitas.Name = "quantidade_marmitas";
            this.quantidade_marmitas.Size = new System.Drawing.Size(62, 22);
            this.quantidade_marmitas.TabIndex = 19;
            this.quantidade_marmitas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // caixa_de_texto_valor_total
            // 
            this.caixa_de_texto_valor_total.Location = new System.Drawing.Point(22, 280);
            this.caixa_de_texto_valor_total.Name = "caixa_de_texto_valor_total";
            this.caixa_de_texto_valor_total.Size = new System.Drawing.Size(147, 22);
            this.caixa_de_texto_valor_total.TabIndex = 20;
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.Location = new System.Drawing.Point(19, 261);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(67, 16);
            this.label_valor.TabIndex = 21;
            this.label_valor.Text = "Valor total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 730);
            this.Controls.Add(this.label_valor);
            this.Controls.Add(this.caixa_de_texto_valor_total);
            this.Controls.Add(this.quantidade_marmitas);
            this.Controls.Add(this.label_tamanho_marmitas);
            this.Controls.Add(this.Box_tamanho_marmitas);
            this.Controls.Add(this.Box_forma_de_pagamento);
            this.Controls.Add(this.caixa_de_texto_endereco);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.label_obs);
            this.Controls.Add(this.caixa_de_texto_obs);
            this.Controls.Add(this.label_forma_pagamento);
            this.Controls.Add(this.label_selecione_carnes);
            this.Controls.Add(this.carne4);
            this.Controls.Add(this.carne3);
            this.Controls.Add(this.carne2);
            this.Controls.Add(this.carne1);
            this.Controls.Add(this.label_selecione_impressora);
            this.Controls.Add(this.impressora_combo_box);
            this.Controls.Add(this.botao_imprimir);
            this.Name = "Form1";
            this.Text = "Restaurante Nova Alianca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_marmitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Button botao_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ComboBox impressora_combo_box;
        private Label label_selecione_impressora;
        private CheckBox carne1;
        private CheckBox carne2;
        private CheckBox carne3;
        private CheckBox carne4;
        private Label label_selecione_carnes;
        private Label label_forma_pagamento;
        private TextBox caixa_de_texto_obs;
        private Label label_obs;
        private Label label_endereco;
        private TextBox caixa_de_texto_endereco;
        private CheckedListBox Box_forma_de_pagamento;
        private CheckedListBox Box_tamanho_marmitas;
        private Label label_tamanho_marmitas;
        private NumericUpDown quantidade_marmitas;
        private TextBox caixa_de_texto_valor_total;
        private Label label_valor;
    }
}

