namespace RENTACAR.DataContext.Entities
{
    public class CarType : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<Model> Models { get; set; } = [];
    }
}
