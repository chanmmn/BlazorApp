using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class PersonModel
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountBalance { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
