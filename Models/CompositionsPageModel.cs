using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class CompositionsPageModel
    {
         public string Question { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage ="Entry must be at least 3 characters")]
        [Required]
        public string Answer { get; set; }
    }
}
