using System.Linq;

namespace TryBeingFit.Domain.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidName(string name)
        {
            return name.Length >= 3;
        }

        public static bool ValidUsername(string username)
        {
            return username.Length >= 6;
        }

        public static bool ValidPassword(string password)
        {
            return password.Length > 6 && password.Any(x => char.IsDigit(x));
        }
    }
}
