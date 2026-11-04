
/*
*	<copyright file="SmartPantry.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/12/2026 3:01:39 PM</date>
*	<description>
*	Classes Abstractas
*	Interfaces
*	</description>
**/


using System.Net;

namespace _05_Abstract
{
    /// <summary>
    /// Contrato para Triângulo
    /// </summary>
    internal interface ITriangulo
    {
        int Altura();
        int Perimetro();
    }


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
        public Triangulo(string cor, int baseTrian, int altura, int lado2, int lado3) : base(cor)
        {
            this.baseTrian = baseTrian;
            this.altura = altura;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double CalcularArea()
        {
            return (baseTrian * altura / 2.0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Altura()
        {
            return altura;
        }

        public int Perimetro()
        {
            return baseTrian + lado2 + lado3;
        }
    }
}

//Herança
//Class normal --> classe Abstracta --> Interface
