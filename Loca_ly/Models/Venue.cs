using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loca_ly.Models
{
    public class Venue
    {
       [Key]
       public int Id { get; set; }
       public string Name { get; set; }
       public string Address { get; set; }
       public string GenrePreference { get; set; }
       public bool CoverCharge { get; set; }
       public int MaxPay { get; set; }
       public DateTime GigTime { get; set; }
       public double AverageArtistRating { get; set; }
       public string ArtistReviews { get; set; }
       
       
    }
}
