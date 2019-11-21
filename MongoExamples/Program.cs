using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoExamples.Logic.Conexion;
using MongoExamples.Utiles;

namespace MongoExamples
{
    class Program
    {
        public async Task GetListOfDatabasesAsync()
        {
            var miConexion = new BdMongo();
            var client = miConexion.GetMongoClient("localhost");
            Console.WriteLine("Getting the list of databases asynchronously…");
            using (var cursor = await client.ListDatabasesAsync())
            {
                await cursor.ForEachAsync
                    (d => Console.WriteLine(d.ToString()));
            }
        }

        public static void GetListOfDatabasesSync()
        {
            var miConexion = new BdMongo();
            var client = miConexion.GetMongoClient("localhost");
            Console.WriteLine("Getting the list of databases synchronously…");
            var databases = client.ListDatabases().ToList();
            databases.ForEach
                (d => Console.WriteLine(d.GetElement("name").Value));
        }

        public Utiles.Class1  MyProperty { get; set; }

        static void Main(string[] args)
        {
        Console.WriteLine("Hello world to everybody.");
            Console.ReadLine();

            Console.WriteLine("Creando la colección necesaria.");
            var elMongo = new BdMongo();
            elMongo.CreateDatabase("localhost", "moviesDb", "movies_bson");

            GetListOfDatabasesSync();

            InsertePeliculasPOCO();
        }

        private static void InsertePeliculas()
        {
            var laInsercion = new InsertarPeliculas();
            laInsercion.InserteLasPeliculas();
        }

        private static void InsertePeliculasPOCO()
        {
            var laInsercion = new InsertarPeliculas();
            laInsercion.InserteLasPeliculasEnPOCO();
        }

    }
}
