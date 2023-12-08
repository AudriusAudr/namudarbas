using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;

namespace namudarbas.Services
{
    public class StudentasService : IStudentasService
    {
        private readonly IStudentasRepository _studentasRepository;
        public StudentasService(IStudentasRepository studentasRepository)
        {
            _studentasRepository = studentasRepository;
        }


        public int InsertStudentas(Studentasdto studentas)
        {
            return _studentasRepository.InsertStudentas(studentas);
        }


        public List<Studentas> GetStudentai()
        { 
            return _studentasRepository.GetStudentai().ToList();
        } 
    }
}
