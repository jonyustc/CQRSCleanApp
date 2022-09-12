namespace Application.Dtos
{
    public class CreateProductDto
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductMadeIn { get; set; }
        public string Status { get; set; }
        public string ProfilePhoto { get; set; }
        public int ProductUnitId { get; set; }
        public int ProductCategoryId { get; set; }

        public int? ProductPhotoId { get; set; }

        public int? ProductTagId { get; set; }
    }
}