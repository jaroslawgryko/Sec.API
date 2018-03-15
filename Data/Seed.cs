using System.Collections.Generic;
using AutoMapper;
using Newtonsoft.Json;
using Sec.API.Dtos;
using Sec.API.Model;

namespace Sec.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public Seed(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public void SeedLessons()
        {
            // _context.Lessons.RemoveRange(_context.Lessons);
            // _context.SaveChanges();

            var lessonData = System.IO.File.ReadAllText("Data/LessonSeedData.json");

            var lessonsForAdd = JsonConvert.DeserializeObject<List<LessonForAddDto>>(lessonData);

            foreach (var lessonForAdd in lessonsForAdd)
            {
                var lesson = _mapper.Map<Lesson>(lessonForAdd);
                _context.Lessons.Add(lesson);                
            }

            _context.SaveChanges();
        }
    }
}