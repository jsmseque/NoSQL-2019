using System.ComponentModel.DataAnnotations;

namespace MongoExamples.Model
{
    public class MovieMetadata
    {
        [Required]
        public string MovieId { get; set; }

        [MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        public string Director { get; set; }

        public Actor[] Actors { get; set; }

        [RegularExpression(@"\d+")]
        public int Year { get; set; }

    }
}