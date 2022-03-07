using HotelListing.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {       

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name must be under 50 letters")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short name must be under 4 letters")]
        public string ShortName { get; set; }

    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<Hotel> Hotels { get; set; }
    }
}
