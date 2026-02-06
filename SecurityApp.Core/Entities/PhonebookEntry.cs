using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class PhonebookEntry
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;
        [Required] public string PhoneNumber { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}