/*
*	<copyright file="_05_Abstract.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/10/2026 10:26:48 AM</date>
*	<description></description>
**/
using System;

namespace _05_Abstract
{
    /// <summary>
    /// Purpose: Outra Classe Concreta
    /// Created by: mustl
    /// Created on: 11/10/2026 10:26:48 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
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
