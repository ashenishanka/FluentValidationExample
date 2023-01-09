using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationExample
{
    public class Customer
    {

        /// <summary>Gets or sets the customer identifier.</summary>
        /// <value>The customer identifier.</value>
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
    }
}
