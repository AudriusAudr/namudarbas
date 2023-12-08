
using Dapper;
using namudarbas.DTO;
using namudarbas.Interfaces;
using namudarbas.Models;
using namudarbas.Repositories;
using Npgsql;
namespace namudarbas.Repositories
{
    public class PaskaitaRepository : IPaskaitaRepository
    {


        public int InsertPaskaita(Paskaitadto paskaita)
        {
            using (var connection = new NpgsqlConnection("User ID=postgres;Password=Wool84811;Host=localhost;Port=5432;Database=labas;"))
            {
                return connection.Execute(
                    $"INSERT INTO Paskaita (paskaita_id, pavadinimas, departamentas_id) VALUES (@Paskaita_ID, @Pavadinimas, @Departamentas_ID)", paskaita);

            }
        }

    }
}
