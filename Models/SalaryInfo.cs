using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application1.Models
{
    public class SalaryInfo
    {
        [Key]
        public int Id { get; set; }
        //public int SalaryId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Net { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Gross { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}