using System.ComponentModel.DataAnnotations;

namespace DESAISIV_Task_Omar_Almahammed.models
{
    public class Book
    {
        [Key]
        int Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        int PublicationYear { get; set; }
    }
}
