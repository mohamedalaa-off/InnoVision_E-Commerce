namespace InnoVision.V0.Models
{
    public class Store
    {
        public int storeid { get; set; }
        public string name { get; set; }
        public string websiteurl { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
