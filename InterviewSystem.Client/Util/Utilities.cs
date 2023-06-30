using InterviewSystem.ET.Models;
using InterviewSystem.ET.ModelsCustom;
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

        public async static void GetProductsByTypeName(string name)
        {
            try
            {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await client.GetAsync($"{URLAPI}api/ProductQuery?productTypeName={name}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    APIResponse<ProductByTypeGroup> jsonContent =
                        await httpResponseMessage.Content.ReadFromJsonAsync<APIResponse<ProductByTypeGroup>>();

                    ProductByTypeGroup products = jsonContent.Response;
                        Console.WriteLine($"Here you have the results for: {products.ProductTypeData.ProductTypeName}" +
                            $"\n-----------------------------------------------------------------------");
                        products.ProductsDescriptionsGroup.ForEach(productDescriptionGroup => 
                        {
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("***" + productDescriptionGroup.ProductData.ProductName.ToUpper());
                            productDescriptionGroup.ProductDescriptions.ForEach(description => Console.WriteLine("-" + description.ProductDescriptionName));
                        });

                        Console.ReadLine();

                }
                else
                {
                    Console.WriteLine($"An error has ocurred when consuming /api/ProductQuery endpoint");
                }
            }
            }catch(Exception e)
            {
                Console.WriteLine("An exception has ocurred when trying to execute API request");
            }
        }

        public static string AskForSelection(int typeOfRequest) 
        {
            if(typeOfRequest == 1)
            {

            Console.WriteLine("\nPlease insert the number related to the data you want to consume" +
                "\n1.Get All" +
                "\n2.Get By Id" +
                "\n3.Create " +
                "\n4.Update" +
                "\n5.Delete");
            }
            if(typeOfRequest == 2)
            {
                Console.WriteLine("\nInsert the number of the query you want to execute and press enter" +
                "\n1.Get products of an specific type");
            }
            string selection = Console.ReadLine() ?? "1";
            return selection;
        }
    }
}
