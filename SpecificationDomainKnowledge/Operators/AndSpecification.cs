using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SpecificationDomainKnowledge.Core;

namespace SpecificationDomainKnowledge.Operators
{
    public sealed class AndSpecification<T>(
        Specification<T> _leftExpression,
        Specification<T> _rightExpression)
        : Specification<T>
    {
        public override Expression<Predicate<T>> GetPredicateAnatomy()
        {

            Expression<Predicate<T>> leftExpression = _leftExpression.GetPredicateAnatomy();
            Expression<Predicate<T>> rightExpression = _rightExpression.GetPredicateAnatomy();

            var invokedExpression = Expression.Invoke(rightExpression, leftExpression.Parameters);
            BinaryExpression andOperatorExpression = Expression.AndAlso(leftExpression.Body, invokedExpression);

            return Expression.Lambda<Predicate<T>>(andOperatorExpression, leftExpression.Parameters.Single());
        }
    }
}
