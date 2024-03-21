using E_Ticket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profil Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name ")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Full Name is must be between 3 and 50 Chars") ]
        public string FullName { get; set; }
        [Display(Name = "Biography ")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
