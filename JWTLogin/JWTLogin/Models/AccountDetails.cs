using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTLogin.Models
{
    public class AccountDetails
    {
        
        [Key]
        public int AccountNumber { get; set; }

        //This is for foreign key refrence
        [Display(Name = "UserId")]
        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [Required]
        public Decimal Balance { get; set; }

    
    }
}
