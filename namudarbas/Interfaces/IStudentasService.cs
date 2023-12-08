using namudarbas.DTO;
using namudarbas.Models;

namespace namudarbas.Interfaces
{
    public interface IStudentasService
    {
        public int InsertStudentas(Studentasdto studentas);
        public List<Studentas> GetStudentai();

    }
}
