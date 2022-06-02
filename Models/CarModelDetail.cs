using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VibeDevTest.Models
{
    public class CarModelDetail
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Description { get; set; }
        [JsonIgnore]
        public CarModel Model { get; set; }
        public int ModelId { get; set; }
    }
}
