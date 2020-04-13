using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }
        public CategoryResource Category { get; set; }
        public string Renk { get; set; }       
        public string Fiyat { get; set; }
        public string Sepetfiyati { get; set; }
        public string Url { get; set; }
        public string Onizlemeurl { get; set; }
    }
}
