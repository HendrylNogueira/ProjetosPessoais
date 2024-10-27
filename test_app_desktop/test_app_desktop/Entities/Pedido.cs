using System.Collections.Generic;

public class Pedido
{
    public string Tamanho { get; set; } // P, M, G
    public List<string> Carnes { get; set; } // Até 2 opções
    public string Observacao { get; set; }
    public string Endereco { get; set; }
    public decimal ValorTotal { get; set; }
    public string FormaPagamento { get; set; }

    public Pedido()
    {
        Carnes = new List<string>();
    }

    public void CalcularValorTotal()
    {
        switch (Tamanho)
        {
            case "P":
                ValorTotal = 15.00m;
                break;
            case "M":
                ValorTotal = 20.00m;
                break;
            case "G":
                ValorTotal = 25.00m;
                break;
        }
    }
}
