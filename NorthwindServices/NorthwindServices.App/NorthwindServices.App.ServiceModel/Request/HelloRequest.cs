using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindServices.App.ServiceModel.Response;
using ServiceStack;

namespace NorthwindServices.App.ServiceModel.Request
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class HelloRequest : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

}
