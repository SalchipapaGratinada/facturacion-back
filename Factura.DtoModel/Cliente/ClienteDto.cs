//-----------------------------------------------------------------------
// <copyright file="ClienteDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:30:36</date>
// <summary>Código fuente clase ClienteDto.</summary>
//-----------------------------------------------------------------------

namespace Factura.DtoModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// ClienteDto class - Data Transfer Object for Cliente.
    /// </summary>
    public class ClienteDto
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value Id
        /// </summary>
        /// <value>Id</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value RazonSocial
        /// </summary>
        /// <value>RazonSocial</value>
        public string RazonSocial { get; set; }

        /// <summary>
        /// Gets or sets a value RFC
        /// </summary>
        /// <value>RFC</value>
        public string RFC { get; set; }

        #endregion
    }
}