namespace Hitman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProcessBox = new System.Windows.Forms.TextBox();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbExact = new System.Windows.Forms.RadioButton();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.rbEndsWith = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProcessBox
            // 
            this.txtProcessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessBox.Location = new System.Drawing.Point(59, 24);
            this.txtProcessBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProcessBox.Name = "txtProcessBox";
            this.txtProcessBox.Size = new System.Drawing.Size(208, 32);
            this.txtProcessBox.TabIndex = 0;
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContains.Location = new System.Drawing.Point(16, 24);
            this.rbContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(81, 21);
            this.rbContains.TabIndex = 2;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "Contains";
            this.rbContains.UseVisualStyleBackColor = true;
            // 
            // rbExact
            // 
            this.rbExact.AutoSize = true;
            this.rbExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExact.Location = new System.Drawing.Point(114, 23);
            this.rbExact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbExact.Name = "rbExact";
            this.rbExact.Size = new System.Drawing.Size(60, 21);
            this.rbExact.TabIndex = 3;
            this.rbExact.Text = "Exact";
            this.rbExact.UseVisualStyleBackColor = true;
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStartsWith.Location = new System.Drawing.Point(16, 66);
            this.rbStartsWith.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(91, 21);
            this.rbStartsWith.TabIndex = 4;
            this.rbStartsWith.Text = "Starts with";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rbEndsWith
            // 
            this.rbEndsWith.AutoSize = true;
            this.rbEndsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEndsWith.Location = new System.Drawing.Point(114, 66);
            this.rbEndsWith.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEndsWith.Name = "rbEndsWith";
            this.rbEndsWith.Size = new System.Drawing.Size(86, 21);
            this.rbEndsWith.TabIndex = 5;
            this.rbEndsWith.Text = "Ends with";
            this.rbEndsWith.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbEndsWith);
            this.gbOptions.Controls.Add(this.rbContains);
            this.gbOptions.Controls.Add(this.rbStartsWith);
            this.gbOptions.Controls.Add(this.rbExact);
            this.gbOptions.Location = new System.Drawing.Point(59, 77);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOptions.Size = new System.Drawing.Size(207, 101);
            this.gbOptions.TabIndex = 5;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.Color.Orange;
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(93, 195);
            this.btnKill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(151, 71);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill It!!";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.BtnKill_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(56, 282);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(328, 325);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.txtProcessBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hitman | Sushant Aggarwal";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessBox;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.RadioButton rbExact;
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.RadioButton rbEndsWith;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label lblStatus;
    }
}

