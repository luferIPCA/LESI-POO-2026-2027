/*
*	<copyright file="_03_Pilares.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/21/2026 10:43:38 AM</date>
*	<description></description>
**/
using System;
using System.Reflection;

namespace _03_Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/21/2026 10:43:38 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        string nome;
        int idade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            idade = 0;
        }

        public Pessoa(int idade)
        {
            this.idade = 0; //gere conflito de nomes variáveis
        }

        public Pessoa(string n, int idade)
        {
            nome = n;
            this.idade = 0; //gere conflito de nomes variáveis
        }

        #endregion

        #region Properties

        public string Nome {
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
            return String.Format("Nome: {0} - Idade: {1}", Nome, Idade);
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
