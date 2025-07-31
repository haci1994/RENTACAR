using Microsoft.AspNetCore.Mvc;
using RENTACAR.DataContext;
using RENTACAR.Models;

namespace RENTACAR.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contact = _dbContext.ContactInfos.FirstOrDefault();
            var socials = _dbContext.Socials.ToList();

            var model = new InfoLayoutModel
            {
                ContactInfo = contact,
                Socials = socials
            };


            return View(model);
        }
        
    }
}
