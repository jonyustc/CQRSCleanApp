namespace Domain
{
    public class ProductTag : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
    }
}