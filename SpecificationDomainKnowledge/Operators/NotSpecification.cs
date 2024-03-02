using SpecificationDomainKnowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDomainKnowledge.Operators
{
    public sealed class NotSpecification<T>(
        Specification<T> expression) : Specification<T>
    {
        public override Expression<Predicate<T>> GetPredicateAnatomy()
        {
            Expression<Predicate<T>> _expression = expression.GetPredicateAnatomy();
 
            UnaryExpression  notExpressionOperator = Expression.Not(_expression.Body);

            return Expression.Lambda<Predicate<T>>(notExpressionOperator, _expression.Parameters.Single());
        }
    }
}
