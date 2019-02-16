using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class ArgsManager
    {
        public string Action;
        public string Filename;
        public bool ArgsOK = false;
        public ArgsManager(string[] pArgs)
        {
            // Don't know if there's a requirement to check for more than two arguments, spec is unclear

            if (pArgs.Length > 0) 
            {
                Action = pArgs[0];
            }

            if (pArgs.Length > 1) 
            {
                Filename = pArgs[1];
                ArgsOK = true;
            }
        }
    }
}
