using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_IGL
{
    class exception : Exception
    {

        public exception() : base("les longueurs du vecteur nr sont pas egaux") { }
    }
}
