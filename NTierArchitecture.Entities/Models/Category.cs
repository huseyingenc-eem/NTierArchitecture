using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    // ICollection: Koleksiyon türleri için temel bir arayüzdur. List,Hashset, LinkedList, Dictionary

    public class Category:Entity
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        //navigation Property
        public ICollection<Product>? MyProperty { get; set; }
    }
}
