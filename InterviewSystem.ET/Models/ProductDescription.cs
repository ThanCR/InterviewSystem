namespace InterviewSystem.ET.Models
{
    //Class for ProductDescription, inherits from Product to keep attributes comming from there
    public class ProductDescription :Product
    {
        public int IdProductDescription { get; set; }
        public string ProductDescriptionName { get; set; }
        public int IdProductDescriptionType { get; set; }
        public string ProductDescriptionTypeName { get; set; }

        public ProductDescription () { }

        public ProductDescription (int idProductDescription, int idProduct, int idProductDescriptionType, string? productDescriptionName)
        {
            IdProductDescription = idProductDescription;
            IdProduct = idProduct;
            ProductDescriptionName = productDescriptionName;
            IdProductDescriptionType = idProductDescriptionType;
        }
    }
}
