using System.Text.RegularExpressions;

namespace DNS_Application;

public static class Helpers
{
    public static bool IsIpAddress(string input)
    {
        string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
        if (Regex.IsMatch(input, pattern))
        {
            string[] octets = input.Split('.');
            foreach (string octet in octets)
            {
                if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}