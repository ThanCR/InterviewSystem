
using InterviewSystem.ET.Models;
using System.Net.Http.Json;
using System.Text.Json;

const string APIurl = "https://localhost:7128/ProductDescription";

//Creating new http client
using (HttpClient client = new HttpClient())
{
    try
    {
        HttpResponseMessage response = await client.GetAsync(APIurl);

        if (response.IsSuccessStatusCode)
        {
            APIResponse<List<ProductDescription>> jsonContent 
                = await response.Content.ReadFromJsonAsync<APIResponse<List<ProductDescription>>>();

            List<ProductDescription> result = jsonContent.Response;

            result.ForEach(x =>
            {
                Console.WriteLine($"" +
                    $"Name: {x.ProductName}\n" +
                    $"Aspect: {x.ProductDescriptionTypeName}\n" +
                    $"Description: {x.ProductDescriptionName} \n");
            });
        }
        else
        {
            Console.WriteLine("An error ocurred when processing request");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex);
    }
}

Console.ReadLine();
