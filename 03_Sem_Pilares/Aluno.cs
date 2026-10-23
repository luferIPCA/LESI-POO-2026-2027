/*
*	<copyright file="03_Sem_Pilares.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/21/2026 10:44:07 AM</date>
*	<description></description>
**/
using System;

namespace _03_Sem_Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/21/2026 10:44:07 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno 
    {
        #region Attributes
        /// <summary>
        /// //código do aluno
        /// </summary>
        static int codAluno=0;    //rever o porquê static
        string nome; 
        int idade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            Nome = "";
            Idade = 0;
        }
        //h1
        //public Aluno(string n, int i)
        //{
        //    Nome = n;
        //    Idade = i;
        //}
        //h2
        /// <summary>
        /// Construtor de objetos
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i"></param>
        public Aluno(string n, int i)
        {
            Nome = n;
            Idade = i;
            codAluno++;
        }
        
        #endregion

        #region Properties
        /// <summary>
        /// Manipular atributo CodAluno
        /// </summary>
        public int CodAluno
        {
            get { return codAluno; }
            set { codAluno = value; }
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
            return string.Format("{0} - {1}", CodAluno, base.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Aluno()
        {
        }
        #endregion

        #endregion
    }
}
