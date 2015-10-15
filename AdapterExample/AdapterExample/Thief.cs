using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    //alle klassen die hier van implementeren zijn niet bevoegd aanwezig te zijn
    interface Thief
    {
        void stealItem();
        void sneakOutBack();
        void stealOutfit();
    }
}
