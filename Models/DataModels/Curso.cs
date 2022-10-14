using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string LongDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public int level { get; set; }
    }
}
