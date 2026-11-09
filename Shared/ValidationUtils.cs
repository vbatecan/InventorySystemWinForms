using System.Text.RegularExpressions;

namespace InventorySystem.Shared;

public class ValidationUtils
{

    public static bool ValidateEmail(string email)
    {
        // Validate Email Format, dapat may @ at domain.
        if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")) return false;
        return true;
    }

    public static string ValidatePassword(string password)
    {
        if (password.Length < 8) return "Password should be at least 8 characters.";
        if (password.Equals("")) return "Password cannot be empty.";
        return "valid";
    }
}