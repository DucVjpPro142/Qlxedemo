using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLXE.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public long ReviewsID { get; set; }
        public long CarID { get; set; }
        public long CustomersID { get; set; }
        public DateTime EvaluationDate { get; set; }
        public string? Comment { get; set; }
        public string? ReviewName { get; set; }
        public string? Image {  get; set; }
        public string? Profession {  get; set; }
        public bool? IsActive { get; set; }
    }
}
