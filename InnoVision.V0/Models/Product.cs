namespace InnoVision.V0.Models
{
    public class Product
    {
        public int productid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageurl { get; set; }
        public decimal price { get; set; }
        public string buylink { get; set; }

        public int storeid { get; set; }
        public Store Store { get; set; }
    }
}
