//-----------------------------------------------------------------------
// <copyright file="ProductoDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:32:20</date>
// <summary>Código fuente clase ProductoDto.</summary>
//-----------------------------------------------------------------------

namespace Factura.DtoModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// ProductoDto class - Data Transfer Object for Producto.
    /// </summary>
    public class ProductoDto
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value Id
        /// </summary>
        /// <value>Id</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value NombreProducto
        /// </summary>
        /// <value>NombreProducto</value>
        public string NombreProducto { get; set; }

        /// <summary>
        /// Gets or sets a value PrecioUnitario
        /// </summary>
        /// <value>PrecioUnitario</value>
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Gets or sets a value ImagenProducto
        /// </summary>
        /// <value>ImagenProducto</value>
        public byte[] ImagenProducto { get; set; }

        /// <summary>
        /// Gets or sets a value Ext
        /// </summary>
        /// <value>Ext</value>
        public string Ext { get; set; }

        #endregion
    }
}