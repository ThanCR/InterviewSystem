using InterviewSystem.ET.Models;
using InterviewSystem.ET.ModelsCustom;

namespace InterviewSystem.BL.ProductBL
{
    public class BLProductQuery
    {
        BLProducts blProducts;
        public BLProductQuery()
        {
            blProducts = new BLProducts();
        }

        public APIResponse<ProductByTypeGroup> GetProductsByTypeName(string productTypeName)
        {
            ProductByTypeGroup dataResult = new ProductByTypeGroup { ProductsDescriptionsGroup = new List<ProductDescriptionGroup>()};

            try
            {
                //Get Product Type.
                ProductType? productType = blProducts.GetProductTypes().Response.FirstOrDefault(x => (x.ProductTypeName ?? string.Empty).ToLower()
                                                                                                       .Contains(productTypeName.ToLower()));

                if (productType != null)
                {
                    dataResult.ProductTypeData = productType;

                    //Get Products about type.
                    List<Product> products = blProducts.GetProducts().Response.Where(x => x.IdProductType == productType.IdProductType).ToList();

                    //Get Products descriptions with types
                    if (products.Count > 0)
                    {
                        //Get catalog productDescriptionsTypes
                        List<ProductDescriptionType> productDescriptionsTypes = blProducts.GetProductDescriptionTypes().Response;

                        //Completing the products and your descriptions.
                        foreach (var product in products)
                        {
                            //Get product's descriptions
                            List<ProductDescription> productDescriptions = blProducts.GetProductDescriptions().Response.Where(x => x.IdProduct == product.IdProduct).ToList();

                            //Get product's descriptions type
                            var productDescriptionsCompleted = productDescriptions
                               .Join(productDescriptionsTypes,
                                     description => description.IdProductDescriptionType,
                                     descriptionType => descriptionType.IdProductDescriptionType,
                                     (descriptions, descriptionsType) => new { Descriptions = descriptions, DescriptionsType = descriptionsType })
                               .Select((descriptions, key) => new ProductDescription()
                               {
                                   IdProductDescriptionType = key,
                                   ProductDescriptionTypeName = descriptions.DescriptionsType.ProductDescriptionTypeName,
                                   IdProductDescription = descriptions.Descriptions.IdProductDescription,
                                   ProductDescriptionName = descriptions.Descriptions.ProductDescriptionName
                               }).ToList();


                            ProductDescriptionGroup productGroup = new ProductDescriptionGroup
                            {
                                ProductData = product,
                                ProductDescriptions = productDescriptionsCompleted,
                            };
                            dataResult.ProductsDescriptionsGroup.Add(productGroup);
                        }
                        return new APIResponse<ProductByTypeGroup>(200, "Products found!!", dataResult);
                    }
                }

                return new APIResponse<ProductByTypeGroup>(200, "Not found products for this type!", new ProductByTypeGroup());
            }
            catch (Exception ex)
            {
                return new APIResponse<ProductByTypeGroup>(
                    500,
                    "An internal server error has ocurred when getting all product types ",
                    new ProductByTypeGroup()
                    );
            }
        }
    }
}
