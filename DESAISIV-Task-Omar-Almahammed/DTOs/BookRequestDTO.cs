using System.ComponentModel.DataAnnotations;

namespace DESAISIV_Task_Omar_Almahammed.DTOs
{
    public class BookRequestDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
    }
}
