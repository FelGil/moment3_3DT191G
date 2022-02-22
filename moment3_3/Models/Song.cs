using System.ComponentModel.DataAnnotations;

namespace moment3_3.Models
{

    public class Song
    {
        //Properties
        public int Id { get; set; }

        [Required]
        public string? Artist { get; set; }

        [Required]
        public string? Title { get; set; }

        public int Length { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}
