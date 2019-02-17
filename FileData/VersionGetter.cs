using System;
using ThirdPartyTools;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class VersionGetter : ICommand
    {
        string _filename;
        public VersionGetter(string pFilename)
        {
            _filename = pFilename;
        }
        public bool Process()
        {
            Console.WriteLine("Version of {0}", _filename);
            FileDetails fileDetails = new FileDetails();
            Console.WriteLine(fileDetails.Version(_filename));
            return true;
        }
    }
}
