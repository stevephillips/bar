using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class InfoGetter : ICommand
    {
        public bool Process()
        {
            Console.WriteLine("Error - Put information message here about usage etc");
            return false;
        }
    }
}
