using System;
using ThirdPartyTools;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class SizeGetter : ICommand
    {
        string _filename;
        public SizeGetter(string pFilename)
        {
            _filename = pFilename;
        }
        public bool Process()
        {
            Console.WriteLine("Size of {0}", _filename);
            FileDetails fileDetails = new FileDetails();
            Console.WriteLine(fileDetails.Size(_filename));
            return true;
        }
    }
}
