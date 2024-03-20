using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //RelationShip
        public List<Movie> Movies { get; set; }
    }
}
