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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace versao01
{
    public partial class Pedidos : Form
    {
        private PrintDocument printDocument = new PrintDocument();       
        List<string> carrinho = new List<string>();
        List<string> carrinhoTemporario = new List<string>();



        public Pedidos()
        {
            InitializeComponent();
            Ocultar();
            CarregarImpressoras();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Box_forma_de_pagamento.ItemCheck += checkedListBox1_ItemCheck;
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Definir o texto e o formato de impressão
            Font fonte = new Font("Arial", 10);
            string texto = TextoImpressao().ToString();

            // Desenhar o texto na página
            e.Graphics.DrawString(texto, fonte, Brushes.Black, new PointF(20, 10));
        }
        private void CarregarImpressoras()
        {
            impressora_combo_box.Items.Clear();
            foreach (var impressora in PrinterSettings.InstalledPrinters)
            {
                impressora_combo_box.Items.Add(impressora);
            }
        }

        //  Botôes do formulário
        private void button1_Click(object sender, EventArgs e)
        {
            // botão que Imprime
            printDocument1.PrinterSettings.PrinterName = impressora_combo_box.SelectedItem.ToString();
            printDocument1.Print();
            DesmarcarItensBoxTamanhoMarmita();
            DesmarcarItensBoxCarnes();
            caixa_de_texto_valor_total.Clear();
            DesmarcarItensBoxFormaPagamento();
            tb_Troco.Clear();
            caixa_de_texto_obs.Clear();
            caixa_de_texto_endereco.Clear();
            carrinho.Clear();
            tb_ItensNoCarrinho.Clear();
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
        private void btn_AddCarrinho_Click(object sender, EventArgs e)
        {
            carrinhoTemporario.Add(
                TextoQuantidadeMarmitas() + " " +
                TamanhoMarmita() +
                "\n" + CarnesSelecionadas() + "\n" +
                "Observacoes: " + TextoObservacoes() + "\n" + "\n"
                );
            carrinho.AddRange(carrinhoTemporario);
            carrinhoTemporario.Clear();
            DesmarcarItensBoxTamanhoMarmita();
            DesmarcarItensBoxCarnes();
            caixa_de_texto_valor_total.Clear();
            DesmarcarItensBoxFormaPagamento();
            tb_Troco.Clear();
            caixa_de_texto_obs.Clear();
            caixa_de_texto_endereco.Clear();
            tb_ItensNoCarrinho.Clear();
            tb_ItensNoCarrinho.Text += PedidoCliente();
            tb_ItensNoCarrinho.Text += "\n";
        }
        private void btn_LimparCarrinho_Click(object sender, EventArgs e)
        {
            carrinho.Clear();
            tb_ItensNoCarrinho.Clear();
        }

        private void DesmarcarItensBoxTamanhoMarmita()
        {
            for (int i = 0; i < Box_tamanho_marmitas.Items.Count; i++)
            {
                Box_tamanho_marmitas.SetItemChecked(i, false); // Desmarca o item na posição i
            }
        }
        private void DesmarcarItensBoxCarnes()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false); // Desmarca o item na posição i
            }
        }
        private void DesmarcarItensBoxFormaPagamento()
        {
            for (int i = 0; i < Box_forma_de_pagamento.Items.Count; i++)
            {
                Box_forma_de_pagamento.SetItemChecked(i, false); // Desmarca o item na posição i
            }
        }

        private string CarnesSelecionadas() 
        {
            string carnes = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                // Retorna os itens marcados
                carnes += item.ToString() + " \n";
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
            return TextoCabecalho() +
                PedidoCliente() +
                TextoRodaPe();
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
        

        private string TextoQuantidadeMarmitas()
        {
            return quantidade_marmitas.Value.ToString();
        }

        private string TextoTroco()
        {
            return tb_Troco.Text;
        }        
        private string TextoCabecalho()
        {
            return "--------------------------------------\n" +
                "  Restaurante Nova Alianca\n" +
                "--------------------------------------\n";
        }
        private string TextoRodaPe()
        {
            return "--------------------------------------\n" + "\n" +
                "Valor total: " + TextoValorTotal() + "\n" +
                "\nForma de pagamento: " + FormaDePagamento() + "\n" +
                "Troco: " + TextoTroco() + "\n" +
                "\nEndereco: " + TextoEndereco() + "\n" + "\n" +
                "\n" + "\n" +
                "--------------------------------------\n" +
                "  Fim do pedido\n" +
                "--------------------------------------\n";
        }
        private string PedidoCliente()
        {
            string texto = "";
            foreach (var item in carrinho)
            {
                texto += item.ToString();
            }
            texto += "\n" + "\n" + "\n";
            return texto;
        }

        private void Ocultar()
        {
            tb_ItensNoCarrinho.ReadOnly = true;
        }

    }
}
