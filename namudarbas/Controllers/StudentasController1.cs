using Microsoft.AspNetCore.Mvc;
using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;

namespace namudarbas.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentasController1 : ControllerBase
    {
        private readonly IStudentasService _studentasService;

        public StudentasController1(IStudentasService studentasService)
        {
            _studentasService = studentasService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertStudentas([FromBody] Studentasdto studentas)
        {
            return Ok(_studentasService.InsertStudentas(studentas));
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentai()
        {
            return Ok(_studentasService.GetStudentai());
        }
    }
}

