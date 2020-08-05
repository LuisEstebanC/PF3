using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Final.Models;
using System.Text.Json;


namespace Final
{
    public class API
    {
        private static string BaseUrl = "http://173.249.49.169:88/";
        private static HttpResponseMessage res;

        public static async Task<Persona> consultarAsync(string Cedula)
        {
            Persona per = new Persona();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseUrl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {

                    res = await client.GetAsync("api/test/consulta/" + Cedula);

                }
                catch (Exception)
                {
                    return null;
                }

                if (res.IsSuccessStatusCode)
                {

                    string Response = res.Content.ReadAsStringAsync().Result;

                    per = JsonSerializer.Deserialize<Persona>(Response);

                }

                return per;

            }
        }
    }
}