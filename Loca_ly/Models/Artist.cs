using System;
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
        public string Instrument { get; set; }
        public string BandName { get; set; }
        public string Genre { get; set; }
        public int Zipcode { get; set; }
        public double MinPay { get; set; }
        public double AverageVenueRating { get; set; }
        public double AverageArtistRating { get; set; }
        public bool GigAcceptedCurrently { get; set; }
        public double MaxTravelDistance { get; set; }
        public string VenueReviews { get; set; }
        public string ArtistReviews { get; set; }
        public string MainSongName { get; set; }
        
    }
}
