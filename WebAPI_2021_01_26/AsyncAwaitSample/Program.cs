using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" Beispiel 1 - SendAsync:");
            string baseUrl = "https://localhost:44384/WeatherForecast/";
            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, baseUrl);
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string jsonText = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(jsonText);
            Console.WriteLine("Weiter zu Beispiel 1a");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine(" Beispiel 2 - GetAsync:");
            HttpResponseMessage response1 = await client.GetAsync(baseUrl);
            string jsonText1 = await response1.Content.ReadAsStringAsync();
            Console.WriteLine(jsonText1);
            Console.WriteLine("Fertig");
            Console.ReadKey();



            //HttpResponseMessage returnValue = await Init();
        }


        static async Task<HttpResponseMessage> Init()
        {
            string baseUrl = "https://localhost:44384/WeatherForecast/"; //Get & Post - Methode / 
            //string baseUrl1 = "https://localhost:44384/api/StatusCode/"; 
            HttpClient client = new HttpClient();

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, baseUrl);
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string jsonText = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(jsonText);
            Console.WriteLine("Weiter zu Beispiel 1a");
            Console.ReadKey();
            Console.Clear();

            return responseMessage;
        }
    }
}
