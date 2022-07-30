using System;

namespace Hotel.Comum
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            
                Console.WriteLine("Estou em debug");

#endif
#if !DEBUG
Console.WriteLine("Estou em release");
#endif


        }
    }
}
