using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSystem.ET.Models
{
    //base class for Product class
    public class ProductType
    {
        //Attributes
        public int IdProductType { get; set; }
        public string? ProductTypeName { get; set; }

        #region [constructors]

        public ProductType() { }
        public ProductType(int idProductType, string? productTypeName)
        {
            IdProductType = idProductType;
            ProductTypeName = productTypeName;
        }
        #endregion [constructors
    }
}
