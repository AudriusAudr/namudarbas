using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;

namespace namudarbas.Services
{
    public class DepartamentasService : IDepartamentasService
    {
        private readonly IDepartamentasRepository _departamentasRepository;
        public DepartamentasService(IDepartamentasRepository departamentasRepository)
        {
            _departamentasRepository = departamentasRepository;
        }


        public int InsertDepartamentas(Departamentasdto departamentas)
        {
            return _departamentasRepository.InsertDepartamentas(departamentas);
        }



    }
}
