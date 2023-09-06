using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class BigClass : IDisposable
    {
        private byte[] bigArray;
        public void Dispose()
        {
            Console.WriteLine($"Dispose BigClass.");
            ClearMemory();
            bigArray = null;
        }

        public BigClass(int size)
        {
            bigArray = new byte[size];
        }

        public void ClearMemory()
        {
            Array.Clear(bigArray, 0, bigArray.Length);
        }
      
    }
}
