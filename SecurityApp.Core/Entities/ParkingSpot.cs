using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class ParkingSpot
    {
        public int Id { get; set; }
        [Required] public string SpotNumber { get; set; } = string.Empty;
        public string? CurrentPlateNumber { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public DateTime PermissionStart { get; set; }
        public DateTime PermissionEnd { get; set; }
        public int BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}