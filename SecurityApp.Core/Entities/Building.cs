using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; 

        [Required]
        public string Code { get; set; } = string.Empty;
        public List<AppUser> Users { get; set; } = new();
        public List<Avization> Avizations { get; set; } = new();
        public List<Note> Notes { get; set; } = new();
        public List<ParkingSpot> ParkingSpots { get; set; } = new();
        public List<PhonebookEntry> Phonebook { get; set; } = new();
        public List<Guest> Guests { get; set; } = new();
    }
}