using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class Avization
    {
        public int Id { get; set; }
        [Required]
        public string CompanyPerformingWork { get; set; } = string.Empty;

        [Required]
        public string WorkDescription { get; set; } = string.Empty;

        public bool IsFireHazard { get; set; } = false;
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkEndDate { get; set; }
        public DateTime? NotificationEmailSentAt { get; set; }
        public string? ResponsiblePersonName { get; set; }
        public string? ResponsiblePersonPhone { get; set; }
        public int BuildingId { get; set; }
        public Building? Building { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}