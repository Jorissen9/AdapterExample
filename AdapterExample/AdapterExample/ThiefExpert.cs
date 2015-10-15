using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class ThiefExpert : Thief
    {
        public void stealOutfit()
        {
            Console.WriteLine("Stole outfit from SecurityAgent on vacation");
        }

        public void sneakOutBack()
        {
            Console.WriteLine("Act normal, use backdoor and walk away");
        }

        public void stealItem()
        {
            Console.WriteLine("Turn off alarm");
            Console.WriteLine("Take precious jewel");
            Console.WriteLine("Turn on alarm");
        }
    }
}
