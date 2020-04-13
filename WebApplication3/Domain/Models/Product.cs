using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Renk { get; set; }
        public string Fiyat { get; set; }
        public string Sepetfiyati { get; set; }
        public string Url { get; set; }
        public string Onizlemeurl { get; set; }
    }
}
