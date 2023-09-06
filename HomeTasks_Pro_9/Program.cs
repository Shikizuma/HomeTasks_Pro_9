namespace HomeTasks_Pro_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long maxMemoryUsage = 1000000; 
            ResourceMonitor resourceMonitor = new ResourceMonitor(maxMemoryUsage);

            for (int i = 0; i < 1000; i++)
            {
                AllocateMemory();
                resourceMonitor.CheckMemory();
            }
        }
        static void AllocateMemory()
        {
            byte[] buffer = new byte[1000000];
        }
    }
}