using InterviewSystem.ET.Models;

namespace InterviewSystem.ET.ModelsCustom
{
    public class ProductDescriptionGroup
    {
        /// <summary>
        /// Contanins product's data.
        /// </summary>
        public Product ProductData { get; set; }
        /// <summary>
        /// Contanis a list of product's descriptions.
        /// </summary>
        public List<ProductDescription> ProductDescriptions { get; set; }
    }
}
