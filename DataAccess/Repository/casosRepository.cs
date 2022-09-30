using Dapper;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class casosRepository : ICasosRepository
    {
        private readonly IConfiguration _config;

        public casosRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> DeleteCaso(int id)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Delete from schcasos.casos
                         Where (id_caso = @Id and Estado = 'P') 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                Id = id
            });

            return result > 0;
        }

        public async Task<IEnumerable<casos>> GetCaso()
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.casos order by tipo_caso asc";
            return await conn.QueryAsync<casos>(sql, new {});
        }

        public async Task<casos> GetCasoId(int id_caso)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.casos
                        Where id_caso = @id_caso";

            return await conn.QueryFirstOrDefaultAsync<casos>(sql, new { id_caso = id_caso});

        }

        public async Task<casos> GetCasoUsuario(string pUsuario)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from casos
                        Where usuario_asignado = @usuarioAsignado";

            return await conn.QueryFirstOrDefaultAsync<casos>(sql, new { usuarioAsignado = pUsuario });

        }

        public async Task<bool> InsertCaso(casos casos)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Insert Into schcasos.casos(titulo, branch_padre, tipo_caso, link, id_ubicacion, git, cantidad_rechazos, aprobado, aprobado_cliente, estado, notas, branch, img_url) 
                         values (@titulo, @branch_padre, @tipo_caso, @link, @id_ubicacion, @git, @cantidad_rechazos, @aprobado, @aprobado_cliente, @estado, @notas, @branch, @img_urln)
                       ";
            var result = await conn.ExecuteAsync(sql, new { casos.titulo, casos.branch_padre, casos.tipo_caso,casos.link,casos.id_ubicacion,casos.git, casos.cantidad_rechazos, 
                                                            casos.aprobado,casos.aprobado_cliente,casos.estado,casos.notas,casos.branch,casos.img_url });

            return result > 0;

        }

        public async Task<bool> UpdateCaso(casos casos)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Update schcasos.casos
                         Set titulo = @titulo, descripcion = @descripcion,tipo_caso = @tipo_caso,
                             cantidad_devoluciones = @cantidad_devoluciones, notas = @notas,
                             estado = @estado,id_ubicacion = @id_ubicacion
                         Where (id_caso = @id_caso) 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                casos.id_caso,
                casos.titulo,
                casos.branch,
                casos.tipo_caso,
                casos.cantidad_rechazos,
                casos.notas,
                casos.estado,
                casos.id_ubicacion
            });

            return result > 0;
        }
    }
}
