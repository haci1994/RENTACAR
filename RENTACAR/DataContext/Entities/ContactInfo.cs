namespace RENTACAR.DataContext.Entities
{
    public class ContactInfo : BaseEntity
    {
        public string? Number { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; } = null;
        public string? Logo1 { get; set; }
        public string? Logo2 { get; set; }
        public string? WorkingShift { get; set; }
    }
}
