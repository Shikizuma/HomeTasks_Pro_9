namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            using (var bigObj = new BigClass(100000000))
            {
            }
        }
    }
}