//-----------------------------------------------------------------------
// <copyright file="ProductoBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 9:20:44</date>
// <summary>Código fuente clase ProductoBL.</summary>
//-----------------------------------------------------------------------

namespace Factura.Negocio
{
    using Factura.Datos;
    using Factura.DtoModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>  
    /// ProductoBL class - Business Logic for Producto  
    /// </summary>  
    public class ProductoBL : IProductoBL
    {
        #region Attributes  

        /// <summary>  
        /// Repositorio de productos para acceder a los datos.  
        /// </summary>  
        private readonly IProductoRepository _productoRepository;

        #endregion

        #region Constructors  

        /// <summary>  
        /// Initializes a new instance of the <see cref="ProductoBL"/> class.  
        /// </summary>  
        /// <param name="productoRepository">Instancia del repositorio de productos.</param>  
        public ProductoBL(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        #endregion

        #region Methods And Functions  

        /// <summary>  
        /// Obtiene la lista de productos disponibles.  
        /// </summary>  
        /// <returns>Lista de productos como <see cref="IList{ProductoDto}"/>.</returns>  
        public IList<ProductoDto> ObtenerProductos()
        {
            try
            {
                return _productoRepository.ObtenerProductos();
            }
            catch (Exception ex)
            { 
                throw new ApplicationException("Error al obtener la lista de productos.", ex);
            }
        
        }

        #endregion
    }
}