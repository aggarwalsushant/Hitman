using System.Drawing;
using System.Windows.Forms;

namespace Hitman
{
    public partial class Form1 : Form
    {
        #region fields
        private readonly ProcessKiller killer = new ProcessKiller();
        private readonly ICountdownTimer timer = new CountdownTimer(seconds: 15);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKill_Click(object sender, System.EventArgs e)
        {
            timer.Reset();

            if (chkPersist.Checked)
            {
                btnKill.BackColor = Color.Gray;
                btnKill.Enabled = false;

                timer.Start();

                do
                {
                    KillProcessOnMatch();
                } while (killer.ProcessCount > 0 && !timer.IsExpired);

                timer.Reset();
                btnKill.Enabled = true;
                btnKill.BackColor = Color.Orange;
            }
            else
            {
                KillProcessOnMatch();
            }
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                WindowState = FormWindowState.Minimized;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}