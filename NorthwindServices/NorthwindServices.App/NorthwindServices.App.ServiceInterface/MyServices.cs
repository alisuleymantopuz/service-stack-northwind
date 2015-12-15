using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindServices.App.ServiceModel.Request;
using NorthwindServices.App.ServiceModel.Response;
using NorthwindServices.App.ServiceModel.Types;
using NorthwindServices.Orm;
using ServiceStack;
using NorthwindServices.App.ServiceModel;

namespace NorthwindServices.App.ServiceInterface
{
    public class MyServices : Service
    {
        public static NorthwindEntities NorthwindDataContext = new NorthwindEntities();

        public object Any(HelloRequest request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Any(ProductsByCategoryNameRequest request)
        {


            var categoryName = request.Name;

            var products =
                NorthwindDataContext.Products.Where(
                    x => x.Category != null && x.Category.CategoryName.ToLower().Contains(categoryName.ToLower()));

            var productsByCategoryNameResponse = new ProductsByCategoryNameResponse
            {
                ProductDetails = new List<ProductDetailInfo>()
            };

            if (!products.Any()) return productsByCategoryNameResponse;


            foreach (var product in products)
            {
                productsByCategoryNameResponse.ProductDetails.Add(new ProductDetailInfo()
                {
                    CategoryInfo = new CategoryInfo()
                    {
                        Id = product.Category.CategoryID,
                        Name = product.Category.CategoryName
                    },
                    Id = product.ProductID,
                    Name = product.ProductName,
                    UnitPrice = product.UnitPrice
                });
            }

            return productsByCategoryNameResponse;
        }

    }
}