using System;
using System.Collections.Concurrent;
using System.Threading;

namespace command
{
    public class ThreadPool<T> where T: IJob
    {
        private static BlockingCollection<T> jobQueue = new BlockingCollection<T>();
        private Thread[] jobThreads;
        private static bool shutdown; 

        public ThreadPool(int numberOfThreads)
        {
            for (var i = 0; i < numberOfThreads; i++)
            {
                Console.WriteLine($"Job ID: {numberOfThreads} executing logging jobs.");
            }
        }

        public void AddJob(T emailJob)
        {
            jobQueue.Add(emailJob);
        }

        public void ShutdownPool()
        {
            const int sleepTime = 1000;

            while (jobQueue.Count > 0)
            {
                try
                {
                    Worker.Run();
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }

            shutdown = true;
            foreach (var workerThread in jobThreads)
            {
                workerThread.Interrupt();
            }
        }

        private class Worker(string name) : ThreadLocal<IJob>
        {
            public static void Run()
            {
                while (!shutdown)
                {
                    try
                    {
                        var r = jobQueue.Take();
                        r.Run();
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}