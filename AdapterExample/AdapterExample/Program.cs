using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityAgent agent = new SecurityAgent();
            ThiefExpert thief = new ThiefExpert();
            Security thiefAdapter = new ThiefAdapter(thief);

            Console.WriteLine("Real agent does his round");
            doRound(agent);

            Console.WriteLine("Thief does his round");
            doRound(thiefAdapter);

            Console.ReadKey();
        }

        static void doRound(Security sec)
        {
            sec.suitUp();
            sec.checkCameras();
            sec.checkPerimeter();
        }
    }
}
