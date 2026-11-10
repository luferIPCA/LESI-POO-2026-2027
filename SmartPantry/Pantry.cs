/*
*	<copyright file="SmartPantry.cs" company="IPCA">
*		Copyright (c) 2026 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/12/2026 3:36:15 PM</date>
*	<description></description>
**/
using System;

namespace SmartPantry
{

    /// <summary>
    /// Valores constantes
    /// </summary>
    public static class Constantes
    {
        public const int MAXALIMENTOS = 40;
    }


    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/12/2026 3:36:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pantry
    {
        #region Attributes
        int tamanhoDespensa;
        static int totAlimentos = 0;
        Alimento[] alimentos;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pantry()
        {
            tamanhoDespensa = Constantes.MAXALIMENTOS;
            alimentos = new Alimento[tamanhoDespensa];
        }

        /// <summary>
        /// Cria uma despensa com tamanho "size"
        /// </summary>
        /// <param name="size"></param>
        public Pantry(int size)
        {
            if (size > Constantes.MAXALIMENTOS)
                tamanhoDespensa = Constantes.MAXALIMENTOS;
            else
                tamanhoDespensa = size;
            alimentos = new Alimento[tamanhoDespensa];
        }

        #endregion

        #region Properties

        /// <summary>
        /// Devolve o número maximo de alimentos que a dispensa comporta
        /// </summary>
        public int TamanhoDespensa
        {
            get { return tamanhoDespensa; }
        }

        /// <summary>
        /// Devolve o número atual de alimentos na dispensa
        /// </summary>
        public int TotAlimentos
        {
            get { return totAlimentos; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Verifica se determinado alimento existe na despensa
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool ExisteAlimentoDespensa(string nome)
        {
            for(int i=0; i < totAlimentos; i++)
            {
                //if(alimentos[i].nome.CompareTo(nome)==0)  //introduzir um pouco de strings
                if (alimentos[i].nome == nome) //USAR PROPERTY
                    return true;
            }
            return false;
        }
        
        /// <summary>
        /// Insere alimento na despensa
        /// </summary>
        /// <param name="a"></param>
        /// <returns>
        /// -1: Já existe
        /// -2: Despensa cheia
        /// 1: Inseriu
        /// </returns>
        public int InsereAlimentoDespensa(Alimento a)
        {
            //se já existe, não insere
            if (ExisteAlimentoDespensa(a.nome)) return -1;

            //se está cheia, não insere
            if (totAlimentos == tamanhoDespensa) return -2;
            alimentos[totAlimentos++] = a;
            return 1;
        }

        public void MostraDespensa()
        {
            for (int i = 0; i < totAlimentos; i++)
                Console.WriteLine(alimentos[i].ToString());
        }
        
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pantry()
        {
        }
        #endregion

        #endregion
    }
}
