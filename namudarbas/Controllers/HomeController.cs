using Microsoft.AspNetCore.Mvc;
using namudarbas.Models;
using namudarbas.Interfaces;
using Dapper;
using Npgsql;
using namudarbas.DTO;

namespace namudarbas.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IPaskaitaService _paskaitaService;

        public HomeController(IPaskaitaService paskaitaService)
        {
            _paskaitaService = paskaitaService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertPaskaita([FromBody] Paskaitadto paskaita)
        {
            return Ok(_paskaitaService.InsertPaskaita(paskaita));
        }
    }
}
