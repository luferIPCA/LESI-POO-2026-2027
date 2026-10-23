/*
*	<copyright file="03_Sem_Pilares.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/21/2026 10:44:42 AM</date>
*	<description></description>
**/
using System;

namespace _03_Sem_Pilares
{

    public enum Tipo { DOUT, LIC, MES }
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/21/2026 10:44:42 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Professor
    {
        #region Attributes
        string nome;
        int idade;
        Tipo titulo; 
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Professor()
        {
            titulo = Tipo.DOUT;
        }

        public Professor(Tipo t)
        {
            titulo = t;
        }

        #endregion

        #region Properties

        public Tipo Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { if (value.Length > 0) nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return string.Format("Titulo: {0} - Nome: {1} - Idade: {2}", Titulo.ToString(), Nome, Idade);
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Professor()
        {
        }
        #endregion

        #endregion
    }
}
