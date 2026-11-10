using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //teste
            Ponto p = new Ponto();
            Ponto q = new Ponto(7);
            Console.WriteLine("Pontos: {0}{1}", p.X, q.X);


            Point p1 = new Point();

            Console.WriteLine("Max: {0}", msg.Max(y: 23, x: 21));


            Contador a = new Contador(2);
            Fabrica f1 = new Fabrica();
            f1.InsereContador(a);

            Contador b = a;
            f1.InsereContador(b);
            Contador c = new Contador();
            f1.InsereContador(c);

            b.Somar(3);

            c.Somar(-1);

            Console.WriteLine(a.Valor);

            Console.WriteLine(c.Valor);

            Console.WriteLine(Contador.TotalCriados);

            #region Questao-7

            Animal an1 = new Cachorro();
            an1.Comer();

            Cachorro ca1 = new Cachorro();
            ca1.Comer();
            ca1.Latir();

            #endregion

            Console.ReadKey();

        }
    }
}
