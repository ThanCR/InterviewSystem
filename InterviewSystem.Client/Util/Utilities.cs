using InterviewSystem.ET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewSystem.Client.Util
{
    public class Utilities
    {
        public static string URLAPI = "https://localhost:7128/";

        public async static void GetProductsSummary()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await client.GetAsync($"{URLAPI}Product");
                HttpResponseMessage httpResponseMessage2 = await client.GetAsync($"{URLAPI}ProductDescription");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    APIResponse<List<Product>> jsonContent =
                        await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<List<Product>>>();

                    APIResponse<List<ProductDescription>> jsonContent2 =
                        await httpResponseMessage2.Content.ReadFromJsonAsync<APIResponse<List<ProductDescription>>>();

                    List<Product> products = jsonContent.Response;
                    List<ProductDescription> productDescriptions = jsonContent2.Response;

                    products.ForEach(x =>
                    {
                        Console.WriteLine($"\n------Product information------\n"+
                                        $"Name: {x.ProductName}\n");
                        Console.WriteLine("DESCRIPTION:");
                        for(int i = 0; i < productDescriptions.Count; i++)
                        {
                            if (productDescriptions[i].ProductName == x.ProductName)
                            {
                                Console.WriteLine($"{productDescriptions[i].ProductDescriptionName}");
                            }
                        }
                    });
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine($"An error has ocurred when consuming /Product endpoint");
                }
            }
        }

    }
}
