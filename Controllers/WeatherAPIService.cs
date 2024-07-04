using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace WeatherAPI.Controllers
{
    public class WeatherAPIService
    {

        private string _subkey;
        private string _url;
        private string _endpoint;
        private HttpClient _httpClient;

        public WeatherAPIService() {

            _subkey = "ce059e54d6aa445e949162734240307";
            _url = "https://api.weatherapi.com/v1/";
            _httpClient = new HttpClient();
        }

        public async Task<string> GetCurrentWeatherByPostCode(string postCode) {

            _endpoint = "current.json";

            HttpResponseMessage JsonResult = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, _url+_endpoint+"?q="+postCode+"&key="+_subkey));            
            return await JsonResult.Content.ReadAsStringAsync();
        }

    }
}
