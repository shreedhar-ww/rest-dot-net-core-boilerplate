using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Country name is too long.")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country name is too long.")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<Hotel> Hotels { get; set; }
    }

    public class UpdateCountryDTO : CreateCountryDTO
    {
        public IList<Hotel> Hotels { get; set; }
    }
}
