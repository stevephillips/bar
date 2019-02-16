using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public enum ActionType { none, version, size };

        public static void Main(string[] args)
        {
            string action = null;
            string filename = null;
            bool argsOK = true;
            bool taskExecutedOK = false;

            if (args.Length > 0) // If there's no args at all we shouldn't process (ie: reset argsOK)
            {
                action = args[0];
            }
            else
            {
                argsOK = false;
            }

            if (args.Length > 1 && argsOK) // If there's no error with the action arg (0), and there's more than one argument get the value of that (filename)
            {
                filename = args[1];
            }
            else // If there's not a second arg then we shouldn't process (ie: reset argsOK)
            {
                argsOK = false;
            }

            // Don't know if there's a requirement to check for more than two arguments, spec is unclear

            if (argsOK) // So if we've got the args okay proceed to do the action
            {
                ActionType actionType = GetAction(action);
                if (actionType == ActionType.version)
                    taskExecutedOK = GetVersion(filename);

                if (actionType == ActionType.size)
                    taskExecutedOK = GetSize(filename);
            }

            if (!taskExecutedOK) // any errors returned by the action show an error
            {
                Console.WriteLine("Error - Put information message here about usage etc");
            }
        }


        public static ActionType GetAction(string pAction)
        {
            if (pAction == "-v" || pAction == "--v" || pAction == "/v" || pAction == "--version")
                return ActionType.version;

            if (pAction == "-s" || pAction == "--s" || pAction == "/s" || pAction == "--size")
                return ActionType.size;

            return ActionType.none;

        }
        public static bool GetVersion(string pFilename)
        {
            Console.WriteLine("Version of {0}", pFilename);
            FileDetails fileDetails = new FileDetails();
            Console.WriteLine(fileDetails.Version(pFilename));
            return true;
        }

        public static bool GetSize(string pFilename)
        {
            Console.WriteLine("Size of {0}", pFilename);
            FileDetails fileDetails = new FileDetails();
            Console.WriteLine(fileDetails.Size(pFilename));
            return true;
        }


    }
}
