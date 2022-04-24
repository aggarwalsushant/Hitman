using System;
using System.Diagnostics;
using System.Linq;

namespace Hitman
{
    internal enum StringMatch
    {
        Contains, Exact, StartsWith, EndsWith
    }

    internal class ProcessKiller
    {
        public int ProcessCount { get; private set; } = 0;

        public string KillProcess(StringMatch match, string processName)
        {
            ProcessCount = 0;
            try
            {
                var allProcesses = Process.GetProcesses();
                //lblStatus.Text = string.Empty;

                switch (match)
                {
                    case StringMatch.Contains:
                        var qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.IndexOf(processName, StringComparison.OrdinalIgnoreCase) >= 0)
                         .ToList();
                        ProcessCount = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.Exact:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        ProcessCount = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.StartsWith:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.StartsWith(processName, StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        ProcessCount = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.EndsWith:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.EndsWith(processName, StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        ProcessCount = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;
                }

                return ProcessCount == 0 ? "No processes. All okay!" : $"{ProcessCount} processes killed.";
            }
            catch (System.Exception)
            {
                return $"Couldn't kill processes. {ProcessCount} remain. ";
            }
        }
    }
}
