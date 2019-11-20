using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Conta c = new Conta()
            {
                ValorCredito = 1000.00,
                QuantidadeParcelas = 5,
                TipoCredito = "CD",
            };
            

            if (c.ValorCredito < 1000000.00 && (c.QuantidadeParcelas >= 5 && c.QuantidadeParcelas <= 72))
            {
                for (int i = 1; i <= c.QuantidadeParcelas; i++)
                {
                    if (c.TipoCredito == "CD")
                    {
                        c.ValorCredito = c.ValorCredito + (c.ValorCredito / 100 * 2);
                    }
                    if (c.TipoCredito == "CC")
                    {
                        c.ValorCredito = c.ValorCredito + (c.ValorCredito / 100 * 1);
                    }
                    if (c.TipoCredito == "PJ" && c.ValorCredito > 15000.00)
                    {
                        c.ValorCredito = c.ValorCredito + (c.ValorCredito / 100 * 5);
                    }
                    if (c.TipoCredito == "PF" )
                    {
                        c.ValorCredito = c.ValorCredito + (c.ValorCredito / 100 * 3);
                    }
                    if (c.TipoCredito == "CI" )
                    {
                        c.ValorCredito = c.ValorCredito + (c.ValorCredito / 100 * 0.75);
                    }
                    
                }
                
                Console.WriteLine("Valor Total do Juros: " + String.Format("{0:F2}", c.ValorCredito));
                    Console.ReadKey();


            }
            Console.WriteLine("Não passou pela validação!");
            Console.ReadKey();
        }
    }
}