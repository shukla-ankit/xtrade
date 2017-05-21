using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace xtrade.Models
{
    
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [EmailAddress]
        public string Seller { get; set; }

        [EmailAddress]
        public string Buyer { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set;  }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        [JsonIgnore]
        public virtual ICollection<BargainRecord> BargainRecords { get; set; }

        [JsonIgnore]
        public string DoNotDisplayImages { get; set; }

        public double getTotalAmount()
        {
            if(this.Images != null && this.Images.Count > 0)
            {
                double totalAmount = 0.0;
                foreach (Image image in this.Images)
                {
                    totalAmount += image.Amount;
                }
                return totalAmount;
            }
            
                return 0.0;
        }

    }
}