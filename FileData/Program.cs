using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string action = null;
            string filename = null;
            if (args.Length > 0)
            {
                action = args[0];
            }
            if (args.Length > 1)
            {
                filename = args[1];
            }

        }
    }
}
