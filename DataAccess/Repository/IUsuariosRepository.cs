using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUsuariosRepository
    {
        Task<IEnumerable<usuarios>> GetTUsuarios();
        Task<usuarios> GetUsuariosId(Int64 id_usuario);
        Task<usuarios> GetUsuariosUsuario(string usuario);
        Task<bool> InsertUsuarios(usuarios usuarios);
        Task<bool> UpdateUsuarios(usuarios usuarios);
        Task<bool> DeleteUsuarios(string id_usuario);
        Task<bool> CambioClave(usuarios usuarios);

    }
}
