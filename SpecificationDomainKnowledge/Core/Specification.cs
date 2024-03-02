using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SpecificationDomainKnowledge.Operators;

namespace SpecificationDomainKnowledge.Core
{
    public abstract class Specification<T>
    {
      public  bool IsSatisfiedBy(T entity)
        {
            Predicate<T> predicate = GetPredicateAnatomy().Compile();

            return predicate(entity);
        }

        public Specification<T> And(Specification<T> spec)
        {
            return new AndSpecification<T>(this, spec);
        } 
        public Specification<T> Or(Specification<T> spec)
        {
            return new OrSpecification<T>(this, spec);
        }
        public Specification<T> Not(Specification<T> spec)
        {
            return new NotSpecification<T>(this);
        }

        public abstract Expression<Predicate<T>> GetPredicateAnatomy();
    }
}
