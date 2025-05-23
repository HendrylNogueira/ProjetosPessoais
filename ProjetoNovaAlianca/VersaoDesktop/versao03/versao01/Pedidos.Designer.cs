﻿using System.Windows.Forms;

namespace versao01
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.botao_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.impressora_combo_box = new System.Windows.Forms.ComboBox();
            this.label_selecione_impressora = new System.Windows.Forms.Label();
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tb_AdicionarCarne = new System.Windows.Forms.TextBox();
            this.btn_AdicionarCarnes = new System.Windows.Forms.Button();
            this.btn_ApagarCarnes = new System.Windows.Forms.Button();
            this.btn_ResetarCarnes = new System.Windows.Forms.Button();
            this.btn_editarCarnes = new System.Windows.Forms.Button();
            this.btn_SalvarCarnes = new System.Windows.Forms.Button();
            this.tb_Troco = new System.Windows.Forms.TextBox();
            this.label_troco = new System.Windows.Forms.Label();
            this.btn_AddCarrinho = new System.Windows.Forms.Button();
            this.btn_LimparCarrinho = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_marmitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botao_imprimir
            // 
            this.botao_imprimir.BackColor = System.Drawing.Color.Green;
            this.botao_imprimir.Location = new System.Drawing.Point(1093, 600);
            this.botao_imprimir.Name = "botao_imprimir";
            this.botao_imprimir.Size = new System.Drawing.Size(239, 37);
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
            this.impressora_combo_box.Location = new System.Drawing.Point(1094, 570);
            this.impressora_combo_box.Name = "impressora_combo_box";
            this.impressora_combo_box.Size = new System.Drawing.Size(238, 24);
            this.impressora_combo_box.TabIndex = 1;
            // 
            // label_selecione_impressora
            // 
            this.label_selecione_impressora.AutoSize = true;
            this.label_selecione_impressora.Location = new System.Drawing.Point(1140, 539);
            this.label_selecione_impressora.Name = "label_selecione_impressora";
            this.label_selecione_impressora.Size = new System.Drawing.Size(150, 16);
            this.label_selecione_impressora.TabIndex = 2;
            this.label_selecione_impressora.Text = "Selecione a impressora";
            // 
            // label_selecione_carnes
            // 
            this.label_selecione_carnes.AutoSize = true;
            this.label_selecione_carnes.Location = new System.Drawing.Point(336, 15);
            this.label_selecione_carnes.Name = "label_selecione_carnes";
            this.label_selecione_carnes.Size = new System.Drawing.Size(130, 16);
            this.label_selecione_carnes.TabIndex = 7;
            this.label_selecione_carnes.Text = "Selecione as carnes";
            // 
            // label_forma_pagamento
            // 
            this.label_forma_pagamento.AutoSize = true;
            this.label_forma_pagamento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_forma_pagamento.Location = new System.Drawing.Point(729, 418);
            this.label_forma_pagamento.Name = "label_forma_pagamento";
            this.label_forma_pagamento.Size = new System.Drawing.Size(207, 16);
            this.label_forma_pagamento.TabIndex = 8;
            this.label_forma_pagamento.Text = "Selecione a forma de pagamento";
            // 
            // caixa_de_texto_obs
            // 
            this.caixa_de_texto_obs.Location = new System.Drawing.Point(15, 184);
            this.caixa_de_texto_obs.Multiline = true;
            this.caixa_de_texto_obs.Name = "caixa_de_texto_obs";
            this.caixa_de_texto_obs.Size = new System.Drawing.Size(454, 86);
            this.caixa_de_texto_obs.TabIndex = 12;
            // 
            // label_obs
            // 
            this.label_obs.AutoSize = true;
            this.label_obs.Location = new System.Drawing.Point(20, 162);
            this.label_obs.Name = "label_obs";
            this.label_obs.Size = new System.Drawing.Size(89, 16);
            this.label_obs.TabIndex = 13;
            this.label_obs.Text = "Observacoes";
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_endereco.Location = new System.Drawing.Point(732, 595);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(66, 16);
            this.label_endereco.TabIndex = 14;
            this.label_endereco.Text = "Endereco";
            // 
            // caixa_de_texto_endereco
            // 
            this.caixa_de_texto_endereco.Location = new System.Drawing.Point(733, 614);
            this.caixa_de_texto_endereco.Name = "caixa_de_texto_endereco";
            this.caixa_de_texto_endereco.Size = new System.Drawing.Size(238, 22);
            this.caixa_de_texto_endereco.TabIndex = 15;
            // 
            // Box_forma_de_pagamento
            // 
            this.Box_forma_de_pagamento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Box_forma_de_pagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_forma_de_pagamento.CheckOnClick = true;
            this.Box_forma_de_pagamento.FormattingEnabled = true;
            this.Box_forma_de_pagamento.Items.AddRange(new object[] {
            "Pix",
            "Cartao",
            "Dinheiro"});
            this.Box_forma_de_pagamento.Location = new System.Drawing.Point(733, 447);
            this.Box_forma_de_pagamento.Name = "Box_forma_de_pagamento";
            this.Box_forma_de_pagamento.Size = new System.Drawing.Size(238, 68);
            this.Box_forma_de_pagamento.TabIndex = 16;
            // 
            // Box_tamanho_marmitas
            // 
            this.Box_tamanho_marmitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Box_tamanho_marmitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_tamanho_marmitas.CheckOnClick = true;
            this.Box_tamanho_marmitas.FormattingEnabled = true;
            this.Box_tamanho_marmitas.Items.AddRange(new object[] {
            "Pequena",
            "Media",
            "Grande"});
            this.Box_tamanho_marmitas.Location = new System.Drawing.Point(15, 59);
            this.Box_tamanho_marmitas.Name = "Box_tamanho_marmitas";
            this.Box_tamanho_marmitas.Size = new System.Drawing.Size(239, 68);
            this.Box_tamanho_marmitas.TabIndex = 16;
            // 
            // label_tamanho_marmitas
            // 
            this.label_tamanho_marmitas.AutoSize = true;
            this.label_tamanho_marmitas.Location = new System.Drawing.Point(12, 9);
            this.label_tamanho_marmitas.Name = "label_tamanho_marmitas";
            this.label_tamanho_marmitas.Size = new System.Drawing.Size(216, 16);
            this.label_tamanho_marmitas.TabIndex = 18;
            this.label_tamanho_marmitas.Text = "Selecione o tamanho e quantidade";
            // 
            // quantidade_marmitas
            // 
            this.quantidade_marmitas.Location = new System.Drawing.Point(15, 31);
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
            this.caixa_de_texto_valor_total.Location = new System.Drawing.Point(733, 555);
            this.caixa_de_texto_valor_total.Name = "caixa_de_texto_valor_total";
            this.caixa_de_texto_valor_total.Size = new System.Drawing.Size(147, 22);
            this.caixa_de_texto_valor_total.TabIndex = 20;
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_valor.Location = new System.Drawing.Point(730, 536);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(67, 16);
            this.label_valor.TabIndex = 21;
            this.label_valor.Text = "Valor total";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Boi",
            "Frango",
            "Porco",
            "Ovo"});
            this.checkedListBox1.Location = new System.Drawing.Point(339, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(237, 102);
            this.checkedListBox1.TabIndex = 22;
            // 
            // tb_AdicionarCarne
            // 
            this.tb_AdicionarCarne.Location = new System.Drawing.Point(618, 66);
            this.tb_AdicionarCarne.Name = "tb_AdicionarCarne";
            this.tb_AdicionarCarne.Size = new System.Drawing.Size(160, 22);
            this.tb_AdicionarCarne.TabIndex = 24;
            this.tb_AdicionarCarne.Visible = false;
            // 
            // btn_AdicionarCarnes
            // 
            this.btn_AdicionarCarnes.Location = new System.Drawing.Point(784, 62);
            this.btn_AdicionarCarnes.Name = "btn_AdicionarCarnes";
            this.btn_AdicionarCarnes.Size = new System.Drawing.Size(86, 30);
            this.btn_AdicionarCarnes.TabIndex = 25;
            this.btn_AdicionarCarnes.Text = "Adicionar";
            this.btn_AdicionarCarnes.UseVisualStyleBackColor = true;
            this.btn_AdicionarCarnes.Visible = false;
            this.btn_AdicionarCarnes.Click += new System.EventHandler(this.btn_AdicionarCarnes_Click);
            // 
            // btn_ApagarCarnes
            // 
            this.btn_ApagarCarnes.Location = new System.Drawing.Point(618, 13);
            this.btn_ApagarCarnes.Name = "btn_ApagarCarnes";
            this.btn_ApagarCarnes.Size = new System.Drawing.Size(123, 30);
            this.btn_ApagarCarnes.TabIndex = 26;
            this.btn_ApagarCarnes.Text = "Apagar Carnes";
            this.btn_ApagarCarnes.UseVisualStyleBackColor = true;
            this.btn_ApagarCarnes.Visible = false;
            this.btn_ApagarCarnes.Click += new System.EventHandler(this.btn_ApagarCarnes_Click);
            // 
            // btn_ResetarCarnes
            // 
            this.btn_ResetarCarnes.Location = new System.Drawing.Point(747, 13);
            this.btn_ResetarCarnes.Name = "btn_ResetarCarnes";
            this.btn_ResetarCarnes.Size = new System.Drawing.Size(123, 30);
            this.btn_ResetarCarnes.TabIndex = 27;
            this.btn_ResetarCarnes.Text = "Resetar Carnes";
            this.btn_ResetarCarnes.UseVisualStyleBackColor = true;
            this.btn_ResetarCarnes.Visible = false;
            this.btn_ResetarCarnes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_editarCarnes
            // 
            this.btn_editarCarnes.Location = new System.Drawing.Point(618, 108);
            this.btn_editarCarnes.Name = "btn_editarCarnes";
            this.btn_editarCarnes.Size = new System.Drawing.Size(123, 30);
            this.btn_editarCarnes.TabIndex = 28;
            this.btn_editarCarnes.Text = "Editar Carnes";
            this.btn_editarCarnes.UseVisualStyleBackColor = true;
            this.btn_editarCarnes.Click += new System.EventHandler(this.btn_editarCarnes_Click);
            // 
            // btn_SalvarCarnes
            // 
            this.btn_SalvarCarnes.Location = new System.Drawing.Point(747, 108);
            this.btn_SalvarCarnes.Name = "btn_SalvarCarnes";
            this.btn_SalvarCarnes.Size = new System.Drawing.Size(123, 30);
            this.btn_SalvarCarnes.TabIndex = 29;
            this.btn_SalvarCarnes.Text = "Salvar";
            this.btn_SalvarCarnes.UseVisualStyleBackColor = true;
            this.btn_SalvarCarnes.Click += new System.EventHandler(this.btn_SalvarCarnes_Click);
            // 
            // tb_Troco
            // 
            this.tb_Troco.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Troco.Location = new System.Drawing.Point(906, 479);
            this.tb_Troco.Name = "tb_Troco";
            this.tb_Troco.Size = new System.Drawing.Size(100, 22);
            this.tb_Troco.TabIndex = 30;
            // 
            // label_troco
            // 
            this.label_troco.AutoSize = true;
            this.label_troco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_troco.Location = new System.Drawing.Point(854, 485);
            this.label_troco.Name = "label_troco";
            this.label_troco.Size = new System.Drawing.Size(46, 16);
            this.label_troco.TabIndex = 31;
            this.label_troco.Text = "Troco:";
            // 
            // btn_AddCarrinho
            // 
            this.btn_AddCarrinho.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AddCarrinho.Location = new System.Drawing.Point(500, 184);
            this.btn_AddCarrinho.Name = "btn_AddCarrinho";
            this.btn_AddCarrinho.Size = new System.Drawing.Size(127, 34);
            this.btn_AddCarrinho.TabIndex = 32;
            this.btn_AddCarrinho.Text = "Adicionar";
            this.btn_AddCarrinho.UseVisualStyleBackColor = false;
            this.btn_AddCarrinho.Click += new System.EventHandler(this.btn_AddCarrinho_Click);
            // 
            // btn_LimparCarrinho
            // 
            this.btn_LimparCarrinho.BackColor = System.Drawing.Color.IndianRed;
            this.btn_LimparCarrinho.Location = new System.Drawing.Point(500, 236);
            this.btn_LimparCarrinho.Name = "btn_LimparCarrinho";
            this.btn_LimparCarrinho.Size = new System.Drawing.Size(127, 34);
            this.btn_LimparCarrinho.TabIndex = 36;
            this.btn_LimparCarrinho.Text = "Limpar";
            this.btn_LimparCarrinho.UseVisualStyleBackColor = false;
            this.btn_LimparCarrinho.Click += new System.EventHandler(this.btn_LimparCarrinho_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Feijoada P (completa)",
            "Feijoada M (completa)",
            "Feijoada G (completa)"});
            this.checkedListBox2.Location = new System.Drawing.Point(325, 302);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(205, 85);
            this.checkedListBox2.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Coca lata",
            "Guaraná Lata",
            "Coca 600",
            "Gasosa 1L",
            "Coca 2L"});
            this.checkedListBox3.Location = new System.Drawing.Point(15, 304);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(264, 310);
            this.checkedListBox3.TabIndex = 40;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Location = new System.Drawing.Point(-26, -21);
            this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(0);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(322, 1013);
            this.printPreviewControl1.TabIndex = 39;
            this.printPreviewControl1.UseAntiAlias = true;
            this.printPreviewControl1.Zoom = 0.9D;
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.printPreviewControl1);
            this.panel1.Location = new System.Drawing.Point(1073, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 492);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(726, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 249);
            this.panel2.TabIndex = 42;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 997);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btn_LimparCarrinho);
            this.Controls.Add(this.btn_AddCarrinho);
            this.Controls.Add(this.label_troco);
            this.Controls.Add(this.tb_Troco);
            this.Controls.Add(this.btn_SalvarCarnes);
            this.Controls.Add(this.btn_editarCarnes);
            this.Controls.Add(this.btn_ResetarCarnes);
            this.Controls.Add(this.btn_ApagarCarnes);
            this.Controls.Add(this.btn_AdicionarCarnes);
            this.Controls.Add(this.tb_AdicionarCarne);
            this.Controls.Add(this.checkedListBox1);
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
            this.Controls.Add(this.label_selecione_impressora);
            this.Controls.Add(this.impressora_combo_box);
            this.Controls.Add(this.botao_imprimir);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos";
            this.Text = "Restaurante Nova Alianca -- Versão 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_marmitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Button botao_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ComboBox impressora_combo_box;
        private Label label_selecione_impressora;
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
        private CheckedListBox checkedListBox1;
        private TextBox tb_AdicionarCarne;
        private Button btn_AdicionarCarnes;
        private Button btn_ApagarCarnes;
        private Button btn_ResetarCarnes;
        private Button btn_editarCarnes;
        private Button btn_SalvarCarnes;
        private TextBox tb_Troco;
        private Label label_troco;
        private Button btn_AddCarrinho;
        private Button btn_LimparCarrinho;
        private CheckedListBox checkedListBox2;
        private Button button1;
        private CheckedListBox checkedListBox3;
        private PrintPreviewControl printPreviewControl1;
        private Panel panel1;
        private Panel panel2;
    }
}

