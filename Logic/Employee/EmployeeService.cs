using HR_ManagmentSystem_Client.Logic.Common;
using HR_ManagmentSystem_Client.Logic.Employee.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace HR_ManagmentSystem_Client.Logic.Employee
{
    public class EmployeeService
    {
        private readonly string _baseUrl;

        public EmployeeService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        #region Register New EMployee
        public async Task<ApiResponse<string>> RegisterAsync(object registrationData)
        {
            using (var client = new HttpClient())
            {
                var registerUrl = $"{_baseUrl}/Employee/Register";


                var jsonBody = JsonConvert.SerializeObject(registrationData);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

        #region Delete Employee
        public async Task<ApiResponse<string>> DeleteAsync(string id)
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
                var deleteUrl = $"{_baseUrl}/Employee/{id}";

                // Send a DELETE request
                var response = await client.DeleteAsync(deleteUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

        #region Get Employee By ID
        public async Task<ApiResponse<SelectCustomerDTO>> GetByIDAsync(string id)
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
                var getUrl = $"{_baseUrl}/Employee/{id}";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<SelectCustomerDTO>>(responseString);
            }
        }
        #endregion

        #region LogOut
        public async Task<ApiResponse<string>> LogOut()
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

                // Use the correct endpoint for logging out
                var logoutUrl = $"{_baseUrl}/Employee/Logout";

                // Send a GET request with authorization header
                var response = await client.GetAsync(logoutUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();

                // Return the deserialized response
                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion


        #region Get All Employees
        public async Task<ApiResponse<IEnumerable<SelectCustomerDTO>>> GetAllAsync()
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
                var getUrl = $"{_baseUrl}/Employee/Employees";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<IEnumerable<SelectCustomerDTO>>>(responseString);
            }
        }
        #endregion

        #region Edit New EMployee
        public async Task<ApiResponse<string>> EditAsync(object EditData)
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
                var registerUrl = $"{_baseUrl}/Employee/EditUser";


                var jsonBody = JsonConvert.SerializeObject(EditData);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PutAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

    }
}
