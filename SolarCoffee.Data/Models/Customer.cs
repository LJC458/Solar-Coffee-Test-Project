using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCoffee.Data.Models
{
    public class Customer
    {
        public int ID { get; set; } //PK cust Table - auto increments
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CustomerAddress PrimaryAddress { get; set;} //set up FK relation to address table
    }
}
