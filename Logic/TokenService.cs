using System.IdentityModel.Tokens.Jwt;

namespace HR_ManagmentSystem_Client.Logic
{
    public static class TokenService
    {
        public static List<string> GetRoles(string accessToken)
        {
            var roles = new List<string>();

            try
            {
                // Create a JWT handler
                var handler = new JwtSecurityTokenHandler();

                // Read the JWT token
                var jsonToken = handler.ReadToken(accessToken) as JwtSecurityToken;

                if (jsonToken != null)
                {
                    // Extract the roles claim (using the Microsoft role claim type)
                    var roleClaims = jsonToken.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").ToList();

                    if (roleClaims.Any())
                    {
                        // Add the roles to the list
                        roles = roleClaims.Select(c => c.Value).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decoding token: {ex.Message}");
            }

            return roles;
        }
        public static string GetClaimValue(string accessToken, string claimType)
        {
            try
            {
                // Create a JWT handler
                var handler = new JwtSecurityTokenHandler();

                // Read the JWT token
                var jsonToken = handler.ReadToken(accessToken) as JwtSecurityToken;

                if (jsonToken != null)
                {
                    // Extract the specific claim
                    var claim = jsonToken.Claims.FirstOrDefault(c => c.Type == claimType);

                    return claim?.Value; // Return the claim value if found
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decoding token: {ex.Message}");
            }

            return null; // Return null if claim not found or error occurs
        }
    }
}

