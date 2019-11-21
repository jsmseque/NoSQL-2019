using MongoDB.Bson;
using MongoExamples.Logic.Conexion;
using MongoExamples.Logic.Mappers;
using MongoExamples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExamples.Utiles
{
    public class InsertarPeliculas
    {
        public void InserteLasPeliculas()
        {
            var lasPeliculas = new MovieManager();
            BsonDocument[] movies = lasPeliculas.GetBsonMovies();
            var laConexion = new Peliculas();
            laConexion.Insert<BsonDocument>(movies, "moviesDb", "movies_bson").Wait();
        }
        
        public  void InserteLasPeliculasEnPOCO()
        {
            var lasPeliculas = new MovieManager();
            Movie[] movies = lasPeliculas.GetMovieList();
            var elMapeador = new BsonMapper();
            elMapeador.Map();
            //map the class to the MongoDB representation.
            var laConexion = new Peliculas();
            laConexion.Insert<Movie>(movies, "moviesDb", "movies_poco").Wait();
        }

    }
}
