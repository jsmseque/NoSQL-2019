using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExamples.Logic.Conexion
{
    public class Peliculas
    {

        public  async Task Insert<T>(T[] movies, string dbName, string tableName)
        {
            var laConexion = new BdMongo();
            var db = laConexion.GetDatabaseReference("localhost", dbName);
            var moviesCollection = db.GetCollection<T>(tableName);
            await moviesCollection.InsertManyAsync(movies);
        }
    }
}
