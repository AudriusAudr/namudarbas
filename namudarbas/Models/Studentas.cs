namespace namudarbas.Models
{
    //public class Studentas
    //{
    //    public int ID { get; set; }
    //    public string Vardas { get; set; }
    //    public string Pavarde { get; set; }
    //    public int DepartamentoID { get; set; }
    //}

    public class Studentas
    {
        public int Studentas_Id { get; set; }
        public string Vardas { get; set; }
        public string Pavardė { get; set; }
        public int Departamentas_Id { get; set; }
        public Departamentas Departamentas { get; set; }
        public int Paskaita_Id { get; set; }
        public Paskaita Paskaita { get; set; }
    }

}
 