using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealer_Website.Models {
    public class Feature
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Features {get; set;}
    }
}