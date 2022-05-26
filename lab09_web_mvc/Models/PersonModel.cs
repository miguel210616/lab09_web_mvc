using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab09_web_mvc.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}