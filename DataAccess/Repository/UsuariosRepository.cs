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
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly IConfiguration _config;
        public UsuariosRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> CambioClave(usuarios usuarios)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Update schcasos.usuarios
                         Set clave = @clave, 
                         fecha_ultimo_cambio_clave = (select now() AT TIME ZONE 'CST')
                         Where id_usuario = @id_usuario 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                usuarios.id_usuario,
                usuarios.clave,
                usuarios.correo,
                usuarios.ubicacion_activa,
                usuarios.estado,
                usuarios.usuario
            });

            return result > 0;
        }

        public async Task<bool> DeleteUsuarios(string id_usuario)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Delete from schcasos.usuarios
                         Where (id_caso = @Id) 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                Id = id_usuario
            });

            return result > 0;
        }

        public async Task<IEnumerable<usuarios>> GetTUsuarios()
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.usuarios";
            return await conn.QueryAsync<usuarios>(sql, new { });
        }

        public async Task<usuarios> GetUsuariosId(Int64 id_usuario)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.usuarios
                        Where id = @id";
            return await conn.QueryFirstOrDefaultAsync<usuarios>(sql, new { id = id_usuario });
        }

        public async Task<usuarios> GetUsuariosUsuario(string usuario)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"Select * from schcasos.usuarios
                        Where usuario = @usuario";
            return await conn.QueryFirstOrDefaultAsync<usuarios>(sql, new { usuario = usuario });
        }

        public async Task<bool> InsertUsuarios(usuarios usuarios)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Insert Into schcasos.usuarios(nombre,correo,ubicacion_activa,estado,usuario) 
                         values (@nombre, @correo, @ubicacion_activa, @estado, @usuario)
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                usuarios.nombre,
                usuarios.correo,
                usuarios.ubicacion_activa,
                usuarios.estado,
                usuarios.usuario
            });

            return result > 0;
        }

        public async Task<bool> UpdateUsuarios(usuarios usuarios)
        {
            using IDbConnection conn = new NpgsqlConnection(_config.GetConnectionString("Conect"));

            var sql = @"
                         Update schcasos.usuarios
                         Set nombre = @nombre, correo = @correo, 
                             ubicacion_activa = @ubicacion_activa, 
                             estado = @estado,
                             usuario = @usuario
                         Where (id_usuario = @id_usuario) 
                       ";
            var result = await conn.ExecuteAsync(sql, new
            {
                usuarios.id_usuario,
                usuarios.nombre,
                usuarios.correo,
                usuarios.ubicacion_activa,
                usuarios.estado,
                usuarios.usuario
            });

            return result > 0;
        }
    }
}
