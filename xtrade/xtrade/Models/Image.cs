using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace xtrade.Models
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }

        [StringLength(255)]
        [JsonIgnore]
        public string ImageName { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        [JsonIgnore]
        public byte[] Content { get; set; }   
        
        [Required]
        [JsonIgnore]
        public double Amount { get; set; }

        [JsonIgnore]
        public bool DoNotDisplay { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        [JsonIgnore]
        public virtual ICollection<BargainRecord> BargainRecords { get; set; }
    }
}