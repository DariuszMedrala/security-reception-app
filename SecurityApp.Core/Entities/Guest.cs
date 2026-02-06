
using System.ComponentModel.DataAnnotations;

namespace SecurityApp.Core.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        [Required] 
        public string FirstName { get; set; } = string.Empty;
        [Required] 
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Company { get; set; } = string.Empty;
        public DateTime PermissionStart { get; set; }
        public DateTime PermissionEnd { get; set; }

    }
}
