using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {
       public int ID { get; set; }

        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._]+@contoso\.edu$", ErrorMessage = "Invalid Email addresses. Please entere into the system conform with the pattern [username]@contoso.edu")]
        public string Email { get; set; }
    }
}