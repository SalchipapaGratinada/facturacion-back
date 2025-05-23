//-----------------------------------------------------------------------
// <copyright file="ITiqueteRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:40:17</date>
// <summary>Código fuente clase ITiqueteRepository.</summary>
//-----------------------------------------------------------------------

namespace Factura.Datos
{
    using Factura.DtoModel;
    using System.Collections.Generic;

    /// <summary>  
    /// IClienteRepository interface - Define las operaciones para el repositorio de clientes.  
    /// </summary>  
    public interface IClienteRepository
    {
        #region Methods And Functions  

        /// <summary>  
        /// Obtiene una lista de todos los clientes.  
        /// </summary>  
        /// <returns>Lista de objetos ClienteDto.</returns>  
        IList<ClienteDto> ObtenerClientes();

        #endregion
    }
}