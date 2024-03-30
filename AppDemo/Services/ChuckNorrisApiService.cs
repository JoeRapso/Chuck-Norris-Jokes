using System.Text.Json;

namespace AppDemo.Services
{
    public class ChuckNorrisApiService
    {
        string apiEndPoint = "https://api.chucknorris.io/jokes/random?category=dev";
        HttpClient httpClient = new HttpClient();

        public async Task<string?> GetApiData()
        {

            var response = Response();

            if (response.Result.IsSuccessStatusCode)
            {
                string responseData = await response.Result.Content.ReadAsStringAsync();
                var jokeModelData = JsonSerializer.Deserialize<Models.JokeModel>(responseData);

                return jokeModelData.value;

                
            }
            else
            {
                throw new Exception("Failed to fetch data from the chuck norris API");
            }

        }

        public async Task<HttpResponseMessage> Response()
        {
            return await httpClient.GetAsync(apiEndPoint);
        }

    }
}

