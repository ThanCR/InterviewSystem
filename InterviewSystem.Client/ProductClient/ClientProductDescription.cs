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
    public class ClientProductDescription
    {
        public const string apiController = "ProductDescription";

        public static async void GetAllProductDescriptions()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync($"{Utilities.URLAPI}{apiController}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<List<ProductDescription>> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<List<ProductDescription>>>();

                        List<ProductDescription> result = jsonContent.Response;

                        result.ForEach(x =>
                        {
                            Console.WriteLine($"------ProductDescription information------\n" +
                                            $"IdDescription: {x.IdProductDescription}\n" +
                                            $"IdDescriptionType: {x.IdProductDescriptionType}\n" +
                                            $"Product: {x.ProductName}\n" +
                                            $"Aspect: {x.ProductDescriptionTypeName}\n" +
                                            $"Description: {x.ProductDescriptionName}\n");
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
        public static async void GetProductDescriptionById(int productDescriptionById)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(Utilities.URLAPI + apiController + $"/{productDescriptionById}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<ProductDescription> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<ProductDescription>>();

                        ProductDescription result = jsonContent.Response;
                        if (result.ProductDescriptionName != null)
                        {
                            Console.WriteLine($"------ProductDescription information------\n" +
                                            $"ID: {result.IdProductDescription}\n" +
                                            $"Product: {result.ProductName}\n" +
                                            $"Description: {result.ProductDescriptionName}\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No ProductDescription found");
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

        public static async void CreateProductDescription(ProductDescription productDescription)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProductDescription = productDescription.IdProductDescription,
                        productDescriptionName = productDescription.ProductDescriptionName
                    };

                    HttpResponseMessage httpResponseMessage 
                        = await client.PostAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescription created successfully!");
                        GetAllProductDescriptions();
                    }
                    else
                    {
                        Console.WriteLine("Could not create ProductDescription");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void UpdateProductDescription(ProductDescription productDescription)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProductDescription = productDescription.IdProductDescription,
                        productDescriptionName = productDescription.ProductDescriptionName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PutAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescription updated successfully!");
                        GetAllProductDescriptions();
                    }
                    else
                    {
                        Console.WriteLine("Could not update ProductDescription");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void DeleteProductDescription(int idProductDescription)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage httpResponseMessage
                        = await client.DeleteAsync(Utilities.URLAPI + apiController + $"/{idProductDescription}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("ProductDescription deleted successfully!");
                        GetAllProductDescriptions();
                    }
                    else
                    {
                        Console.WriteLine("Could not delete ProductDescription");
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
