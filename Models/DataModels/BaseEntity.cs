using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdateBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        

    }
}
