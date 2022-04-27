using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieDotNetCore.Entities
{
    public class MovieDetails
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Identity column
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int Price { get; set; }
    }
}
