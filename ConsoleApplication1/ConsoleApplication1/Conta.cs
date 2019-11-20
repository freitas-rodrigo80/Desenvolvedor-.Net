using System;

namespace ConsoleApplication1
{
    public class Conta
    {
        public double ValorCredito { get; set; }
        public string TipoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }


        public void valida(double valor, string tipo, int qtd)
        {
            if (valor < 1000000.00 && (qtd >= 5 && qtd <= 72))
            {
                for (int i = 1; i <= qtd; i++)
                {
                    if (tipo == "DC")
                    {
                        valor = valor+ (valor / 100 * 2);
                    }
                    
                }

                Console.WriteLine("Valor Total do Juros: " + String.Format("{0:F2}", valor));
                Console.ReadKey();
            }
            Console.WriteLine("Não passou pela validação!");
            Console.ReadKey();
            
        }
    }
    
}