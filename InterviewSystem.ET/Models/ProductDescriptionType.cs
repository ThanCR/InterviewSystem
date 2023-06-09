namespace InterviewSystem.ET.Models
{
    //
    public class ProductDescriptionType
    {
        public int IdProductDescriptionType { get; set; }
        
        public string ProductDescriptionTypeName { get; set; }


        public ProductDescriptionType () { }
        public ProductDescriptionType(int idProductDescriptionType, string productDescriptionTypeName)
        {
            IdProductDescriptionType = idProductDescriptionType;
            ProductDescriptionTypeName = productDescriptionTypeName;
        }
    }
}
