﻿using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Ciclomotor
    {
        public int Id { get; set; }
        public int Ruedas { get; set; }
        public int VehiculosIdVehiculo { get; set; }
    }
}
