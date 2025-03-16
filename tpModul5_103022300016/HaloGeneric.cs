using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_103022300016
{
    class HaloGeneric
    {
        public void halo<T>(T nama)
        {
            Console.WriteLine("Halo User " + nama);
        }
    }
}
