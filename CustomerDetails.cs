using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDotNetCore.Entities
{
    class CustomerDetails
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
    }
}
