//-----------------------------------------------------------------------
// <copyright file="ClienteBL.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:37:59</date>
// <summary>Código fuente clase ClienteBL.</summary>
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
    /// ClienteBL class - Business Logic for Cliente  
    /// </summary>  
    public class ClienteBL : IClienteBL
    {
        #region Attributes  

        /// <summary>  
        /// Repositorio de clientes utilizado para acceder a los datos.  
        /// </summary>  
        private readonly IClienteRepository _clienteRepository;

        #endregion

        #region Constructors  

        /// <summary>  
        /// Initializes a new instance of the <see cref="ClienteBL"/> class.  
        /// </summary>  
        /// <param name="clienteRepository">Repositorio de clientes inyectado.</param>  
        public ClienteBL(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        #endregion

        #region Properties  

        #endregion

        #region Methods And Functions  

        /// <summary>  
        /// Obtiene una lista de clientes.  
        /// </summary>  
        /// <returns>  
        /// Una lista de objetos <see cref="ClienteDto"/> que representan los clientes.  
        /// </returns>  
        public IList<ClienteDto> ObtenerClientes()
        {
            try
            {
                return _clienteRepository.ObtenerClientes();
            }
            catch (Exception ex)
            { 
                throw new ApplicationException("Ocurrió un error al obtener la lista de clientes.", ex);
            }
        
        }

        #endregion
    }
}