using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSWebAPI.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AName { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter your Gender")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter your Address")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password field is required")]
        public bool Active { get; set; }

        [ForeignKey("AdminType")]
        [Required(ErrorMessage ="ID is Manadatory")]
        public int AdminTypeId { get; set; }

        public AdminType AdminType { get; set; }
    }
}
