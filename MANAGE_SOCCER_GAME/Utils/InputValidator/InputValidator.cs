using System.Text.RegularExpressions;

namespace MANAGE_SOCCER_GAME.Utils.InputValidators
{
    public static class InputValidator
    {
        public static bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static bool IsValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[\p{L} ]+$");
        }

        public static bool IsValidNumber(string number)
        {
            return !string.IsNullOrWhiteSpace(number) && Regex.IsMatch(number, @"^\d+$");
        }

        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) &&
                   Regex.IsMatch(phoneNumber, @"^(\+84|0)\d{9,10}$");
        }
    }
}
