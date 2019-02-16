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
            bool taskExecutedOK = false;

            ArgsManager argsManager = new ArgsManager(args);
            bool argsOK = argsManager.ArgsOK;

            if (argsOK) // So if we've got the args okay proceed to do the action
            {
                ActionType actionType = GetAction(argsManager.Action);

                if (actionType == ActionType.version)
                    taskExecutedOK = GetVersion(argsManager.Filename);

                if (actionType == ActionType.size)
                    taskExecutedOK = GetSize(argsManager.Filename);
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
