namespace RENTACAR.DataContext.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int SeatCount { get; set; }
        public int TrunkSize { get; set; }
        public int DoorCount { get; set; }
        public string Description { get; set; } = null!;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int CarTypeId { get; set; }
        public CarType CarType { get; set; } = null!;
        public List<Car> Cars { get; set; } = [];
    }
}
