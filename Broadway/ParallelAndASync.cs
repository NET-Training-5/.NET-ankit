//Parallel Programming --> Multithreading, Task-based (TPL-Task Parallel Library)
// Asynchronous Programming

class ParallelAndAsync
{
    public void WriteParallelCode()
    {
        //sequential loop
        for (byte i = 1; i < 10; i++)
        {
            DoTask(i);
        }

        Console.WriteLine("paralle");
        Parallel.For(1, 11, i => DoTask(i));
    }

    void DoTask(int counter)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Done with task {counter}");
    }
}


