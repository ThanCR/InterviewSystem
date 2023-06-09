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
    public class ClientProduct
    {
        public const string apiController = "Product";

        public static async void GetAllProducts()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync($"{Utilities.URLAPI}{apiController}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<List<Product>> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<List<Product>>>();

                        List<Product> result = jsonContent.Response;

                        result.ForEach(x =>
                        {
                            Console.WriteLine($"------Product information------\n" +
                                            $"ID: {x.IdProduct}\n" +
                                            $"Name: {x.ProductName}\n");
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
        public static async void GetProductById(int productById)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(Utilities.URLAPI + apiController + $"/{productById}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        APIResponse<Product> jsonContent =
                            await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<Product>>();

                        Product result = jsonContent.Response;
                        if (result.ProductName != null)
                        {
                            Console.WriteLine($"------Product information------\n" +
                                            $"ID: {result.IdProduct}\n" +
                                            $"Name: {result.ProductName}\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No Product found");
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

        public static async void CreateProduct(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProduct = product.IdProduct, productName = product.ProductName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PostAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Product created successfully!");
                        GetAllProducts();
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

        public static async void UpdateProduct(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var data = new { idProduct = product.IdProduct, productName = product.ProductName };

                    HttpResponseMessage httpResponseMessage
                        = await client.PutAsJsonAsync(Utilities.URLAPI + apiController, data);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Product updated successfully!");
                        GetAllProducts();
                    }
                    else
                    {
                        Console.WriteLine("Could not update Product");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public static async void DeleteProduct(int idProduct)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage httpResponseMessage
                        = await client.DeleteAsync(Utilities.URLAPI + apiController + $"/{idProduct}");

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Product deleted successfully!");
                        GetAllProducts();
                    }
                    else
                    {
                        Console.WriteLine("Could not delete Product");
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
