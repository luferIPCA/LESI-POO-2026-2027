/*
*	<copyright file="Notificacao.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/10/2026 10:10:25 AM</date>
*	<description></description>
**/
using System;

namespace _06_Interfaces
{
    /// <summary>
    /// Purpose: Implementa/Respeita/Segue contrato/interface INotificacao
    /// INotificacao obriga a implementar o método "Render"
    /// Created by: mustl
    /// Created on: 11/10/2026 10:10:25 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Notificacao : INotificacao
    {
        #region Attributes
        string to;
        string from;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Notificacao()
        {
            from = "lufer@ipca.pt";
        }

        /// <summary>
        /// Prepara msg
        /// </summary>
        /// <param name="to">Destino</param>
        public Notificacao(string from)
        {
            this.from = from;
        }

        #endregion

        #region Properties

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        public string From
        {
            get { return from; }

        }
        #endregion

        #region Overrides

        #endregion

        #region OtherMethods
        /// <summary>
        /// Implementa Método do Interface INotoficacao
        /// Método virtual que pode ser reescrito
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual string Render(string message)
        {
            return $"De {from} para {To}: {message}";
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Notificacao()
        {
        }
        #endregion

        #endregion
    }




}
