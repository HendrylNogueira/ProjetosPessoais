using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace test_app_desktop
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            // Configurar a impressora
            printDocument.PrinterSettings.PrinterName = "NomeDaImpressora"; // Substitua pelo nome da sua impressora térmica

            // Registrar o evento de impressão
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciar a impressão
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir: " + ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Definir o texto e o formato de impressão
            Font fonte = new Font("Arial", 10);
            string texto = "Pedido de Marmita\nTamanho: G\nCarne: Frango e Carne Moída\nEndereço: Rua Exemplo, 123";

            // Desenhar o texto na página
            e.Graphics.DrawString(texto, fonte, Brushes.Black, new PointF(10, 10));
        }
    }
}
