using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterExample
{
    //De echte bewakings agent
    public class SecurityAgent : Security
    {
        public void checkCameras()
        {
            Console.WriteLine("Checking cameras");
            Thread.Sleep(2000);
            //er vanuitgaand dat er niemand is die er niet moet zijn
            Console.WriteLine("No one in sight");
        }

        public void checkPerimeter()
        {
            Console.WriteLine("Checking perimeter");
            Thread.Sleep(5000);
            //er vanuitgaand dat er niemand is die er niet moet zijn
            Console.WriteLine("No unauthorised personel found");
        }

        public void suitUp()
        {
            //uniform aandoen
            Console.WriteLine("Uniform is on");
        }
    }
}
