namespace namudarbas.Models
{
    //public class Departamentas
    //{
    //    public int ID { get; set; }
    //    public string Pavadinimas { get; set; }

    //}

    public class Departamentas
    {
        public int Departamentas_Id { get; set; }
        public string Pavadinimas { get; set; }
        public ICollection<Paskaita> Paskaitos { get; set; }
        public ICollection<Studentas> Studentai { get; set; }
    }


}
