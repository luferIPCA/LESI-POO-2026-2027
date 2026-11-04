using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificacao n1 = new Notificacao("Ola");
            Email e1 = new Email("ole");

            Console.WriteLine("E1:{0}", e1.Render("do Filho"));


            //Parametros
            Mensagem msg = new Mensagem();

            // 1. Passando apenas o obrigatório
            msg.Enviar("Viva o Benfica");

            // 2. Substituindo o primeiro parâmetro opcional
            msg.Enviar("Preciso de ajuda", "Carlos");
            

            // 3. Passando todos os argumentos
            msg.Enviar("Reunião cancelada", "Ana", true);       
           
            Console.ReadKey();
        }
    }
}
