//-----------------------------------------------------------------------
// <copyright file="ITiqueteRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:40:17</date>
// <summary>Código fuente clase ClienteController.</summary>
//-----------------------------------------------------------------------


namespace WebFacturas.Controllers
{
    using Factura.DtoModel;
    using Factura.Negocio;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>  
    /// Controlador para gestionar las operaciones relacionadas con los clientes.  
    /// </summary>  
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        /// <summary>  
        /// Instancia de la lógica de negocio para clientes.  
        /// </summary>  
        private readonly IClienteBL _clienteBL;

        /// <summary>  
        /// Inicializa una nueva instancia de la clase <see cref="ClienteController"/>.  
        /// </summary>  
        /// <param name="clienteBL">Instancia de la lógica de negocio para clientes.</param>  
        public ClienteController(IClienteBL clienteBL)
        {
            _clienteBL = clienteBL;
        }

        /// <summary>  
        /// Obtiene una lista de clientes.  
        /// </summary>  
        /// <returns>  
        /// Una acción que contiene una lista de objetos <see cref="ClienteDto"/>.  
        /// </returns>  
        [HttpGet]
        public ActionResult<List<ClienteDto>> Get()
        {
            try
            {
                var clientes = _clienteBL.ObtenerClientes();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrió un error al obtener los clientes: {ex.Message}");
            }
        }
    }
}
