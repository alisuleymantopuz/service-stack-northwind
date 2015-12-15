using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindServices.App.ServiceModel.Types
{
    [DataContract]
    public class ProductDetailInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public CategoryInfo CategoryInfo { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }
    }
}
