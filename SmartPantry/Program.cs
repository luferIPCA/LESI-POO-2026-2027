#define LOG_ATIVO // Tem de ser a primeira linha do arquivo

/*
 Ver: https://dev.to/ssukhpinder/mastering-date-and-time-in-c-dcp
 */
using System;


namespace SmartPantry
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //Criar Alimento

            Alimento a1 = new Alimento();   //a1 é um ibjeto
            a1.nome = "Açucar";
            a1.validade = DateTime.Today.AddDays(36);


            Alimento a2 = new Alimento("Batatas",DateTime.Now,TipoAlimento.FRU);

#if LOG_ATIVO
            Console.WriteLine("Nome: " + a1.nome);
            DateTime today = DateTime.Now;
            Console.WriteLine("Hoje: {0:dddd}", today.ToShortDateString());
            Console.WriteLine("Validade até: {0} ", a1.validade.ToString("MM/dd/yyyy"));
            Console.ReadKey();
#endif

            //Criar uma despensa

            Pantry p1 = new Pantry(30);
            p1.InsereAlimentoDespensa(a1);
            p1.InsereAlimentoDespensa(a2);
            p1.MostraDespensa();
            Console.ReadKey();
        }
    }
}
