using Xunit;

namespace SabakaLib.UnitTests;

public class TaskExtensionsTests
{
    [Fact]
    public async Task WithTimeout_ShouldThrowTimeoutException_WhenTaskIsTooSlow()
    {
        var slowTask = Task.Delay(TimeSpan.FromSeconds(10), TestContext.Current.CancellationToken);
        var timeout = TimeSpan.FromMilliseconds(100);

        await Assert.ThrowsAsync<TimeoutException>(async () => 
            await slowTask.WithTimeout(timeout)
        );
    }

}