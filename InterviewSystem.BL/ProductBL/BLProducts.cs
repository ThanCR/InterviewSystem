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
            try
            {

            return new APIResponse<List<ProductType>>(
                200,
                "Results found!",
                DSProduct.GetAllProductTypes());
            }catch(Exception ex)
            {
                return new APIResponse<List<ProductType>>(
                    500,
                    "An internal server error has ocurred when getting all product types ",
                    new List<ProductType>()
                    );
            }
        }
        public APIResponse<ProductType> GetProductTypeById(int idProductType)
        {
            try
            {

            return new APIResponse<ProductType>(
                200,
                "ProductType found!",
                DSProduct.GetProductTypeById(idProductType));
            }
            catch (Exception ex)
            {
                return new APIResponse<ProductType>(
                    500,
                    "An internal server error has ocurred when getting an specific product type",
                    new ProductType()
                    );
            }
        }
        public APIResponse<bool> DeleteProductType(int idProductType)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductType removed!",
                DSProduct.DeleteProductType(idProductType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when deleting product type ",
                    false
                    );
            }
        }
        public APIResponse<bool> RegisterProductType(ProductType productType)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductType registered!",
                DSProduct.RegisterProductType(productType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when registering product type",
                    false
                    );
            }
        }
        public APIResponse<bool> UpdateProductType(ProductType productType)
        {
            try
            {
                return new APIResponse<bool>(
                200,
                "ProductType updated!",
                DSProduct.UpdateProductType(productType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    $"An internal server error has ocurred when updating product type",
                    false
                    );
            }
        }
        #endregion [ProductType]
        #region [Product]
        public APIResponse<List<Product>> GetProducts()
        {
            try
            {

            return new APIResponse<List<Product>>(
                200,
                "Results found!",
                DSProduct.GetAllProducts());
            }
            catch (Exception ex)
            {
                return new APIResponse<List<Product>>(
                    500,
                    "An internal server error has ocurred when getting products ",
                    new List<Product>()
                    );
            }
        }
        public APIResponse<Product> GetProductById(int idProduct)
        {
            try
            {
            return new APIResponse<Product>(
                200,
                "Result found!",
                DSProduct.GetProductById(idProduct));
            }
            catch (Exception ex)
            {
                return new APIResponse<Product>(
                    500,
                    "An internal server error has ocurred when getting product ",
                    new Product()
                    );
            }
        }
        public APIResponse<bool> DeleteProduct(int idProduct)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "Product removed!",
                DSProduct.DeleteProduct(idProduct));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when getting product ",
                    false
                    );
            }
        }
        public APIResponse<bool> RegisterProduct(Product product)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "Product registered!",
                DSProduct.RegisterProduct(product));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when registering product",
                    false
                    );
            }
        }
        public APIResponse <bool> UpdateProduct(Product product)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "Product updated!",
                DSProduct.UpdateProduct(product));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when getting products ",
                    false
                    );
            }
        }
        #endregion [Product]
        #region [ProductDescriptionType]
        public APIResponse<List<ProductDescriptionType>> GetProductDescriptionTypes()
        {
            try
            {

            return new APIResponse<List<ProductDescriptionType>>(
                200,
                "Results found!",
                DSProduct.GetAllProductDescriptionTypes());
            }
            catch (Exception ex)
            {
                return new APIResponse<List<ProductDescriptionType>>(
                    500,
                    "An internal server error has ocurred when getting all ProductDescriptionType",
                    new List<ProductDescriptionType>()
                    );
            }
        }
        public APIResponse<ProductDescriptionType> GetProductDescriptionTypeById(int idProductDescriptionType)
        {
            try
            {

            return new APIResponse<ProductDescriptionType>(
                200,
                "Result found!",
                DSProduct.GetProductDescriptionTypeById(idProductDescriptionType));
            }
            catch (Exception ex)
            {
                return new APIResponse<ProductDescriptionType>(
                    500,
                    "An internal server error has ocurred when getting ProductDescriptionType ",
                    new ProductDescriptionType()
                    );
            }
        }
        public APIResponse<bool> DeleteProductDescriptionType(int idProductDescriptionType)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductDescriptionType removed!",
                DSProduct.DeleteProductDescriptionType(idProductDescriptionType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when getting products ",
                    false
                    );
            }
        }
        public APIResponse<bool> RegisterProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductDescriptionType registered!",
                DSProduct.RegisterProductDescriptionType(productDescriptionType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when getting products ",
                    false
                    );
            }
        }
        public APIResponse<bool> UpdateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductDescriptionType updated!",
                DSProduct.UpdateProductDescriptionType(productDescriptionType));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when getting products ",
                    false
                    );
            }
        }
        #endregion [ProductDescriptionType]
        #region [ProductDescription]
        public APIResponse<List<ProductDescription>> GetProductDescriptions()
        {
            try
            {

            List<ProductDescription> products = new List<ProductDescription>(DSProduct.GetAllProductDescriptions());
            products.ForEach(p =>
            {
                p.ProductName = DSProduct.GetProductById(p.IdProduct).ProductName;
                p.ProductDescriptionTypeName = DSProduct.GetProductDescriptionTypeById(p.IdProductDescriptionType).ProductDescriptionTypeName;
            });

            return new APIResponse<List<ProductDescription>>(
                200,
                "Results found!",
                products);
            }
            catch (Exception ex)
            {
                return new APIResponse<List<ProductDescription>>(
                    500,
                    "An internal server error has ocurred when getting all ProductDescriptions ",
                    new List<ProductDescription>()
                    );
            }
        }
        public APIResponse<ProductDescription> GetProductDescriptionById(int idProductDescription)
        {
            try
            {

            return new APIResponse<ProductDescription>(
                200,
                "Result found!",
                DSProduct.GetProductDescriptionById(idProductDescription));
            }
            catch (Exception ex)
            {
                return new APIResponse<ProductDescription>(
                    500,
                    "An internal server error has ocurred when getting specific ProductDescription",
                    new ProductDescription()
                    );
            }
        }
        public APIResponse<bool> DeleteProductDescription(int idProductDescription)
        {
            try
            {

            return new APIResponse<bool>(
                200,
                "ProductDescription removed!",
                DSProduct.DeleteProductDescription(idProductDescription));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when deleting productsDescription ",
                    false
                    );
            }
        }
        public APIResponse<bool> RegisterProductDescription(ProductDescription productDescription)
        {
            try
            {
                return new APIResponse<bool>(
                200,
                "ProductDescription registered!",
                DSProduct.RegisterProductDescription(productDescription));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when creting ProductDescription",
                    false
                    );
            }
        }
        public APIResponse<bool> UpdateProductDescription(ProductDescription productDescription)
        {
            try
            {
                return new APIResponse<bool>(
                200,
                "ProductDescription updated!",
                DSProduct.RegisterProductDescription(productDescription));
            }
            catch (Exception ex)
            {
                return new APIResponse<bool>(
                    500,
                    "An internal server error has ocurred when updating ProductDescription",
                    false
                    );
            }
        }
        #endregion [ProductDescription]
        #endregion [Logicprocesses and validations]
    }
}
