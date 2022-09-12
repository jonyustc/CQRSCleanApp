namespace Domain
{
    public class ProductPhoto : Base
    {
        public string Name { get; set; }
        public string Extention { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PhysicalLocation { get; set; }
        public Product Product { get; set; }
    }
}