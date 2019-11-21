using MongoDB.Bson;
using MongoExamples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExamples.Utiles
{
    public class MovieManager
    {
        public Movie[] GetMovieList()
        {
            Movie sevenSamurai = new Movie()
            { Name = "Seven Samurai",
                Director = "Akira Kurosawa",
                Year = 1954,
                Actors = new Actor[] {
                    new Actor { Name = "Toshiro Mifune" },
                    new Actor { Name = "Takashi Shimura" },
                }
            };
            Movie theGodFather = new Movie()
            {
                Name = "The Godfather",
                Director = "Francis Ford Coppola",
                Year = 1972,
                Actors = new Actor[] {
                    new Actor { Name = "Marlon Brando" },
                    new Actor { Name = "Al Pacino" }, },
                Metadata = new BsonDocument("href", "http://thegodfather.com")
            };
            return new Movie[] { sevenSamurai, theGodFather };
        }

        public BsonDocument[] GetBsonMovies()
        {
            BsonDocument sevenSamurai = new BsonDocument()
        {   { "name", "The Seven Samurai" },
            { "directorName", " Akira Kurosawa" },
            { "actors",
                new BsonArray { new BsonDocument("name", "Toshiro Mifune"), new BsonDocument("name", "Takashi Shimura") } }, { "year", 1954 } };
            BsonDocument theGodfather = new BsonDocument() { { "name", "The Godfather" }, { "directorName", "Francis Ford Coppola" }, { "actors", new BsonArray { new BsonDocument("name", "Marlon Brando"), new BsonDocument("name", "Al Pacino"), new BsonDocument("name", "James Caan") } }, { "year", 1972 } }; return new BsonDocument[] { sevenSamurai, theGodfather };
        }
    }
}
