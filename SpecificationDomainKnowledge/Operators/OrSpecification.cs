using SpecificationDomainKnowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDomainKnowledge.Operators
{
    public sealed class OrSpecification<T>(
        Specification<T> _leftExpression,
        Specification<T> _rightExpression)
        : Specification<T>
    {
        public override Expression<Predicate<T>> GetPredicateAnatomy()
        {
            Expression<Predicate<T>> leftExpression = _leftExpression.GetPredicateAnatomy();
            Expression<Predicate<T>> rightExpression1 = _rightExpression.GetPredicateAnatomy();
            var invokedExpression = Expression.Invoke(rightExpression1, leftExpression.Parameters);

            BinaryExpression orBinaryExpression = Expression.OrElse(leftExpression.Body, invokedExpression);

            return Expression.Lambda<Predicate<T>>(orBinaryExpression, leftExpression.Parameters.Single());
        }
    }
}
