using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sec.API.Model;

namespace Sec.API.Data
{
    public class SecRepository : ISecRepository
    {
        private readonly DataContext _context;
        public SecRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Lesson>> GetLessons()
        {
            var lessons = await _context.Lessons.ToListAsync();
            return lessons;
        }

    }
}