using HR_ManagmentSystem_Client.Logic.Attendance.DTOs;
using HR_ManagmentSystem_Client.Logic.Common;
using Newtonsoft.Json;
using System.Text;

namespace HR_ManagmentSystem_Client.Logic.Attendance
{
    public class AttendanceService
    {
        private readonly string _baseUrl;

        public AttendanceService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        #region Clock In
        public async Task<ApiResponse<string>> ClockIn(ClockInDTO userid)
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

                var registerUrl = $"{_baseUrl}/Attendance/clock-in";

                var jsonBody = JsonConvert.SerializeObject(userid);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion

        #region Clock Out
        public async Task<ApiResponse<string>> ClockOut(ClockOutDTO userid)
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
                var registerUrl = $"{_baseUrl}/Attendance/clock-out";

                var jsonBody = JsonConvert.SerializeObject(userid);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }
        #endregion


        #region Get Attendance By ID
        public async Task<ApiResponse<List<AttendanceRecordDTO>>> GetByIDAsync(string id)
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
                // Use the correct endpoint for getting attendance by ID
                var getUrl = $"{_baseUrl}/Attendance/{id}";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<List<AttendanceRecordDTO>>>(responseString);
            }
        }
        #endregion

        #region Get Attendance By Date
        public async Task<ApiResponse<List<AttendanceRecordDTO>>> GetDailyAsync(DateOnly date)
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
                // Use the correct endpoint for getting attendance by ID
                string formattedDate = date.ToString("yyyy-MM-dd");
                var getUrl = $"{_baseUrl}/Attendance/daily?date={formattedDate}";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<List<AttendanceRecordDTO>>>(responseString);
            }
        }
        #endregion

        #region Get All Attendanc
        public async Task<ApiResponse<List<AttendanceRecordDTO>>> GetAllAttendance()
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
                // Use the correct endpoint for getting all attendance 
                var getUrl = $"{_baseUrl}/Attendance";

                // Send a Get request
                var response = await client.GetAsync(getUrl);

                // Read and deserialize the response
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<List<AttendanceRecordDTO>>>(responseString);
            }
        }
        #endregion




    }
}
