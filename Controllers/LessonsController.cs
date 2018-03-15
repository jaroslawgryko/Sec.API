using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sec.API.Data;
using Sec.API.Dtos;

namespace Sec.API.Controllers
{
    [Route("api/[controller]")]
    public class LessonsController : Controller
    {
        private readonly ISecRepository _repo;
        private readonly IMapper _mapper;
        public LessonsController(ISecRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        public async Task<IActionResult> GetLessons()
        {
            var lessons = await _repo.GetLessons();
            var lessonsToReturn = _mapper.Map<IEnumerable<LessonForListDto>>(lessons);

            return Ok(lessonsToReturn);
        }
    }
}