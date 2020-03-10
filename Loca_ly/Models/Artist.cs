﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loca_ly.Models
{
    public class Artist
    {
        [key]
        public int Id { get; set; }
        public string IndividualName { get; set; }
        public string BandName { get; set; }
        public string Genre { get; set; }
        public int Zipcode { get; set; }
        public double MinPay { get; set; }
        public double AverageRating { get; set; }
        public bool GigAcceptedCurrently { get; set; }
        public double MaxTravelDistance { get; set; }
    }
}