/*
*	<copyright file="_1_Aula.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/26/2026 2:12:46 PM</date>
*	<description></description>
**/
using System;

namespace _1_Aula
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/26/2026 2:12:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Notificacao
    {
        string to;

        public string To {
            get { return to; } 
        }

        public Notificacao(string to)
        {
            this.to = to;
        }

        // Método virtual que pode ser sobrescrito
        public  virtual string Render(string message)
        {
            return $"[Genérico] para {To}: {message}";
        }

       
    }

    // Classe derivada
    public class Email : Notificacao
    {
        public Email(string to) : base(to) { }

        public override string Render(string message)
        {
            string aux = base.Render(message);
            return aux.ToLower();
        }
    }

}
