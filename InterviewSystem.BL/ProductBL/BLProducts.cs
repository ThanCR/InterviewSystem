using InterviewSystem.DS.DataSources;
using InterviewSystem.ET.Models;

namespace InterviewSystem.BL.ProductBL
{
    public class BLProducts
    {
        #region [Logic processes and validations]
        #region [ProductType]
        public APIResponse<List<ProductType>> GetProductTypes()
        {
            return new APIResponse<List<ProductType>>(
                200,
                "Results found!",
                DSProduct.GetAllProductTypes());
        }
        public APIResponse<ProductType> GetProductTypeById(int idProductType)
        {
            return new APIResponse<ProductType>(
                200,
                "ProductType found!",
                DSProduct.GetProductTypeById(idProductType));
        }
        public APIResponse<bool> DeleteProductType(int idProductType)
        {
            return new APIResponse<bool>(
                200,
                "ProductType removed!",
                DSProduct.DeleteProductType(idProductType));
        }
        public APIResponse<bool> RegisterProductType(ProductType productType)
        {
            return new APIResponse<bool>(
                200,
                "ProductType registered!",
                DSProduct.RegisterProductType(productType));
        }
        public APIResponse<bool> UpdateProductType(ProductType productType)
        {
            return new APIResponse<bool>(
                200,
                "ProductType updated!",
                DSProduct.UpdateProductType(productType));
        }
        #endregion [ProductType]
        #region [Product]
        public APIResponse<List<Product>> GetProducts()
        {
            return new APIResponse<List<Product>>(
                200,
                "Results found!",
                DSProduct.GetAllProducts());
        }
        public APIResponse<Product> GetProductById(int idProduct)
        {
            return new APIResponse<Product>(
                200,
                "Result found!",
                DSProduct.GetProductById(idProduct));
        }
        public APIResponse<bool> DeleteProduct(int idProduct)
        {
            return new APIResponse<bool>(
                200,
                "Product removed!",
                DSProduct.DeleteProduct(idProduct));
        }
        public APIResponse<bool> RegisterProduct(Product product)
        {
            return new APIResponse<bool>(
                200,
                "Product registered!",
                DSProduct.RegisterProduct(product));
        }
        public APIResponse <bool> UpdateProduct(Product product)
        {
            return new APIResponse<bool>(
                200,
                "Product updated!",
                DSProduct.UpdateProduct(product));
        }
        #endregion [Product]
        #region [ProductDescriptionType]
        public APIResponse<List<ProductDescriptionType>> GetProductDescriptionTypes()
        {
            return new APIResponse<List<ProductDescriptionType>>(
                200,
                "Results found!",
                DSProduct.GetAllProductDescriptionTypes());
        }
        public APIResponse<ProductDescriptionType> GetProductDescriptionTypeById(int idProductDescriptionType)
        {
            return new APIResponse<ProductDescriptionType>(
                200,
                "Result found!",
                DSProduct.GetProductDescriptionTypeById(idProductDescriptionType));
        }
        public APIResponse<bool> DeleteProductDescriptionType(int idProductDescriptionType)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescriptionType removed!",
                DSProduct.DeleteProductDescriptionType(idProductDescriptionType));
        }
        public APIResponse<bool> RegisterProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescriptionType registered!",
                DSProduct.RegisterProductDescriptionType(productDescriptionType));
        }
        public APIResponse<bool> UpdateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescriptionType updated!",
                DSProduct.UpdateProductDescriptionType(productDescriptionType));
        }
        #endregion [ProductDescriptionType]
        #region [ProductDescription]
        public APIResponse<List<ProductDescription>> GetProductDescriptions()
        {
            return new APIResponse<List<ProductDescription>>(
                200,
                "Results found!",
                DSProduct.GetAllProductDescriptions());
        }
        public APIResponse<ProductDescription> GetProductDescriptionById(int idProductDescription)
        {
            return new APIResponse<ProductDescription>(
                200,
                "Result found!",
                DSProduct.GetProductDescriptionById(idProductDescription));
        }
        public APIResponse<bool> DeleteProductDescription(int idProductDescription)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescription removed!",
                DSProduct.DeleteProductDescription(idProductDescription));
        }
        public APIResponse<bool> RegisterProductDescription(ProductDescription productDescription)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescription registered!",
                DSProduct.RegisterProductDescription(productDescription));
        }
        public APIResponse<bool> UpdateProductDescription(ProductDescription productDescription)
        {
            return new APIResponse<bool>(
                200,
                "ProductDescription updated!",
                DSProduct.RegisterProductDescription(productDescription));
        }
        #endregion [ProductDescription]
        #endregion [Logicprocesses and validations]
    }
}
