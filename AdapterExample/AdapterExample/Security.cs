using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    //alle klassen die hier van implementeren zijn onderdeel van de security
    public interface Security
    {
        void checkPerimeter();
        void checkCameras();
        void suitUp();
    }
}
