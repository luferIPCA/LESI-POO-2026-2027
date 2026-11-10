/*
*	<copyright file="Teste_1.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/3/2026 9:58:41 PM</date>
*	<description></description>
**/
using System;

namespace Teste_1
{

    #region VARIOS

    class Ponto
    {
        private int x;
        public Ponto()
        {
            x = 1;
        }
        public Ponto(int k)
        {
            x = k;
        }
        public int X
        {
            get { return x; }
        }
    }


    #region TESTE LESIN

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    #endregion

    #region TESTE_LESI

    public class Contador
    {
        private int valor;
        private static int totalCriados;

        public int Valor { get { return valor; } private set { valor = value; } }
        public static int TotalCriados { get { return totalCriados; } set { totalCriados = value; } }

        public Contador(): this(0)
        {
        }

        public Contador(int inicial)
        {
            Valor = inicial;
            TotalCriados++;
        }

        public void Somar(int quantidade)
        {
            if (quantidade > 0) Valor += quantidade;
        }
    }

    class Fabrica
    {
        Contador[] contadores;
        int totContadores;
        const int MAX = 20;

        public Fabrica()
        {
            contadores = new Contador[MAX];
        }

        public Fabrica(int n)
        {
            if (n > MAX)
                contadores = new Contador[MAX];
            else
                contadores = new Contador[MAX];
        }

        public bool InsereContador(Contador c)
        {
            if (totContadores >= MAX) return false;

            contadores[totContadores++] = c;
            return true;
        }
        public virtual bool ExisteContador(int cod)
        {
            return false;
        }
    }

    #region Questão-7

    class Animal
    {
        public void Comer()
        {
            Console.WriteLine("O animal está comendo.");
        }
    }

    class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("O cachorro está latindo.");
        }
    }

    #endregion

    #endregion

    #endregion


}
