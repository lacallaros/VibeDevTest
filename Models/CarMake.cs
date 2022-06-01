using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VibeDevTest.Models
{
    public class CarMake
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }
        [JsonIgnore]
        public List<CarModel> Models { get; set; }
    }
}
