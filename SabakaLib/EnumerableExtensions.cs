namespace SabakaLib;

public static class EnumerableExtensions 
{
    public static T PickRandom<T>(this IEnumerable<T> source)
    {
        var list = source as IList<T> ?? source.ToList();
        if (list.Count == 0) throw new InvalidOperationException("The source sequence is empty.");

        var random = new Random();
        return list[random.Next(list.Count)];
    }
    
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class => source.Where(x => x != null)!;
    
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
        {
            action(item);
        }
    }
    
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
    {
        return source.OrderBy(_ => Guid.NewGuid());
    }
}