﻿using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class VehicleViewModel
    {
        public string Type { get; set; }
        public string License { get; set; }
        public string Make { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm\:ss}")]
        public TimeSpan TimeSpent { get; set; }
    }
}