using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ITegnologiaRepository
    {
        Task<IEnumerable<tegnologia>> GetTegnologia();
        Task<tegnologia> GetTegnologiaId(string id);
        Task<bool> InsertTegnologia(tegnologia tegnologia);
        Task<bool> UpdateTegnologia(tegnologia tegnologia);
        Task<bool> DeleteTegnologia(string id);
    }
}
