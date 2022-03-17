using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Hitman
{
    internal enum StringMatch
    {
        Contains, Exact, StartsWith, EndsWith
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKill_Click(object sender, System.EventArgs e)
        {
            if (rbContains.Checked)
            {
                KillProcess(StringMatch.Contains);
            }
            else if (rbExact.Checked)
            {
                KillProcess(StringMatch.Exact);
            }
            else if (rbStartsWith.Checked)
            {
                KillProcess(StringMatch.StartsWith);
            }
            else
            {
                KillProcess(StringMatch.EndsWith);
            }
        }

        private void KillProcess(StringMatch match)
        {
            var count = 0;
            try
            {
                var allProcesses = Process.GetProcesses();
                lblStatus.Text = string.Empty;

                switch (match)
                {
                    case StringMatch.Contains:
                        var qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.IndexOf(txtProcessBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0)
                         .ToList();
                        count = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.Exact:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.Equals(txtProcessBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        count = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.StartsWith:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.StartsWith(txtProcessBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        count = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;

                    case StringMatch.EndsWith:
                        qualifyingProcesses = allProcesses
                         .Where(x => x.ProcessName.EndsWith(txtProcessBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                         .ToList();
                        count = qualifyingProcesses.Count;
                        qualifyingProcesses.ForEach(x => x.Kill());
                        break;
                }

                lblStatus.Text = count == 0 ? "No processes. All okay!" : $"{count} processes killed.";
            }
            catch (System.Exception)
            {
                lblStatus.Text = $"Couldn't kill processes. {count} remain. ";
            }
        }
    }
}