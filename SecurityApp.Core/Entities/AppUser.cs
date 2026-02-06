

using System.ComponentModel.DataAnnotations;
using SecurityApp.Core.Entities.Enums;

namespace SecurityApp.Core.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        [Required]
        public Role Role { get; set; } = Role.Reception;
        [Required]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}
