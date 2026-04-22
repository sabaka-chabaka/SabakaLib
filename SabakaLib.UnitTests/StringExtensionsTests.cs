using Xunit;

namespace SabakaLib.UnitTests;

public class StringExtensionsTests
{
    [Fact]
    public void IsEmpty_ReturnsTrueForEmpty()
    {
        Assert.True("".IsEmpty());
    }
    
    [Fact]
    public void IsEmpty_ReturnsFalseForNotEmpty()
    {
        Assert.False("a".IsEmpty());
    }
    
    [Fact]
    public void IsNotEmpty_ReturnsTrueForNotEmpty()
    {
        Assert.True("a".IsNotEmpty());
    }
    
    [Fact]
    public void IsNotEmpty_ReturnsFalseForEmpty()
    {
        Assert.False("".IsNotEmpty());
    }

    [Fact]
    public void Truncate_ReturnsTruncatedString()
    {
        Assert.Equal("coolguy..", "coolguys".Truncate(7));
    }
}