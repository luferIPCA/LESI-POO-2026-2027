/*
*	<copyright file="_06_Interfaces.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/10/2026 10:34:28 AM</date>
*	<description></description>
**/
using System;

namespace _06_Interfaces
{
    /// <summary>
    /// Purpose: Definições globais
    /// Created by: mustl
    /// Created on: 11/10/2026 10:34:28 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Settings
    {
        #region Attributes
        static int totalFigurasGeométricas = 0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Settings()
        {
        }

        #endregion

        #region Properties

        public static int TotalFigurasGeometricas
        {
            set { totalFigurasGeométricas = value; }
            get { return totalFigurasGeométricas; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Settings()
        {
        }
        #endregion

        #endregion
    }

    public enum CORES
    {
        PRETO,
        BRANCO,
        AZUL
    }
}
