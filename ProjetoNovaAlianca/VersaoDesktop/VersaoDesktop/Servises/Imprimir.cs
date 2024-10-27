using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Common;

public class PedidoImpressao
{
    public void ImprimirPedido(string texto)
    {
        PrintDocument printDocument = new PrintDocument();
        printDocument.PrintPage += (sender, e) =>
        {
            Font fonte = new Font("Arial", 12);
            e.Graphics.DrawString(texto, fonte, Brushes.Black, new PointF(10, 10));
        };

        // Define a impressora padrão como a impressora térmica instalada no sistema.
        printDocument.PrinterSettings.PrinterName = "Nome_da_Impressora_Termica";

        try
        {
            printDocument.Print();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao imprimir: " + ex.Message);
        }
    }
}
