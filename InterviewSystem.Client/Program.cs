


using InterviewSystem.Client.ProductClient;
using InterviewSystem.Client.Util;
using InterviewSystem.ET.Models;

bool iterate = true;

    while (iterate)
{
    Console.WriteLine("\nPlease insert the number related to the data you want to consume" +
    "\n1.Display all current products and their descriptions" +
    "\n2.ProductType" +
    "\n3.Product" +
    "\n4.ProductDescriptionType" +
    "\n5.ProductDescription" +
    "\n6.Custom Queries" +
    "\n7.Exit");
    string option = Console.ReadLine() ?? "1";

    switch (option)
    {
        case "1":
            Utilities.GetProductsSummary();
            Console.ReadLine();
            break;
        case "2":
            ProductType productType = new ProductType();
            switch (Utilities.AskForSelection(1))
            {
                case "1":
                    ClientProductType.GetAllProductTypes();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\nInsert ProductTypeId");
                    int idProductType = int.Parse(Console.ReadLine());
                    ClientProductType.GetProductTypeById(idProductType);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("\nInsert Id");
                    productType.IdProductType = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productType.ProductTypeName = Console.ReadLine();
                    ClientProductType.CreateProductType(productType);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("\nInsert Id");
                    productType.IdProductType = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productType.ProductTypeName = Console.ReadLine();
                    ClientProductType.UpdateProductType(productType);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\nInsert Id");
                    ClientProductType.DeleteProductType(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        case "3":
            Product product = new Product();
            switch (Utilities.AskForSelection(1))
            {
                case "1":
                    ClientProduct.GetAllProducts();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\nInsert ProductId");
                    int idProduct = int.Parse(Console.ReadLine());
                    ClientProduct.GetProductById(idProduct);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("\nInsert Id");
                    product.IdProduct = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    product.ProductName = Console.ReadLine();
                    ClientProduct.CreateProduct(product);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("\nInsert Id");
                    product.IdProduct = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    product.ProductName = Console.ReadLine();
                    ClientProduct.UpdateProduct(product);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\nInsert Id");
                    ClientProduct.DeleteProduct(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

            break;
        case "4":
            ProductDescriptionType productDescriptionType = new ProductDescriptionType();
            switch (Utilities.AskForSelection(1))
            {
                case "1":
                    ClientProductDescriptionType.GetAllProductDescriptionTypes();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\nInsert ProductDescriptionTypeId");
                    int idProductDescriptionType = int.Parse(Console.ReadLine());
                    ClientProductDescriptionType.GetProductDescriptionTypeById(idProductDescriptionType);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("\nInsert Id");
                    productDescriptionType.IdProductDescriptionType = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productDescriptionType.ProductDescriptionTypeName = Console.ReadLine();
                    ClientProductDescriptionType.CreateProductDescriptionType(productDescriptionType);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("\nInsert Id");
                    productDescriptionType.IdProductDescriptionType = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productDescriptionType.ProductDescriptionTypeName = Console.ReadLine();
                    ClientProductDescriptionType.UpdateProductDescriptionType(productDescriptionType);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\nInsert Id");
                    ClientProductDescriptionType.DeleteProductDescriptionType(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        case "5":
            ProductDescription productDescription = new ProductDescription();
            switch (Utilities.AskForSelection(1))
            {
                case "1":
                    ClientProductDescription.GetAllProductDescriptions();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("\nInsert ProductDescriptionId");
                    int idProductDescription = int.Parse(Console.ReadLine());
                    ClientProductDescription.GetProductDescriptionById(idProductDescription);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("\nInsert Id");
                    productDescription.IdProductDescription = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productDescription.ProductDescriptionName = Console.ReadLine();
                    ClientProductDescription.CreateProductDescription(productDescription);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("\nInsert Id");
                    productDescription.IdProductDescription = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInsert Name");
                    productDescription.ProductDescriptionName = Console.ReadLine();
                    ClientProductDescription.UpdateProductDescription(productDescription);
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\nInsert Id");
                    ClientProductDescription.DeleteProductDescription(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        case "6":
            
            switch(Utilities.AskForSelection(2))
            {
                case "1":
                    Console.WriteLine("Please insert the type of the product you want to search");
                    string type = Console.ReadLine();
                    Utilities.GetProductsByTypeName(type);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You have inserted an invalid value!");
                    break;
            }
            break;
        case "7":
            iterate = false;
            break;
        default:
            break;
    }

}