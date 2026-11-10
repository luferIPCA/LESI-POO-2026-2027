/*
*	<copyright file="_05_Abstract.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/10/2026 10:26:04 AM</date>
*	<description></description>
**/
using System;

namespace _05_Abstract
{
    /// <summary>
    /// Purpose: Classe Concreta (A Implementação Específica)
    /// Created by: mustl
    /// Created on: 11/10/2026 10:26:04 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example> 
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
}
