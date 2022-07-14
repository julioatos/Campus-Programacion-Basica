using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_Programacion_Basica
{
    internal class MyException
    {
        public void Fail() => throw new Exception("Error!");
    }
}
