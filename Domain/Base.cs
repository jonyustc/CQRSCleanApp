namespace Domain
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? UpdatedById { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedById { get; set; }
        public string DeletedBy { get; set; }
        public string Remarks { get; set; }
    }
}