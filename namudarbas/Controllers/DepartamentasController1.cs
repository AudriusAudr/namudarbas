using Microsoft.AspNetCore.Mvc;
using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;

namespace namudarbas.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DepartamentasController1 : ControllerBase
    {

        private readonly IDepartamentasService _departamentasService;

        public DepartamentasController1(IDepartamentasService departamentasService)
        {
            _departamentasService = departamentasService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertDepartamentas([FromBody] Departamentasdto departamentas)
        {
            return Ok(_departamentasService.InsertDepartamentas(departamentas));
        }
    }
}

