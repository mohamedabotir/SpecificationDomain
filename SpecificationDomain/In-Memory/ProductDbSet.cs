using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecificationDomain.Entities;

namespace SpecificationDomain.In_Memory
{
    public static class ProductDbSet
    {
       private  static readonly List<Product> _products =
        [
            new Product()
            {
                Id = 1,
                Name ="RTX 3050",
                Price =5000,
                OwnerId =1,
                Quantity =14,
                IsActive =true
            },
            new Product()
            {
                Id = 20,
                Name ="RTX 3050",
                Price =5000,
                OwnerId =4,
                Quantity =0,
                IsActive =true
            }
            ,  new Product()
            {
                Id = 2,
                Name ="GTX 1650",
                Price =240,
                OwnerId =3,
                Quantity =0,
                IsActive =true
            },  new Product()
            {
                Id = 1,
                Name ="RTX 4050",
                Price =8000,
                OwnerId =1,
                Quantity =4,
                IsActive =true
            },  new Product()
            {
                Id = 1,
                Name ="RX 6500XT",
                Price =4000,
                OwnerId =3,
                Quantity =10,
                IsActive =true
            },  new Product()
            {
                Id = 1,
                Name ="GTX 1050TI",
                Price =1500,
                OwnerId =1,
                Quantity =20,
                IsActive =true
            },  new Product()
            {
                Id = 1,
                Name ="RX 550",
                Price =1000,
                OwnerId =3,
                Quantity =20,
                IsActive =false
            }
        ];

        public static IReadOnlyCollection<Product> Products => _products;
    }
}
