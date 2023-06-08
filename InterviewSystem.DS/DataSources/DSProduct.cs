
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

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductTypeList()
        {
            ListProductTypes = ListProductTypes ?? new List<ProductType>();
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductList()
        {
            ListProducts = ListProducts ?? new List<Product>();
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductDescriptionTypeList()
        {
            ListProductDescriptionTypes = ListProductDescriptionTypes ?? new List<ProductDescriptionType>();
        }

        /// <summary>
        /// Avoids null exceptions due to null List or object.
        /// </summary>
        private static void InitProductDescriptionList()
        {
            ListProductDescriptions = ListProductDescriptions ?? new List<ProductDescription>();
        }
        #endregion [End-Init]

        #region [Methods]

        #region [ProductType Process]
        public static bool RegisterProductType(ProductType productType)
        {
            InitProductTypeList();
            ListProductTypes.Add(productType);//Adds productType to existent list
            return true;
        }

        public static bool UpdateProductType(ProductType productType)
        {
            InitProductTypeList();
            ListProductTypes.Where(w => w.IdProductType == productType.IdProductType)
                            .ToList().ForEach(i => i = productType);
            return true;
        }

        public static bool DeleteProductType(int idProductType)
        {
            InitProductTypeList() ;
            ListProductTypes = ListProductTypes.Where(p => p.IdProductType != idProductType).ToList();
            return true;
        }

        public static ProductType GetProductTypeById(int idProductType)
        {
            InitProductTypeList();
            return ListProductTypes
                    .FirstOrDefault(p => p.IdProductType == idProductType) ?? new ProductType();
             
        }

        public static List<ProductType> GetAllProductTypes()
        {
            InitProductTypeList();
            return ListProductTypes;

        }

        #endregion [ProductType Process]

        #region [Product Process]
        public static bool RegisterProduct(Product product)
        {
            InitProductList();
            ListProducts.Add(product);
            return true;
        }

        public static bool UpdateProduct(Product product)
        {
            InitProductList();
            ListProducts.Where(w => w.IdProduct == product.IdProduct)
                            .ToList().ForEach(i => i = product);
            return true;
        }

        public static bool DeleteProduct(int idProduct)
        {
            InitProductList();
            ListProducts = ListProducts.Where(p => p.IdProduct != idProduct).ToList();
            return true;
        }

        public static Product GetProductById(int idProduct)
        {
            InitProductTypeList();
            return ListProducts
                    .FirstOrDefault(p => p.IdProduct == idProduct) ?? new Product();

        }

        public static List<Product> GetAllProduct()
        {
            InitProductList();
            return ListProducts;

        }
        #endregion [Product Process]

        #region [ProductDescriptionType]
        public static bool RegisterProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            InitProductDescriptionTypeList();
            ListProductDescriptionTypes.Add(productDescriptionType);
            return true;
        }

        public static bool UpdateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            InitProductDescriptionList();
            ListProductDescriptionTypes.Where(w => w.IdProductDescriptionType == productDescriptionType.IdProductDescriptionType)
                            .ToList().ForEach(i => i = productDescriptionType);
            return true;
        }

        public static bool DeleteProductDescriptionType(int idProductDescriptionType)
        {
            InitProductDescriptionTypeList();
            ListProductDescriptionTypes = ListProductDescriptionTypes
                .Where(p => p.IdProductDescriptionType != idProductDescriptionType).ToList();
            return true;
        }

        public static ProductDescriptionType GetProductDescriptionTypeById(int idProductDescriptionType)
        {
            InitProductDescriptionTypeList();
            return ListProductDescriptionTypes
                    .FirstOrDefault(p => p.IdProductDescriptionType == idProductDescriptionType) ?? new ProductDescriptionType();

        }

        public static List<ProductDescriptionType> GetAllProductDescriptionType()
        {
            InitProductDescriptionTypeList();
            return ListProductDescriptionTypes;

        }
        #endregion [ProductDescriptionType]

        #region [ProductDescription]
        public static bool RegisterProductDescription(ProductDescription productDescription)
        {
            InitProductDescriptionList();
            ListProductDescriptions.Add(productDescription);
            return true;
        }

        public static bool UpdateProductDescription(ProductDescription productDescription)
        {
            InitProductDescriptionList();
            ListProductDescriptions.Where(w => w.IdProductDescription == productDescription.IdProductDescription)
                            .ToList().ForEach(i => i = productDescription);
            return true;
        }

        public static bool DeleteProductDescription(int idProductDescription)
        {
            InitProductDescriptionList();
            ListProductDescriptions = ListProductDescriptions
                .Where(p => p.IdProductDescription != idProductDescription).ToList();
            return true;
        }

        public static ProductDescription GetProductDescriptionById(int idProductDescription)
        {
            InitProductDescriptionList();
            return ListProductDescriptions
                    .FirstOrDefault(p => p.IdProductDescription == idProductDescription) ?? new ProductDescription();

        }

        public static List<ProductDescription> GetAllProductDescription()
        {
            InitProductDescriptionList();
            return ListProductDescriptions;

        }
        #endregion [ProductDescription]

        #endregion [End-Methods]

    }
}
