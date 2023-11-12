﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeFurnitureRentalSystem.model
{
    public class RentalItem
    {
        public int Rental_id { get; set; }
        public int Member_id { get; set; }
        public int Employee_num { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime Due_date { get; set; }
        public int Furniture_id { get; set; }
        public int Quantity { get; set; }
    }
}
