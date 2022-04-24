using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hitman
{
    public partial class Form1 : Form
    {
        #region fields
        private bool timerExpired = false;
        private ProcessKiller killer = new ProcessKiller();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKill_Click(object sender, System.EventArgs e)
        {
            timerExpired = false;
            if (chkPersist.Checked)
            {
                //lblStatus.Text = string.Empty;
                btnKill.BackColor = Color.Gray;
                btnKill.Enabled = false;
                var timer = new Timer() { Interval = 15 * 1000 };
                timer.Tick += Timer_Tick;
                timer.Start();

                do
                {
                    KillProcessOnMatch();
                } while (killer.ProcessCount > 0 && !timerExpired);

                timer.Stop();
                timerExpired = false;
                btnKill.Enabled = true;
                btnKill.BackColor = Color.Orange;
            }
            else
            {
                KillProcessOnMatch();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerExpired = true;
        }

        private void KillProcessOnMatch()
        {
            if (rbContains.Checked)
            {
                lblStatus.Text = killer.KillProcess(StringMatch.Contains, txtProcessBox.Text.Trim());
            }
            else if (rbExact.Checked)
            {
                lblStatus.Text = killer.KillProcess(StringMatch.Exact, txtProcessBox.Text.Trim());
            }
            else if (rbStartsWith.Checked)
            {
                lblStatus.Text = killer.KillProcess(StringMatch.StartsWith, txtProcessBox.Text.Trim());
            }
            else
            {
                lblStatus.Text = killer.KillProcess(StringMatch.EndsWith, txtProcessBox.Text.Trim());
            }
        }
    }
}