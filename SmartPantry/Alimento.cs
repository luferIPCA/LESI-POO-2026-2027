/*
*	<copyright file="SmartPantry.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/12/2026 2:52:53 PM</date>
*	<description></description>
**/
using System;

public enum TipoAlimento { VEG, FRU}   //0,1,2...

namespace SmartPantry
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/12/2026 2:52:53 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Alimento
    {
        #region Attributes

        public string nome;         //ATENÇÃO: EFINIR PROPERTIES
        TipoAlimento tipoAlimento;
        public DateTime validade;   //ATENÇÃO: EFINIR PROPERTIES
        DateTime diaProd;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Alimento()
        {
            nome = "";
            tipoAlimento = TipoAlimento.VEG;
            diaProd = DateTime.Today;
        }
        /// <summary>
        /// Define um novo produto
        /// </summary>
        /// <param name="n">Nome</param>
        /// <param name="df">Data de Fabrico</param>
        /// <param name="t">Tipo de Alimento</param>
           public Alimento(string n, DateTime df, TipoAlimento t)
        {
            nome = n;
            diaProd = df;
            tipoAlimento = t;
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        public override string ToString()
        {
            return string.Format("Alimento: {0} - Validade até: {1}", nome, validade);
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Alimento()
        {
        }
        #endregion

        #endregion
    }
}
