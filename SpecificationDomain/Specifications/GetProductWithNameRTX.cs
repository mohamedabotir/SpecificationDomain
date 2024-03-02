using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SpecificationDomain.Entities;
using SpecificationDomainKnowledge.Core;

namespace SpecificationDomain.Specifications
{
    public sealed class GetProductWithNameRTX:Specification<Product>
    {
        public override Expression<Predicate<Product>> GetPredicateAnatomy()
        {
            return product => product.Name.Contains("GTX");
        }
    }
}
