//-----------------------------------------------------------------------
// <copyright file="IProductoRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 9:22:25</date>
// <summary>Código fuente clase IProductoRepository.</summary>
//-----------------------------------------------------------------------

namespace Factura.Datos
{
    using Factura.DtoModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>  
    /// IProductoRepository class - Interface for Producto Repository.  
    /// </summary>  
    public interface IProductoRepository
    {
        #region Methods And Functions  

        /// <summary>  
        /// Obtiene una lista de productos.  
        /// </summary>  
        /// <returns>Lista de objetos ProductoDto.</returns>  
        IList<ProductoDto> ObtenerProductos();

        #endregion
    }
}