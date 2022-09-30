using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICasosRepository
    {
        Task<IEnumerable<casos>> GetCaso();
        Task<casos> GetCasoId(int id);
        Task<casos> GetCasoUsuario(string pUsuario);
        Task<bool> InsertCaso(casos casos);
        Task<bool> UpdateCaso(casos casos);
        Task<bool> DeleteCaso(int id);
    }
}
