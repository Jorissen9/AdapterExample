using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterExample
{
    class ThiefAdapter : Security //implementeerd security, dus bevoegd om aanwezig te zijn
    {
        ThiefExpert thief;

        public ThiefAdapter(ThiefExpert thief)
        {
            this.thief = thief;
            thief.stealOutfit();
        }

        public void checkCameras()
        {
            Console.WriteLine("Checking cameras");
            Thread.Sleep(2000);
            //maakt niet uit of iemand er is, gewoon zeggen
            Console.WriteLine("No one in sight");
        }

        public void checkPerimeter()
        {
            Console.WriteLine("Checking perimeter");
            Thread.Sleep(5000);
            //het programma denkt dat deze agent zijn ronde nog steeds doet maar gaat sneaky doen
            thief.stealItem();
            thief.sneakOutBack();
        }

        public void suitUp()
        {
            Console.WriteLine("Uniform is on");
        }
    }
}
