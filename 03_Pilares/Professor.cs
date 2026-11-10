/*
*	<copyright file="_03_Pilares.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/21/2026 10:44:42 AM</date>
*	<description></description>
**/
using System;

namespace _03_Pilares
{

    public enum Tipo { DOUT, LIC, MES}
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/21/2026 10:44:42 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Professor : Pessoa
    {
        #region Attributes
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

        #endregion

        #region Overrides
        public override string ToString()
        {
            return string.Format("Titulo: {0} - {1}", Titulo.ToString(), base.ToString());
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
