/*
*	<copyright file="_05_Abstract.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/3/2026 10:15:52 PM</date>
*	<description>
*	Classes Abstractas
*	</description>
**/
using System;

namespace _05_Abstract
{
    /// <summary>
    /// Purpose: Descreve uma Forma Geométrica
    /// Created by: mustl
    /// Created on: 11/3/2026 10:15:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class FormaGeometrica
    {
        #region Attributes
        // atributo comum a todas as formas
        private string cor;
                
        #endregion

        #region Methods

        // Propriedade comum a todas as formas
        public string Cor { get { return cor; } set { cor = value; } }

        //construtor
        public FormaGeometrica(string cor)
        {
            Cor = cor;
        }

        // Método abstrato 
        // Obriga qualquer classe filha a implementar a sua própria forma de calcular a área.
        public abstract double CalcularArea();

        // Método normal (concreto): tem implementação e pode ser herdado diretamente.
        public override string ToString()
        {
            return $"A cor desta forma é: {Cor}";
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~FormaGeometrica()
        {
        }
        #endregion

    }

   
    // 2. Classe Concreta (A Implementação Específica)
    public class Circulo : FormaGeometrica
    {
        private double raio;

        public double Raio { get; set; }

        public Circulo(string cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        /// <summary>
        /// Calcula a área
        /// Somos obrigados a implementar o método abstrato
        /// </summary>
        /// <returns></returns>
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }

    // 3. Outra Classe Concreta
    public class Quadrado : FormaGeometrica
    {
        private double lado;

        public double Lado { get; set; }

        public Quadrado(string cor, double lado) : base(cor)
        {
            Lado = lado;
        }

        // Implementação específica para o Quadrado
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }

}
