using Api.Global;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IRepository<Question> Repo;

        public QuestionsController(IRepository<Question> _repo)
        {
            Repo = _repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var QuestionList = await Repo.GetAll();
            return Ok(QuestionList);
        }
    }
}