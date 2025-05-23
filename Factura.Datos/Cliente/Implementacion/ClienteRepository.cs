//-----------------------------------------------------------------------
// <copyright file="ClienteRepository.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>aasuncion</author>
// <date>23/05/2025 8:40:42</date>
// <summary>Código fuente clase ClienteRepository.</summary>
//-----------------------------------------------------------------------

namespace Factura.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Factura.DtoModel;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;

    /// <summary>  
    /// ClienteRepository class - Repository for Cliente  
    /// </summary>  
    public class ClienteRepository : IClienteRepository
    {
        #region Attributes  

        /// <summary>  
        /// Cadena de conexión a la base de datos.  
        /// </summary>  
        private readonly string _connectionString;

        #endregion

        #region Constructors  

        /// <summary>  
        /// Initializes a new instance of the <see cref="ClienteRepository"/> class.  
        /// </summary>  
        /// <param name="config">Configuración para obtener la cadena de conexión.</param>  
        public ClienteRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        #endregion

        #region Methods And Functions  

        /// <summary>  
        /// Obtiene una lista de todos los clientes.  
        /// </summary>  
        /// <returns>Lista de objetos ClienteDto.</returns>  
        public IList<ClienteDto> ObtenerClientes()
        {
            var lista = new List<ClienteDto>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("sp_GetClientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClienteDto
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                RFC = reader["RFC"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los clientes desde la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener los clientes.", ex);
            }

            return lista;
        }

        #endregion
    }
}