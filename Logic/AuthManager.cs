namespace HR_ManagmentSystem_Client.Logic
{
    public class AuthManager
    {
        // Private static instance of the AuthManager
        private static AuthManager _instance;

        // Property to get the instance of AuthManager (Singleton)
        public static AuthManager Instance => _instance ??= new AuthManager();

        // Property to store the access token
        public string AccessToken { get; private set; }

        // Private constructor to prevent external instantiation
        private AuthManager() { }

        // Method to save the access token
        public void SaveAccessToken(string accessToken)
        {
            // Store the access token, you can also consider storing it in a secure location like local storage
            AccessToken = accessToken;
        }

        // Method to get the access token
        public string GetAccessToken()
        {
            return AccessToken;
        }

        // Optional: You can add logic to clear the token or manage it further if needed
        public void ClearAccessToken()
        {
            AccessToken = null;
        }
    }

}
