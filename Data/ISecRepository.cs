using System.Collections.Generic;
using System.Threading.Tasks;
using Sec.API.Model;

namespace Sec.API.Data
{
    public interface ISecRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();

        Task<IEnumerable<Lesson>> GetLessons();
    }
}