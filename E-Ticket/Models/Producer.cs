using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //RelationShip
        public List<Movie> Movies { get; set; }
    }
}
