/* 
 * lufer
 * Classes Abstractas
 * Interfaces
 */
using System;


namespace _05_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ERRO DE COMPILAÇÃO: Não se pode instanciar uma classe abstrata!
            //FormaGeometrica forma = new FormaGeometrica("Azul"); 

            // Instanciamos as classes concretas que herdam da abstrata
            FormaGeometrica meuCirculo = new Circulo("Vermelho", 5.0);
            //ou
            //Circulo c1 = new Circulo("Branco", 2.3);
            //Analisar o que está disponível em "c1."
            FormaGeometrica meuQuadrado = new Quadrado("Azul", 4.0);

            // Usando o método herdado e comum
            string c = meuCirculo.Cor;
            Console.WriteLine($"Área do círculo: {meuCirculo.CalcularArea():F2}\n");

            c = meuQuadrado.Cor;
            Console.WriteLine($"Área do quadrado: {meuQuadrado.CalcularArea():F4}");
            Console.ReadKey();
        }
    }
}
