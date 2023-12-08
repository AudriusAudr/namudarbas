using Npgsql;
using Dapper;
using namudarbas.Interfaces;
using namudarbas.Models;
using namudarbas.DTO;

namespace namudarbas.Repositories
{
    public class StudentasRepository : IStudentasRepository
    {

        public int InsertStudentas(Studentasdto studentas)
        {
            using (var connection = new NpgsqlConnection("User ID=postgres;Password=Wool84811;Host=localhost;Port=5432;Database=labas;"))
            {
                
               

                return connection.Execute($"INSERT INTO Studentas (studentas_id, vardas, pavardė, departamentas_id, paskaita_id) VALUES (@Studentas_id, @Vardas, @Pavardė, @Departamentas_id, Paskaita_id)", studentas);
            }
        }

       

        public IEnumerable<Studentas> GetStudentai()
        {
            using (var connection = new NpgsqlConnection("User ID=postgres;Password=Wool84811;Host=localhost;Port=5432;Database=labas;"))
            {
                return connection.Query<Studentas>("Select * from studentas");

            }
        }
    }
}
