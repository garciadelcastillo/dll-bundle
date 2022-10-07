using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dll_bundling
{
    public class SampleClass
    {
        public static void Log()
        {
            Console.WriteLine("Newtonsoft.Json objects:");
            Console.WriteLine(Newtonsoft.Json.JsonConvert.True.ToString());
            Console.WriteLine();


            Console.WriteLine("Machina objects:");
            Console.WriteLine(Machina.RobotType.MACHINA);
        }
    }
}
