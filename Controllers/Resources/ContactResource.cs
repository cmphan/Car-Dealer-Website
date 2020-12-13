using System.ComponentModel.DataAnnotations;

namespace Car_Dealer_Website.Resources
{
    public class ContactResource
    {
        [Required]
        [StringLength(255)]
        public string Name {get;set;}
         [StringLength(255)]
        public string Email {get;set;}
        [Required]
        [StringLength(255)]
        public string Phone {get;set;}

    }
}