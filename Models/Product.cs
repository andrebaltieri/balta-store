namespace Balta.Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}