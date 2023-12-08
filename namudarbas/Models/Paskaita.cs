using System.ComponentModel.DataAnnotations;

namespace namudarbas.Models
{
    //public class Paskaita
    //{

    //    public int ID { get; set; }
    //    public string Pavadinimas { get; set; }
    //    public int DepartamentoID { get; set; }
    //}

    public class Paskaita
    {
        public int PaskaitaId { get; set; }
        public string Pavadinimas { get; set; }
        public int DepartamentasId { get; set; }
        public Departamentas Departamentas { get; set; }
    }



}
