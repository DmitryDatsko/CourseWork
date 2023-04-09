using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Models
{
	public class Test
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Question { get; set; } = string.Empty;
        [Required]
        [DisplayName("First Possible Answer")]
		public string FirstPossibleAnswer { get; set; } = string.Empty;
        [Required]
        [DisplayName("Second Possible Answer")]
        public string SecondPossibleAnswer { get; set; } = string.Empty;
        [Required]
        [DisplayName("Third Possible Answer")]
        public string ThirdPossibleAnswer { get; set; } = string.Empty;
        [Required]
        [DisplayName("Fourth Possible Answer")]
        public string FourthPossibleAnswer { get; set; } = string.Empty;
        [Required]
        public string Answer { get; set; } = string.Empty;
    }
}
