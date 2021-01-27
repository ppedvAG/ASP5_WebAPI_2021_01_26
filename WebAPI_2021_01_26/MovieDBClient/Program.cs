using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieDBClient
{
    class Program
    {

        private static string baseURL = "https://localhost:44311/api/Movies/";
        private static HttpClient client = new HttpClient();


        static async Task Main(string[] args)
        {


            await ShowAllMoviesWithXML();
            //await InsertMovie();

            Movie movie = await GetMovieById(1);
            movie.price = 199m;
            movie.title = "Aquaman";

            await UpdateMovie(movie);
            await ShowAllMovies();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Delete Beispiel: ");

            Movie movieToDelete = await GetMovieById(2);
            await DeleteMovie(movieToDelete);
            await ShowAllMovies();

        }

        static async Task ShowAllMovies()
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, baseURL);
            HttpResponseMessage responseMessage  = await client.SendAsync(requestMessage);

            string jsonText = await responseMessage.Content.ReadAsStringAsync();

            IList<Movie> list = JsonConvert.DeserializeObject<List<Movie>>(jsonText);


            foreach (Movie currentMovie in list)
            {
                Console.WriteLine( $"Filmtitel: {currentMovie.title}");
                Console.WriteLine($"Preis: {currentMovie.price}");
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("### Bitte Taste drücken ###");
            Console.ReadKey();
        }


        static async Task ShowAllMoviesWithXML()
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));


            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, baseURL);
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

            string jsonText = await responseMessage.Content.ReadAsStringAsync();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));

            StringReader stringReader = new StringReader(jsonText);
            List<Movie> list = (List<Movie>)serializer.Deserialize(stringReader);


            foreach (Movie currentMovie in list)
            {
                Console.WriteLine($"Filmtitel: {currentMovie.title}");
                Console.WriteLine($"Preis: {currentMovie.price}");
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("### Bitte Taste drücken ###");
            Console.ReadKey();
        }

        static async Task InsertMovie()
        {
            Movie newMovie = new Movie { title = "Biene Maja", price = 2.99m };
            string jsonText = JsonConvert.SerializeObject(newMovie);

            StringContent data = new StringContent(jsonText, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(baseURL, data);

            string result = await responseMessage.Content.ReadAsStringAsync();
        }

        static async Task<Movie> GetMovieById(int Id)
        {
            string url = baseURL + Id.ToString(); //https://localhost:44311/api/Movies/1

            HttpResponseMessage responseMessage = await client.GetAsync(url);
            string jsonText = await responseMessage.Content.ReadAsStringAsync();

            Movie movie = JsonConvert.DeserializeObject<Movie>(jsonText);

            return movie;
        }

        static async Task UpdateMovie(Movie movie)
        {
            string url = baseURL + movie.id.ToString(); //https://localhost:44311/api/Movies/1

            string json = JsonConvert.SerializeObject(movie);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PutAsync(url, data);
            string result = await responseMessage.Content.ReadAsStringAsync();
        }

        static async Task DeleteMovie(Movie movie)
        {
            string url = baseURL + movie.id.ToString(); //https://localhost:44311/api/Movies/1

            HttpResponseMessage responseMessage = await client.DeleteAsync(url);
            string result = await responseMessage.Content.ReadAsStringAsync();
        }
    }

    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
    }
}
