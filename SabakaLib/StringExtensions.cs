namespace SabakaLib;

public static class StringExtensions
{
    public static bool IsEmpty(this string? str) => string.IsNullOrEmpty(str);
    public static bool IsNotEmpty(this string? str) => !string.IsNullOrEmpty(str);

    public static string Truncate(this string? str, int maxLength, string suffix = "..")
    {
        if (str.IsEmpty() || str?.Length <= maxLength) return str ?? "";
        return str?.Substring(0, maxLength) + suffix;
    }
}