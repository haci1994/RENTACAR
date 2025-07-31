namespace RENTACAR.DataContext.Entities
{
    public class Car : BaseEntity
    {
        public decimal Price { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
        public List<CarImage> carImages { get; set; } = [];
    }
}
