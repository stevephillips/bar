﻿using System;
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
            bool taskExecutedOK = false;

            if (args.Length > 0)
            {
                action = args[0];
            }
            if (args.Length > 1)
            {
                filename = args[1];
            }



            if (!taskExecutedOK)
            {
                Console.WriteLine("Error - Put information message here about usage etc");
            }
        }

        public static bool doVersion(string pFilename)
        {
            Console.WriteLine("Version of " + pFilename);
            FileDetails fileDetails = new FileDetails();
            Console.WriteLine(fileDetails.Version(pFilename));
            return true;
        }


    }
}
