using Models.Entities;

namespace webCasos.Services.Contracts
{
    public interface ICasosService
    {

        Task<IEnumerable<casos>> getItems();
        Task<casos> getItems(int id_caso);
        Task<casos> getCasosUsuario(string pUsuario);
    }
}
