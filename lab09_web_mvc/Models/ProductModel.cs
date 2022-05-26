using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab09_web_mvc.Models
{
    public class ProductModel
    {
        public int ProductId{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}