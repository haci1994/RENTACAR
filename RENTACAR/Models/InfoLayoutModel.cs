using RENTACAR.DataContext.Entities;

namespace RENTACAR.Models
{
    public class InfoLayoutModel
    {
        public List<Social> Socials { get; set; } = [];
        public ContactInfo? ContactInfo { get; set; }
    }
}
