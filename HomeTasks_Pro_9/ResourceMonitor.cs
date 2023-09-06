using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Pro_9
{
    internal class ResourceMonitor
    {
        private long maxMemory;

        public ResourceMonitor(long maxMemory)
        {
            this.maxMemory = maxMemory;
        }

        public void CheckMemory()
        {
            long currentMemory = GC.GetTotalMemory(false);

            Console.WriteLine($"Memory used: {currentMemory}");

            if (currentMemory >= maxMemory)
            {
                Console.WriteLine($"Warning: Memory usage has exceeded the maximum allowed level.");
            }
        }
    }
}
