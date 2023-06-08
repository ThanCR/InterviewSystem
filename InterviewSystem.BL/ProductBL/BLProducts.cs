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
                "Result found!",
                DSProduct.GetProductTypeById(idProductType));
        }
        public APIResponse<bool> DeleteProductType(int idProductType)
        {
            return new APIResponse<bool>(
                200,
                "Product removed!",
                DSProduct.DeleteProductType(idProductType));
        }
        public APIResponse<bool> RegisterProduct(Product product)
        {
            return new APIResponse<bool>(
                200,
                "Product registered!",
                DSProduct.RegisterProduct(product));
        }
        public APIResponse<bool> UpdateProduct(Product product)
        {
            return new APIResponse<bool>(
                200,
                "Product updated!",
                DSProduct.UpdateProduct(product));
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
        #endregion [Logicprocesses and validations]
    }
}
