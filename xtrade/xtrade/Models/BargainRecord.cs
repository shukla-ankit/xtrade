using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace xtrade.Models
{

    public class BargainRecord
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BargainRecordId { get; set; }

        public bool PrivateIndicator { get; set; }

        private bool LastSeenIndicator { get; set; }

        private DateTime LastSeenDateTime { get; set; }

        public int ParentBargainRecordId { get; set; }

        public bool RootBargainRecordIndicator { get; set; }

        public string BargainerEmail { get; set; }

        public double Amount { get; set; }

        public double BargainMessage { get; set; }

        public int? ImageId { get; set; }

        public virtual Image Image { get; set; }

        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }

        public bool AcceptanceIndicator { get; set; }

    }
}