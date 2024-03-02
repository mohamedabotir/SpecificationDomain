using SpecificationDomain.In_Memory;
using SpecificationDomain.Specifications;

//var getActiveProductsInStoreOne = ProductDbSet.Products
//    .Where(e=>e is {Quantity:<=0,IsActive:true}).ToList();
var getActiveProductsInStoreOneWithSpec = ProductDbSet.Products
    .Where(new GetProductOutOfStockAndActiveSpec().And(new GetProductWithNameRTX()).IsSatisfiedBy)
    .ToList();

foreach (var product in getActiveProductsInStoreOneWithSpec)
{
    Console.WriteLine(product.ToString());
}