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
    public class ClientProductDescriptionType
    {
        public const string apiController = "ProductDescriptionType";

        public static async void GetAllProductDescriptionTypes()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync($"{Utilities.URLAPI}{apiController}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<List<ProductDescriptionType>> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<List<ProductDescriptionType>>>();

                        List<ProductDescriptionType> result = jsonContent.Response;

                        result.ForEach(x =>
                        {
                            Console.WriteLine($"------ProductDescriptionType information------\n" +
                                            $"ID: {x.IdProductDescriptionType}\n" +
                                            $"Name: {x.ProductDescriptionTypeName}\n");
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
        public static async void GetProductDescriptionTypeById(int productDescriptionTypeById)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(Utilities.URLAPI + apiController + $"/{productDescriptionTypeById}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<ProductDescriptionType> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<ProductDescriptionType>>();

                        ProductDescriptionType result = jsonContent.Response;
                        if (result.ProductDescriptionTypeName != null)
                        {
                            Console.WriteLine($"------ProductDescriptionType information------\n" +
                                            $"ID: {result.IdProductDescriptionType}\n" +
                                            $"Name: {result.ProductDescriptionTypeName}\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No ProductDescriptionType found");
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

        public static async void CreateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProductDescriptionType = productDescriptionType.IdProductDescriptionType, productDescriptionTypeName = productDescriptionType.ProductDescriptionTypeName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PostAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescriptionType created successfully!");
                        GetAllProductDescriptionTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not create Product");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void UpdateProductDescriptionType(ProductDescriptionType productDescriptionType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProductDescriptionType = productDescriptionType.IdProductDescriptionType,
                        productDescriptionTypeName = productDescriptionType.ProductDescriptionTypeName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PutAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescriptionType updated successfully!");
                        GetAllProductDescriptionTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not update ProductDescriptionType");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void DeleteProductDescriptionType(int idProductDescriptionType)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage httpResponseMessage
                        = await client.DeleteAsync(Utilities.URLAPI + apiController + $"/{idProductDescriptionType}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescriptionType deleted successfully!");
                        GetAllProductDescriptionTypes();
                    }
                    else
                    {
                        Console.WriteLine("Could not delete ProductDescriptionType");
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
