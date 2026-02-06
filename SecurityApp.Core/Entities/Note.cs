using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class Note
    {
        public int Id { get; set; }
        [Required] public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime validFrom { get; set; }
        public DateTime validUntil { get; set; }
        public int BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}