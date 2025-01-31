using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection;

namespace AprendendoMVC.Model
{
    public class Veiculo
    {
        public string Chassi { get; set; }

        public string Tipo { get; set; }
        public int NumeroPassageiros { get; set; }
        public string Cor { get; set; }
        public override string ToString()
        {
            return $"Chassi: {Chassi}, Tipo: {Tipo}, NumeroPassageiros: {NumeroPassageiros}, Cor: {Cor}";
        }    
    }
}
