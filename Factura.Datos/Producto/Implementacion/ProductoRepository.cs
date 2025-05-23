//-----------------------------------------------------------------------
// <copyright file="ProductoRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 9:22:44</date>
// <summary>Código fuente clase ProductoRepository.</summary>
//-----------------------------------------------------------------------

namespace Factura.Datos
{
    using Factura.DtoModel;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;

    /// <summary>  
    /// ProductoRepository class - Implementation of IProductoRepository  
    /// </summary>  
    public class ProductoRepository : IProductoRepository
    {
        #region Attributes  

        /// <summary>  
        /// Cadena de conexión a la base de datos.  
        /// </summary>  
        private readonly string _connectionString;

        #endregion

        #region Constructors  

        /// <summary>  
        /// Inicializa una nueva instancia de la clase <see cref="ProductoRepository"/>.  
        /// </summary>  
        /// <param name="config">Configuración para obtener la cadena de conexión.</param>  
        public ProductoRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        #endregion

        #region Methods And Functions  

        /// <summary>  
        /// Obtiene una lista de productos desde la base de datos.  
        /// </summary>  
        /// <returns>Lista de objetos <see cref="ProductoDto"/>.</returns>  
        public IList<ProductoDto> ObtenerProductos()
        {
            var lista = new List<ProductoDto>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_GetProductos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProductoDto
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NombreProducto = reader["NombreProducto"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                                ImagenProducto = reader["ImagenProducto"] != DBNull.Value ? (byte[])reader["ImagenProducto"] : null,
                                Ext = reader["ext"]?.ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los productos desde la base de datos.", ex);
            }
            catch (Exception ex)
            {  
                throw new Exception("Ocurrió un error inesperado.", ex);
            }

            return lista;
        }

        #endregion
    }
}