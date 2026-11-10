/*
*	<copyright file="_05_Abstract.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/10/2026 10:28:27 AM</date>
*	<description></description>
**/
using System;

namespace _06_Interfaces
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/10/2026 10:28:27 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    /// <summary>
    /// Classe concreta de FormaGeometrica
    /// Respeita/Implmenta o interface/contrato ITriangulo
    /// </summary>
    public class Triangulo : FormaGeometrica, ITriangulo
    {
        //...
        int baseTrian; //lado 1
        int altura;
        int lado2, lado3;

        /// <summary>
        /// Construtor que inicializa a cor (da classe base) e os atributos do triângulo
        /// </summary>
        /// <param name="cor"></param>
        /// <param name="baseTrian"></param>
        /// <param name="altura"></param>
        public Triangulo(CORES cor, int baseTrian, int altura, int lado2, int lado3) : base(cor)
        {
            this.baseTrian = baseTrian;
            this.altura = altura;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        /// <summary>
        /// Implementa Método abstract defenido da classe FormaGeometrica
        /// </summary>
        /// <returns></returns>
        public override double CalcularArea()
        {
            return (baseTrian * altura / 2.0);
        }

        /// <summary>
        /// Implementa método que vem do interface ITriangulo
        /// </summary>
        /// <returns></returns>
        public int Altura()
        {
            return altura;
        }

        /// <summary>
        /// Implementa método que vem do interface ITriangulo
        /// </summary>
        /// <returns></returns>
        public double Perimetro()
        {
            return baseTrian + lado2 + lado3;
        }
    }
}
