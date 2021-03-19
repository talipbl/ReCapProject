﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }
    }
}
