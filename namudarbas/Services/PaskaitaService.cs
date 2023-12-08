using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;

namespace namudarbas.Services
{
    public class PaskaitaService : IPaskaitaService
    {
        private readonly IPaskaitaRepository _paskaitaRepository;
        public PaskaitaService(IPaskaitaRepository paskaitaRepository)
        {
            _paskaitaRepository = paskaitaRepository;
        }
        

        public int InsertPaskaita(Paskaitadto paskaita)
        {
            return _paskaitaRepository.InsertPaskaita( paskaita);
        }
    }
}
