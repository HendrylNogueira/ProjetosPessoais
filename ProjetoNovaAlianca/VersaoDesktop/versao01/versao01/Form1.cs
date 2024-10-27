using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace versao01
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            CarregarImpressoras();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Box_forma_de_pagamento.ItemCheck += checkedListBox1_ItemCheck;
            Box_tamanho_marmitas.ItemCheck += checkedListBox2_ItemCheck;
        }

        private void CarregarImpressoras()
        {
            impressora_combo_box.Items.Clear();
            foreach (var impressora in PrinterSettings.InstalledPrinters)
            {
                impressora_combo_box.Items.Add(impressora);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = impressora_combo_box.SelectedItem.ToString();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Definir o texto e o formato de impressão
            Font fonte = new Font("Arial", 10);
            string texto = TextoImpressao().ToString();

            // Desenhar o texto na página
            e.Graphics.DrawString(texto, fonte, Brushes.Black, new PointF(10, 10));
        }

        private string CarnesSelecionadas()
        {
            string texto = "Não deu certo";
            if (carne1.Checked == true || carne2.Checked == true)
            {
                texto = "";
                if (carne1.Checked == true)
                {
                    texto += " " + carne1.Text;
                }
                if (carne2.Checked == true)
                {
                    texto += " " + carne2.Text;
                }
                if (carne3.Checked == true)
                {
                    texto += " " + carne3.Text;
                }
                if (carne4.Checked == true)
                {
                    texto += " " + carne4.Text;
                }
            }

            return texto;
        }

        private string FormaDePagamento()
        {
            // Verifica se há algum item marcado
            foreach (var item in Box_forma_de_pagamento.CheckedItems)
            {
                // Retorna o primeiro item marcado (como estamos permitindo apenas um, este será o único)
                return item.ToString();
            }

            // Retorna uma string vazia caso nenhum item esteja selecionado
            return "Forma de pagamento nao selecionada";
        }
        private string TamanhoMarmita()
        {
            // Verifica se há algum item marcado
            foreach (var item in Box_tamanho_marmitas.CheckedItems)
            {
                // Retorna o primeiro item marcado (como estamos permitindo apenas um, este será o único)
                return item.ToString();
            }

            // Retorna uma string vazia caso nenhum item esteja selecionado
            return "Tamanho da marmita nao selecionado";
        }

        private string TextoImpressao()
        {
            return "Pedido de Marmita\n" +
                "\nTamanho: " + TamanhoMarmita() +
                "\nCarnes: " + CarnesSelecionadas() + "\n"
                + "\nForma de pagamento: " + FormaDePagamento();
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // deixa selecionar apenas 1 opção de pagamento

            // Se o item está sendo marcado
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarque todos os outros itens
                for (int i = 0; i < Box_forma_de_pagamento.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        Box_forma_de_pagamento.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // deixa selecionar apenas 1 opção de pagamento

            // Se o item está sendo marcado
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarque todos os outros itens
                for (int i = 0; i < Box_tamanho_marmitas.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        Box_tamanho_marmitas.SetItemChecked(i, false);
                    }
                }
            }
        }

    }
}
