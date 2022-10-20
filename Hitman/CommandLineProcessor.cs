namespace Hitman
{
    interface ICommandLineProcessor
    {
        void ParseArguments(string[] args, out bool persistFlag,
            out StringMatch match, out string processName);
    }

    internal class CommandLineProcessor: ICommandLineProcessor
    {
        private readonly IArgumentParser argumentParser = new ArgumentParser();
        private readonly ProcessKiller killer = new ProcessKiller();
        private ICountdownTimer timer;

        public void KillProcessViaCommandLine(string[] args)
        {
            ParseArguments(args, out bool persistFlag,
            out StringMatch match, out string processName);

            if (persistFlag)
            {
                timer = new CountdownTimer(seconds: 15);
                timer.Start();

                do
                {
                    killer.KillProcess(match, processName);
                } while (killer.ProcessCount > 0 && !timer.IsExpired);

                timer.Reset();
            }
            else
            {
                killer.KillProcess(match, processName);
            }
        }

        public void ParseArguments(string[] args, out bool persistFlag,
            out StringMatch match, out string processName)
        {
            argumentParser.ParseArguments(args, out persistFlag,
            out match, out processName);
        }
    }
}
