using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class ArgsManager
    {
        public string Filename;
        public ActionType ActionTypeValue;
        public enum ActionType { none, version, size };
        public ArgsManager(string[] pArgs)
        {
            // Don't know if there's a requirement to check for more than two arguments, spec is unclear

            if (pArgs.Length > 0) 
            {
                ActionTypeValue = GetAction(pArgs[0]);
            }

            if (pArgs.Length > 1) 
            {
                Filename = pArgs[1];
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
    }
}
