//-----------------------------------------------------------------------
// <copyright file="IClienteBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:37:41</date>
// <summary>Código fuente clase IClienteBL.</summary>
//-----------------------------------------------------------------------

namespace Factura.Negocio
{
    using Factura.DtoModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>  
    /// Interface que define la lógica de negocio para la entidad Cliente.  
    /// </summary>  
    public interface IClienteBL
    {
        #region Métodos y Funciones  

        /// <summary>  
        /// Obtiene una lista de clientes.  
        /// </summary>  
        /// <returns>  
        /// Una lista de objetos <see cref="ClienteDto"/> que representan los clientes.  
        /// </returns>  
        IList<ClienteDto> ObtenerClientes();

        #endregion
    }
}