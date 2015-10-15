using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class SecurityAgent : Security
    {
        public void checkCameras()
        {
            Console.WriteLine("Checking cameras");
            Thread.Sleep(2000);
            Console.WriteLine("No one in sight");
        }

        public void checkPerimeter()
        {
            Console.WriteLine("Checking perimeter");
            Thread.Sleep(5000);
            Console.WriteLine("No unauthorised personel found");
        }

        public void suitUp()
        {
            Console.WriteLine("Uniform is on");
        }
    }
}
