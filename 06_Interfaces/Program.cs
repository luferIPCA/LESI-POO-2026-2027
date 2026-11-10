using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificacao msg1 = new Notificacao("lufer@ipca.pt");
            msg1.To = "aaa@bbb.pt";
            string message = msg1.Render("Viva");
            Console.WriteLine(message);

            Triangulo t = new Triangulo(CORES.AZUL, 12, 13, 3, 6);
            double per = t.Perimetro();
            Console.WriteLine($"Perimetro de Triangulo: {per}");

            Console.ReadKey();
        }
    }
}
