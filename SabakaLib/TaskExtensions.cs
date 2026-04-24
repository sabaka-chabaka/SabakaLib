namespace SabakaLib;

public static class TaskExtensions
{
    public static async Task WithTimeout(this Task task, TimeSpan timeout)
    {
        using var delayTaskCts = new CancellationTokenSource();
        var delayTask = Task.Delay(timeout, delayTaskCts.Token);

        var completedTask = await Task.WhenAny(task, delayTask);

        if (completedTask == delayTask)
        {
            throw new TimeoutException($"Операция превысила время ожидания в {timeout.TotalSeconds} сек.");
        }

        await delayTaskCts.CancelAsync();
        
        await task; 
    }

    public static async Task<T> WithTimeout<T>(this Task<T> task, TimeSpan timeout)
    {
        using var delayTaskCts = new CancellationTokenSource();
        var delayTask = Task.Delay(timeout, delayTaskCts.Token);

        var completedTask = await Task.WhenAny(task, delayTask);

        if (completedTask == delayTask)
        {
            throw new TimeoutException($"Операция превысила время ожидания.");
        }

        await delayTaskCts.CancelAsync();
        return await task;
    }
}
