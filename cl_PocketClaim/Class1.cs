using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cl_PocketClaim
{
   public class cl_PocketClaim
    {
        public class Driver
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string email { get; set; }
            public string PhoneNumber  { get; set; }
        }

        public class Vehicule
        {
            public string Maker { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string VIN { get; set; }
            public string PolicyNumber { get; set; }
        }

        public class Collision
        {

        }



    }
}
