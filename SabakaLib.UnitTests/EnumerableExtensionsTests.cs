using System.Collections.ObjectModel;
using Xunit;

namespace SabakaLib.UnitTests;

public class EnumerableExtensionsTests
{
    [Fact]
    public void PickRandom_ReturnsDifferentElementsOverTime()
    {
        var source = Enumerable.Range(1, 1000).ToList();
        var results = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            results.Add(source.PickRandom());
        }

        Assert.True(results.Count > 1); 
    }
    
    [Fact]
    public void WhereNotNull_ReturnsNotNullElements()
    {
        var source = new List<string?> { "a", null, "b" };
        var results = source.WhereNotNull();
        
        Assert.DoesNotContain(results, x => x == null);
    }
    
    [Fact]
    public void ForEach_CallsActionForEachElement()
    {
        var source = new[] { 1, 2, 3 }; 
        var results = new List<int>();
        
        source.ForEach(results.Add);
        
        Assert.Equal(source, results);
    }
    
    [Fact]
    public void Shuffle_ReturnsDifferentElementsOverTime()
    {
        var source = Enumerable.Range(1, 1000).ToList();
        var results = new List<int>(source.Shuffle());
        
        Assert.NotEqual(source, results);
    }
}