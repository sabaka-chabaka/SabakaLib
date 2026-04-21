namespace SabakaLib;

public static class Guard
{
    public static void AgainstNull(object? value, string name)
    {
        if (value is null) throw new ArgumentNullException(name);
    }
}