using HR_ManagmentSystem_Client.Logic.Common;
using HR_ManagmentSystem_Client.Logic.Notification.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace HR_ManagmentSystem_Client.Logic.Notification
{
    public class NotificationService
    {
        private readonly string _baseUrl;

        public NotificationService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        #region Send Notification 

        public async Task<ApiResponse<string>> SendAsync(SendDTO dTO)
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
                var registerUrl = $"{_baseUrl}/Notification/Send";


                var jsonBody = JsonConvert.SerializeObject(dTO);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

        #region Get All Notifications
        public async Task<ApiResponse<IEnumerable<GetNotificationDTO>>> GetAllAsync()
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
                var getUrl = $"{_baseUrl}/Notification";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<IEnumerable<GetNotificationDTO>>>(responseString);
            }
        }
        #endregion


        #region Get  Notifications of specific employee
        public async Task<ApiResponse<IEnumerable<GetNotificationDTO>>> GetEmployeeNotificationsAsync(string empId)
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
                var getUrl = $"{_baseUrl}/Notification/{empId}";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<IEnumerable<GetNotificationDTO>>>(responseString);
            }
        }
        #endregion




    }
}
