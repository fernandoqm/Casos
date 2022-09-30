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
    public class tegnologiaRepository : ITegnologiaRepository
    {
        private readonly IConfiguration _config;

        public tegnologiaRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> DeleteTegnologia(string id)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Delete from schcasos.tegnologias
                         Where (id_tegonologia = @Id) 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                Id = id
            });

            return result > 0;
        }

        public async Task<IEnumerable<tegnologia>> GetTegnologia()
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.tegnologias";
            return await conn.QueryAsync<tegnologia>(sql, new { });
        }

        public async Task<tegnologia> GetTegnologiaId(string id)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.tegnologia
                        Where id = @id_teg";
            return await conn.QueryFirstOrDefaultAsync<tegnologia>(sql, new { id_teg = id });
        }

        public async Task<bool> InsertTegnologia(tegnologia tegnologia)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Insert Into schcasos.tegnologia(id_tegnologia,nombre,descripcion) 
                         values (@id_tegnologia,@nombre,@descripcion)
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                tegnologia.id_tegnologia,
                tegnologia.nombre,
                tegnologia.descripcion
            });

            return result > 0;
        }

        public async Task<bool> UpdateTegnologia(tegnologia tegnologia)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Update schcasos.tegnologia
                         Set nombre = @nombre, descripcion = @descripcion
                         Where (id_tegnologia = @id_tegnologia) 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                tegnologia.id_tegnologia,
                tegnologia.nombre,
                tegnologia.descripcion
            });

            return result > 0;
        }
    }
}
