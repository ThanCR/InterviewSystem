namespace InterviewSystem.ET.Models
{
    //Class for ProductDescription, inherits from Product to keep attributes comming from there
    public class ProductDescription :Product
    {
        public int IdProductDescription { get; set; }
        public string ?ProductDescriptionName { get; set; }
        public int IdProductDescriptionType { get; set; }
        public string ProductDescriptionTypeName { get; set; }
    }
}
