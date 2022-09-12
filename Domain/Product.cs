namespace Domain
{
    public class Product : Base
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductMadeIn { get; set; }
        public ProductStatus Status { get; set; }
        public string ProfilePhoto { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public int? ProductPhotoId { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }

        public int? ProductTagId { get; set; }
        public ICollection<ProductTag> Tags { get; set; }

    }
}