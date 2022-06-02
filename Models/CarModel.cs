using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VibeDevTest.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Chassis { get; set; }
        [JsonIgnore]
        public CarMake Make { get; set; }
        public int MakeId   { get; set; }
        public CarModelDetail Details { get; set; }
    }
}
