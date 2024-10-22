using System.ComponentModel.DataAnnotations;

namespace DESAISIV_Task_Omar_Almahammed.models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
    }
}
