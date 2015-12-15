using NorthwindServices.App.ServiceModel.Response;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindServices.App.ServiceModel.Request
{
    [Route("/ProductsByCategoryName")]
    [Route("/ProductsByCategoryName/{Name}")]
    public class ProductsByCategoryNameRequest : IReturn<ProductsByCategoryNameResponse>
    {
        public string Name { get; set; }
    }
}
