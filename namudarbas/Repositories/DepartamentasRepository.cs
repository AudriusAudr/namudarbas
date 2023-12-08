using namudarbas.Interfaces;
using namudarbas.Models;
using Npgsql;
using Dapper;
using namudarbas.DTO;



namespace namudarbas.Repositories
{
    public class DepartamentasRepository : IDepartamentasRepository
    {
        public int InsertDepartamentas(Departamentasdto departamentas)
        {

            using (var connection = new NpgsqlConnection("User ID=postgres;Password=Wool84811;Host=localhost;Port=5432;Database=labas;"))
            {
               
                

                return connection.Execute($"INSERT INTO Departamentas  (pavadinimas, departamentas_id) VALUES (@Pavadinimas, @Departamentas_id)",new { departamentas });


            }

        }


    }
}



