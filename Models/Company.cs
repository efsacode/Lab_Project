using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Application1.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(5)]
        [RegularExpression("^[0-9]*$")] 
        public string Zipcode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(60)]
        public string Country { get; set; }

        public ICollection<Employee> Employee { get; } = new List<Employee>();
        public string Address { get; internal set; }
        public int NumberOfEmployees { get; internal set; }
    }
}
