﻿using RENTACAR.DataContext.Entities;

namespace RENTACAR.Models
{
    public class HomeViewModel
    {
        public List<Car> Cars { get; set; } = [];
        public List<ContactInfo> Contacts { get; set; } = [];
    }
}
