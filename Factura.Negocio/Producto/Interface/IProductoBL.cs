//-----------------------------------------------------------------------
// <copyright file="IProductoBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 9:21:03</date>
// <summary>Código fuente clase IProductoBL.</summary>
//-----------------------------------------------------------------------

namespace Factura.Negocio
{
    using Factura.DtoModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>  
    /// IProductoBL class - Interface for Producto Business Logic.  
    /// </summary>  
    public interface IProductoBL
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