using HR_ManagmentSystem_Client.Logic.Common;
using Newtonsoft.Json;

namespace HR_ManagmentSystem_Client.Logic.Autherization
{
    public class AutherizationService
    {
        private readonly string _baseUrl;

        public AutherizationService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        #region Get Employee Roles
        public async Task<ApiResponse<IEnumerable<string>>> GetByIDAsync(string id)
        {
            using (var client = new HttpClient())
            {
                // Get the token from session manager
                string accessToken = sessionManager.AccessToken;

                // Check if token is available
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new UnauthorizedAccessException("No access token found.");
                }

                // Set up the authorization header with Bearer token
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                // Use the correct endpoint for deleting an employee
                var getUrl = $"{_baseUrl}/Autherization/Role/{id}";

                // Send a DELETE request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<IEnumerable<string>>>(responseString);
            }
        }
        #endregion
    }
}
