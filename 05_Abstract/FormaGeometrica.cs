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

}
