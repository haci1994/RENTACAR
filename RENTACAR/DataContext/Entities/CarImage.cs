namespace RENTACAR.DataContext.Entities
{
    public class CarImage : BaseEntity
    {
        public string Image { get; set; } = null!;
        public int CarId { get; set; }
        public Car? Car { get; set; }
    }
}
