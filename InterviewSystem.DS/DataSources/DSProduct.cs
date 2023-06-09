
using InterviewSystem.ET.Models;

namespace InterviewSystem.DS.DataSources
{
    //Contains all the code related to Data interactions about Products, ListProducts, 
    public class DSProduct
    {
        #region [Static Object Lists]
        //created as private to avoid access from other layers, except DS itself
        private static List<ProductType> ListProductTypes { get; set; }
        private static List<Product> ListProducts { get; set; }
        private static List<ProductDescriptionType> ListProductDescriptionTypes { get; set; }
        private static List<ProductDescription> ListProductDescriptions { get; set; }
        #endregion [Static Object Lists]

        #region [Init]

        private static void InitiateAllLists()
        {
            InitProductTypeList();
            InitProductList();
            InitProductDescriptionTypeList();
            InitProductDescriptionList();
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductTypeList()
        {
            List<ProductType> InitialItemList = new List<ProductType>();
            //It is able to admit more types of products, not only drinks
            InitialItemList.Add(new ProductType(1, "Drinks"));
            ListProductTypes = ListProductTypes ?? InitialItemList;
            
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductList()
        {
            List<Product> InitialItemList = new List<Product>();
            InitialItemList.Add(new Product(1,1,"BudWeiser"));
            InitialItemList.Add(new Product(2,1, "Orange Juice"));
            InitialItemList.Add(new Product(3,1, "Pepsi"));
            ListProducts = ListProducts ?? InitialItemList;
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductDescriptionTypeList()
        {
            List<ProductDescriptionType> InitialItemList = new List<ProductDescriptionType>();
            InitialItemList.Add(new ProductDescriptionType(1, "Carbonation"));
            InitialItemList.Add(new ProductDescriptionType(2, "Alcohol content"));
            InitialItemList.Add(new ProductDescriptionType(3, "Fruit used"));
            ListProductDescriptionTypes = ListProductDescriptionTypes ?? InitialItemList;
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductDescriptionList()
        {
            List<ProductDescription> InitialItemList = new List<ProductDescription>();
            InitialItemList.Add(new ProductDescription(1,1,1, "Carbonated"));
            InitialItemList.Add(new ProductDescription(1, 1, 2, "5%"));
            InitialItemList.Add(new ProductDescription(2,2,3, "Made from oranges"));
            InitialItemList.Add(new ProductDescription(2, 2, 1, "Not Carbonated"));
            InitialItemList.Add(new ProductDescription(3,3,1, "Carbonated"));
            ListProductDescriptions = ListProductDescriptions ?? InitialItemList;
        }
        #endregion [End-Init]

        #region [Methods]

        #region [ProductType Process]
        public static bool RegisterProductType(ProductType productType)
        {
            InitiateAllLists();
            ListProductTypes.Add(productType);//Adds productType to existent list
            return true;
        }

        public static bool UpdateProductType(ProductType productType)
        {
            InitiateAllLists();
            ListProductTypes.Where(w => w.IdProductType == productType.IdProductType)
                            .ToList().ForEach(i =>
                            {
                                i.IdProductType = productType.IdProductType;
                                i.ProductTypeName = productType.ProductTypeName;
                            });
            return true;
        }

        public static bool DeleteProductType(int idProductType)
        {
            InitiateAllLists();
            ListProductTypes = ListProductTypes.Where(p => p.IdProductType != idProductType).ToList();
            return true;
        }

        public static ProductType GetProductTypeById(int idProductType)
        {
            InitiateAllLists();
            return ListProductTypes
                    .FirstOrDefault(p => p.IdProductType == idProductType) ?? new ProductType();
             
        }

        public static List<ProductType> GetAllProductTypes()
        {
            InitiateAllLists();
            return ListProductTypes;

        }

        #endregion [ProductType Process]

        #region [Product Process]
        public static bool RegisterProduct(Product product)
        {
            InitiateAllLists();
            ListProducts.Add(product);
            return true;
        }

        public static bool UpdateProduct(Product product)
        {
            InitiateAllLists();
            ListProducts.Where(w => w.IdProduct == product.IdProduct)
                            .ToList().ForEach(i =>
                            {
                                i.IdProduct = product.IdProduct;
                                i.ProductName = product.ProductName;
                            });
            return true;
        }

        public static bool DeleteProduct(int idProduct)
        {
            InitiateAllLists();
            ListProducts = ListProducts.Where(p => p.IdProduct != idProduct).ToList();
            return true;
        }

        public static Product GetProductById(int idProduct)
        {
            InitiateAllLists();
            return ListProducts
                    .FirstOrDefault(p => p.IdProduct == idProduct) ?? new Product();

        }

        public static List<Product> GetAllProducts()
        {
            InitiateAllLists();
            return ListProducts;

        }
        #endregion [Product Process]

        #region [ProductDescriptionType]
        public static bool RegisterProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            InitiateAllLists();
            ListProductDescriptionTypes.Add(productDescriptionType);
            return true;
        }

        public static bool UpdateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            InitiateAllLists();
            ListProductDescriptionTypes.Where(w => w.IdProductDescriptionType == productDescriptionType.IdProductDescriptionType)
                            .ToList().ForEach(i =>
                            {
                                i.IdProductDescriptionType = productDescriptionType.IdProductDescriptionType;
                                i.ProductDescriptionTypeName = productDescriptionType.ProductDescriptionTypeName;
                            });
            return true;
        }

        public static bool DeleteProductDescriptionType(int idProductDescriptionType)
        {
            InitiateAllLists();
            ListProductDescriptionTypes = ListProductDescriptionTypes
                .Where(p => p.IdProductDescriptionType != idProductDescriptionType).ToList();
            return true;
        }

        public static ProductDescriptionType GetProductDescriptionTypeById(int idProductDescriptionType)
        {
            InitiateAllLists();
            return ListProductDescriptionTypes
                    .FirstOrDefault(p => p.IdProductDescriptionType == idProductDescriptionType) ?? new ProductDescriptionType();

        }

        public static List<ProductDescriptionType> GetAllProductDescriptionTypes()
        {
            InitiateAllLists();
            return ListProductDescriptionTypes;

        }
        #endregion [ProductDescriptionType]

        #region [ProductDescription]
        public static bool RegisterProductDescription(ProductDescription productDescription)
        {
            InitiateAllLists();
            ListProductDescriptions.Add(productDescription);
            return true;
        }

        public static bool UpdateProductDescription(ProductDescription productDescription)
        {
            InitiateAllLists();
            ListProductDescriptions.Where(w => w.IdProductDescription == productDescription.IdProductDescription)
                            .ToList().ForEach(i =>
                            {
                                i.IdProductDescription = productDescription.IdProductDescription;
                                i.ProductDescriptionName = productDescription.ProductDescriptionName;
                            });
            return true;
        }

        public static bool DeleteProductDescription(int idProductDescription)
        {
            InitiateAllLists();
            ListProductDescriptions = ListProductDescriptions
                .Where(p => p.IdProductDescription != idProductDescription).ToList();
            return true;
        }

        public static ProductDescription GetProductDescriptionById(int idProductDescription)
        {
            InitiateAllLists();
            return ListProductDescriptions
                    .FirstOrDefault(p => p.IdProductDescription == idProductDescription) ?? new ProductDescription();

        }

        public static List<ProductDescription> GetAllProductDescriptions()
        {
            InitiateAllLists();
            return ListProductDescriptions;

        }
        #endregion [ProductDescription]

        #endregion [End-Methods]

    }
}
