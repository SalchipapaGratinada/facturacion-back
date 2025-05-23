//-----------------------------------------------------------------------
// <copyright file="ITiqueteRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:40:17</date>
// <summary>Código fuente clase ProductoController.</summary>
//-----------------------------------------------------------------------


namespace WebFacturas.Controllers
{

    using Factura.DtoModel;
    using Factura.Negocio;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>  
    /// Controlador para gestionar las operaciones relacionadas con productos.  
    /// </summary>  
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoBL _productoBL;

        /// <summary>  
        /// Inicializa una nueva instancia de la clase <see cref="ProductoController"/>.  
        /// </summary>  
        /// <param name="productoBL">Instancia de la lógica de negocio de productos.</param>  
        public ProductoController(IProductoBL productoBL)
        {
            _productoBL = productoBL;
        }

        /// <summary>  
        /// Obtiene la lista de productos disponibles.  
        /// </summary>  
        /// <returns>Una lista de objetos <see cref="ProductoDto"/>.</returns>  
        [HttpGet]
        public ActionResult<List<ProductoDto>> Get()
        {
            try
            {
                var productos = _productoBL.ObtenerProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrió un error al obtener los productos: {ex.Message}");
            }
        }
    }
}
