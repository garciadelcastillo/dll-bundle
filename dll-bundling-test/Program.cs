using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dll_bundling_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running method from bundle dll...");
            Console.WriteLine();

            dll_bundling.SampleClass.Log();

            Console.ReadLine();
        }
    }
}
