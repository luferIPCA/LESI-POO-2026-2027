/*
 * Pilares de POO: Fundamentos da Herança
 * Sem Herança:
 *  - Classes mais complexas
 *  - Código repetido
 *  - Manutenção dificil
 *  
 * lufer
 * POO
 */
using System;

namespace _03_Sem_Pilares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Aluno 1";
            a1.CodAluno = 2;

            //ou
            Aluno a2 = new Aluno("Outro", 20);

            Professor p1 = new Professor();
            p1.Titulo = Tipo.DOUT;
            p1.Nome = "Paulo";
            p1.Idade = 23;

            Professor p2 = new Professor(Tipo.MES);
            p2.Nome = "Josefino";
            p2.Idade = 37;

            Console.WriteLine(p2.ToString());
            Console.ReadKey();

        }
    }
}
