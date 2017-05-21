namespace xtrade.Models
{
    public enum role { Buyer, Seller, Visitor };
    public class User
    {
        public int id {get; set;}

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipcode { get; set; }

        public string country{ get; set; }

        public role user_role { get; set; }
 
    }
}
