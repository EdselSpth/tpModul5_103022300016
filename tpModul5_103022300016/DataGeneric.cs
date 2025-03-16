using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_103022300016
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah : " + data);
        }
    }
}
