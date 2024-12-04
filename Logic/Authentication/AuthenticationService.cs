using HR_ManagmentSystem_Client.Logic.Common;
using Newtonsoft.Json;
using System.Text;

namespace HR_ManagmentSystem_Client.Logic.Authentication
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;

        public AuthenticationService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<ApiResponse<TokenResponse>> LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var loginUrl = $"{_baseUrl}/Authentication/Login";
                var requestBody = new
                {
                    username = username,
                    password = password
                };

                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(loginUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<TokenResponse>>(responseString);
            }
        }
    }
}
