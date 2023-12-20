using System.Diagnostics.Metrics;
using System.Net;

namespace Application1.Models
{
    public class CompanyDetailsDto
    {
        public int Id { get; set; }

      
        public string Name { get; set; }
       // public string FullAddress { get; set; }
        public int NumberOfEmployees { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string FullAddress { get; set; }
        
    }

    
}
