using RENTACAR.DataContext.Entities;

namespace RENTACAR.Models
{
    public class CarsViewModel
    {
        public List<Car> Cars { get; set; } = [];
        public int CarCount {  get; set; } 
    }
}
