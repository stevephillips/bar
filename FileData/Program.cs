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
            ArgsManager argsManager = new ArgsManager(args);
            ICommand command = CommandFactory.GetCommand(argsManager);
            bool isError = command.Process();

            Console.WriteLine("Success=" + isError.ToString());
        }
    }
}
