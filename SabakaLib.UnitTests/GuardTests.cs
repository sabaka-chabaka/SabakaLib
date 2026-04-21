using Xunit;

namespace SabakaLib.UnitTests;

public class GuardTests
{
    [Fact]
    public void AgainstNull_ThrowsException()
    {
        string? test = null;
        
        Assert.Throws<ArgumentNullException>(() => Guard.AgainstNull(test, nameof(test)));
    }

    [Fact]
    public void AgainstNull_DoesNotThrowException()
    {
        const string test = "test";

        Guard.AgainstNull(test, nameof(test));
    }
}