using InterviewSystem.Client.Util;
using InterviewSystem.ET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSystem.Client.ProductClient
{
    public class ClientProductType
    {
        public const string apiController = "ProductType";

        public static async void GetAllProductTypes()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync($"{Utilities.URLAPI}{apiController}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<List<ProductType>> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<List<ProductType>>>();

                        List<ProductType> result = jsonContent.Response;

                        result.ForEach(x =>
                        {
                            Console.WriteLine($"------ProductType information------\n" +
                                            $"ID: {x.IdProductType}\n" +
                                            $"Name: {x.ProductTypeName}\n");
                        });

                    }
                    else
                    {
                        Console.WriteLine($"An error has ocurred when consuming {apiController} endpoint");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public static async void GetProductTypeById(int productTypeById)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(Utilities.URLAPI + apiController + $"/{productTypeById}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<ProductType> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<ProductType>>();

                        ProductType result = jsonContent.Response;
                        if (result.ProductTypeName != null)
                        {
                            Console.WriteLine($"------ProductType information------\n" +
                                            $"ID: {result.IdProductType}\n" +
                                            $"Name: {result.ProductTypeName}\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No ProductType found");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"An error has ocurred when consuming {apiController} endpoint");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void CreateProductType(ProductType productType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new {idProductType = productType.IdProductType, productTypeName = productType.ProductTypeName};

                    HttpResponseMessage httpResponseMessage 
                        = await client.PostAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductType created successfully!");
                        GetAllProductTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not create ProductType");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void UpdateProductType(ProductType productType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProductType = productType.IdProductType, productTypeName = productType.ProductTypeName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PutAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductType updated successfully!");
                        GetAllProductTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not update ProductType");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void DeleteProductType(int idProductType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage httpResponseMessage
                        = await client.DeleteAsync(Utilities.URLAPI + apiController + $"/{idProductType}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductType deleted successfully!");
                        GetAllProductTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not delete ProductType");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }





    }
}
