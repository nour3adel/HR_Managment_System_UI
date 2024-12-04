using HR_ManagmentSystem_Client.Logic.Common;
using HR_ManagmentSystem_Client.Logic.LeaveRequest.DTOs
    ;
using Newtonsoft.Json;
using System.Text;

namespace HR_ManagmentSystem_Client.Logic.LeaveRequest
{
    public class LeaveRequestService
    {
        private readonly string _baseUrl;

        public LeaveRequestService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        #region Create New LeaveRequest

        public async Task<ApiResponse<string>> CreateAsync(CreateLeaveRequestDTO dTO)
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
                var registerUrl = $"{_baseUrl}/LeaveRequest";


                var jsonBody = JsonConvert.SerializeObject(dTO);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion


        //#region Delete Leave Request
        //public async Task<ApiResponse<string>> DeleteAsync(int id)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        // Use the correct endpoint for deleting an employee
        //        var deleteUrl = $"{_baseUrl}/Employee/{id}";

        //        // Send a DELETE request
        //        var response = await client.DeleteAsync(deleteUrl);

        //        // Read and deserialize the response
        //        var responseString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
        //    }
        //}
        //#endregion

        #region Get Leave Request By ID
        public async Task<ApiResponse<List<GetLeaveRequestDTO>>> GetByIDAsync(string id)
        {
            using (var client = new HttpClient())
            {
                // Get the token from session manager
                string accessToken = sessionManager.AccessToken;

                // Check if token is available
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new UnauthorizedAccessException("No access token found. Please log in again.");
                }

                // Set up the authorization header with Bearer token
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                // Use the correct endpoint for fetching leave request by ID
                var getUrl = $"{_baseUrl}/LeaveRequest/employee/{id}";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
                }

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<List<GetLeaveRequestDTO>>>(responseString);
            }
        }
        #endregion

        #region Get All LeaveRequests
        public async Task<ApiResponse<IEnumerable<GetLeaveRequestDTO>>> GetAllAsync()
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
                var getUrl = $"{_baseUrl}/LeaveRequest/employee/All";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<IEnumerable<GetLeaveRequestDTO>>>(responseString);
            }
        }
        #endregion

        #region Approve LeaveRequest
        public async Task<ApiResponse<string>> ApproveRequestAsync(int id)
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
                // Define the URL with the id in the path
                var registerUrl = $"{_baseUrl}/LeaveRequest/{id}/approve";

                // Create an empty StringContent if no data needs to be sent
                var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");

                // Make the PUT request
                var response = await client.PutAsync(registerUrl, content);

                // Read the response content
                var responseString = await response.Content.ReadAsStringAsync();

                // Return the deserialized response
                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

        #region Reject LeaveRequest
        public async Task<ApiResponse<string>> RejectRequestAsync(int id)
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
                // Define the URL with the id in the path
                var registerUrl = $"{_baseUrl}/LeaveRequest/{id}/reject";

                // Create an empty StringContent if no data needs to be sent
                var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");

                // Make the PUT request
                var response = await client.PutAsync(registerUrl, content);

                // Read the response content
                var responseString = await response.Content.ReadAsStringAsync();

                // Return the deserialized response
                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion


        //#region Edit New EMployee
        //public async Task<ApiResponse<string>> EditAsync(object EditData)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var registerUrl = $"{_baseUrl}/Employee/EditUser";


        //        var jsonBody = JsonConvert.SerializeObject(EditData);
        //        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        //        var response = await client.PutAsync(registerUrl, content);
        //        var responseString = await response.Content.ReadAsStringAsync();

        //        return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
        //    }
        //}
        //#endregion

    }
}
