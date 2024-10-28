using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace versao01
{
    public partial class Pedidos : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        
        public Pedidos()
        {
            InitializeComponent();

            CarregarImpressoras();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Box_forma_de_pagamento.ItemCheck += checkedListBox1_ItemCheck;
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
            // botão que faz acontecer
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
            string carnes = " ";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                // Retorna o primeiro item marcado (como estamos permitindo apenas um, este será o único)
                carnes += item.ToString() + " ";
            }
            return carnes;
            
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
            string texto = "";

            // Verifica se há algum item marcado
            foreach (var item in Box_tamanho_marmitas.CheckedItems)
            {
                // Retorna o primeiro item marcado (como estamos permitindo apenas um, este será o único)
                texto += item.ToString() + " ";
            }

            // Retorna uma string vazia caso nenhum item esteja selecionado
            return texto;
        }

        private string TextoImpressao()
        {
            return "--------------------------------------\n" + 
                "Restaurante Nova Alianca\n" +
                "--------------------------------------\n" +
                QuantidadeMarmitas() + " " +
                TamanhoMarmita() +
                "\nCarnes: " + CarnesSelecionadas() + "\n" +
                "Observacoes: " + TextoObservacoes() + "\n" + "\n" + "\n" +
                "Valor total: " + TextoValorTotal() + "\n" +
                "\nForma de pagamento: " + FormaDePagamento() + "\n" + 
                "\nEndereco: " + TextoEndereco() + "\n" + "\n" +
                "\n" + "\n" +
                "--------------------------------------"
                ;
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
        private string TextoObservacoes() 
        {
            return caixa_de_texto_obs.Text;
        }

        private string TextoEndereco()
        {
            return caixa_de_texto_endereco.Text;
        }

        private string TextoValorTotal()
        {
            return caixa_de_texto_valor_total.Text;
        }

        private string QuantidadeMarmitas()
        {
            return quantidade_marmitas.Value.ToString();
        }

        private void btn_ConfigCarnes_Click(object sender, EventArgs e)
        {
            ConfigurarCarnesForm ConfigCarnesForm = new ConfigurarCarnesForm(); // Cria uma nova instância do formulário
            ConfigCarnesForm.Show(); // Exibe o formulário em uma nova janela
        }

        private void btn_AdicionarCarnes_Click(object sender, EventArgs e)
        {
            // Adiciona as carnes
            if (tb_AdicionarCarne.Text != "")
            {
                checkedListBox1.Items.Add(tb_AdicionarCarne.Text);
                tb_AdicionarCarne.Clear();
                tb_AdicionarCarne.Focus();
            }
        }

        private void btn_ApagarCarnes_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reseta as configurações das carnes para o padrão
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Boi");
            checkedListBox1.Items.Add("Frango");
            checkedListBox1.Items.Add("Porco");
            checkedListBox1.Items.Add("Ovo");
        
        }

        private void btn_editarCarnes_Click(object sender, EventArgs e)
        {
            btn_ApagarCarnes.Visible = true;
            btn_ResetarCarnes.Visible = true;
            btn_AdicionarCarnes.Visible = true;
            tb_AdicionarCarne.Visible = true;
        }

        private void btn_SalvarCarnes_Click(object sender, EventArgs e)
        {
            btn_ApagarCarnes.Visible = false;
            btn_ResetarCarnes.Visible = false;
            btn_AdicionarCarnes.Visible = false;
            tb_AdicionarCarne.Visible = false;
        }

    }
}
