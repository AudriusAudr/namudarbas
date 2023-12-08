using namudarbas.DTO;
using namudarbas.Models;

namespace namudarbas.Interfaces
{
    public interface IStudentasRepository
    {
        public int InsertStudentas(Studentasdto studentas);
        public IEnumerable<Studentas> GetStudentai();
        
    }
}

