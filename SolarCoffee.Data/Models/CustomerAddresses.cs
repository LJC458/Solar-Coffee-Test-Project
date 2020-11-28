using System;
using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; } //PK cust Table - auto increments
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        [MaxLength(100)]
        public string AddressLine2 { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string County { get; set; }
        [MaxLength(10)]
        public string PostCode { get; set; }
        [MaxLength(32)]
        public string Country { get; set; }


    }
}
