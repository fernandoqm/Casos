using Models.Entities;

namespace webCasos.Services.Contracts
{
    public interface IUsuariosServices
    {
        Task<IEnumerable<usuarios>> getUsuarios();
        Task<usuarios> getUsuariosId(int id);
        Task<usuarios> getUsuariosUsuario(string usuario);
    }
}
