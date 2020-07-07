using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Phonebook.Models
{
    public class User
    {
        [Required]
        public string Name { set; get; }

        public string AddressLine1 { set; get; }

        public string AddressLine2 { set; get; }

        public string City { set; get; }

        public string Pincode { set; get; }

        public string PhoneNumber { set; get; }
    }
}