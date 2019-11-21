using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;

namespace MongoExamples.Model
{
   [MetadataType(typeof (MovieMetadata))]
   [BsonIgnoreExtraElements]
   public class Movie
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string MovieId { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("directorName")]
        public string Director { get; set; }

        [BsonElement("actors")]
        public Actor[] Actors { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }

        [BsonIgnore]
        public int Age {
            get { return DateTime.Now.Year - this.Year; }
            set { }
        }
        [BsonExtraElements]
        public BsonDocument Metadata { get; set; }
    }
    public class Actor
    {
        public string Name { get; set; }
    }
}
