using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindServices.App.ServiceModel.Types;

namespace NorthwindServices.App.ServiceModel.Response
{
    public class ProductsByCategoryNameResponse
    {
        public IList<ProductDetailInfo> ProductDetails { get; set; }
    }
}
