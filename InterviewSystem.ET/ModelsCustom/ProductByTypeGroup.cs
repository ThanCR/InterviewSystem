using InterviewSystem.ET.Models;

namespace InterviewSystem.ET.ModelsCustom
{
    public class ProductByTypeGroup
    {
        /// <summary>
        /// Constains product's type.
        /// </summary>
        public ProductType ProductTypeData { get; set; }

        /// <summary>
        /// Contanis a list of product's descriptions.
        /// </summary>
        public List<ProductDescriptionGroup> ProductsDescriptionsGroup { get; set; }
    }
}
