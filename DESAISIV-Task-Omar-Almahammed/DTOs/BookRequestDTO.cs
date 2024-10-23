using System.ComponentModel.DataAnnotations;

namespace DESAISIV_Task_Omar_Almahammed.DTOs
{
    public class BookRequestDTO
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter a valid title name.")]
        public string Title { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please enter a valid author name.")]
        public string Author { get; set; }

        [Range(1800, 2024, ErrorMessage = "Publication year must be between 1900 and 2024.")]
        public int PublicationYear { get; set; }
    }
}
