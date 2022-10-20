using System;
using System.Linq;

namespace Hitman
{
    internal interface IArgumentParser
    {
        void ParseArguments(string[] args, out bool persistFlag,
            out StringMatch match, out string processName);
    }

    internal class ArgumentParser: IArgumentParser
    {
        public void ParseArguments(string[] args, out bool persistFlag,
            out StringMatch match, out string processName)
        {
            persistFlag = Array.Find(args, x =>
                x.Equals("-p", StringComparison.OrdinalIgnoreCase) ||
                x.Equals("-persist", StringComparison.OrdinalIgnoreCase)) != null;

            match = StringMatch.Exact;
            foreach (var item in args.Where(x => x.StartsWith("-")))
            {
                switch (item.ToLower())
                {
                    case "-c" : match = StringMatch.Contains; break;
                    case "-sw": match = StringMatch.StartsWith; break;
                    case "-ew": match = StringMatch.EndsWith; break;
                    case "-ex": match = StringMatch.Exact; break;
                }
            }

            processName = Array.Find(args, x => !x.StartsWith("-"));
        }
    }
}
