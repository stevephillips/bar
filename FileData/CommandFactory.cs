using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    static class CommandFactory
    {
        public static ICommand GetCommand(ArgsManager pArgsManager)
        {
            if (pArgsManager.ActionTypeValue == ArgsManager.ActionType.version
                && !String.IsNullOrEmpty(pArgsManager.Filename))
            {
                return new VersionGetter(pArgsManager.Filename);
            }
            if (pArgsManager.ActionTypeValue == ArgsManager.ActionType.size
                && !String.IsNullOrEmpty(pArgsManager.Filename))
            {
                return new SizeGetter(pArgsManager.Filename);
            }

            return new InfoGetter();

        }
    }
}
