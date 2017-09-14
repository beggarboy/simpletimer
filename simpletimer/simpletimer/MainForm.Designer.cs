namespace simpletimer
{
    partial class MainForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTimePassed1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmdTimer1 = new MetroFramework.Controls.MetroButton();
            this.cmdTimer2 = new MetroFramework.Controls.MetroButton();
            this.lblTimePassed2 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxTime1 = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxTime2 = new MetroFramework.Controls.MetroTextBox();
            this.cmdSetTime1 = new MetroFramework.Controls.MetroButton();
            this.cmdSetTime2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(23, 400);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Total Session Time:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTimePassed1
            // 
            this.lblTimePassed1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimePassed1.AutoSize = true;
            this.lblTimePassed1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimePassed1.Location = new System.Drawing.Point(147, 400);
            this.lblTimePassed1.Name = "lblTimePassed1";
            this.lblTimePassed1.Size = new System.Drawing.Size(81, 19);
            this.lblTimePassed1.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblTimePassed1.TabIndex = 2;
            this.lblTimePassed1.Text = "------------";
            this.lblTimePassed1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTimePassed1.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(275, 400);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Total Session Time:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmdTimer1
            // 
            this.cmdTimer1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdTimer1.Location = new System.Drawing.Point(23, 90);
            this.cmdTimer1.Name = "cmdTimer1";
            this.cmdTimer1.Size = new System.Drawing.Size(233, 307);
            this.cmdTimer1.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmdTimer1.TabIndex = 4;
            this.cmdTimer1.Text = "5 Minutes";
            this.cmdTimer1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdTimer1.UseCustomBackColor = true;
            this.cmdTimer1.UseSelectable = true;
            this.cmdTimer1.UseStyleColors = true;
            this.cmdTimer1.Click += new System.EventHandler(this.cmdTimer1_Click);
            // 
            // cmdTimer2
            // 
            this.cmdTimer2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdTimer2.Location = new System.Drawing.Point(275, 90);
            this.cmdTimer2.Name = "cmdTimer2";
            this.cmdTimer2.Size = new System.Drawing.Size(233, 307);
            this.cmdTimer2.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmdTimer2.TabIndex = 5;
            this.cmdTimer2.Text = "10 Minutes";
            this.cmdTimer2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdTimer2.UseCustomBackColor = true;
            this.cmdTimer2.UseSelectable = true;
            this.cmdTimer2.UseStyleColors = true;
            this.cmdTimer2.Click += new System.EventHandler(this.cmdTimer2_Click);
            // 
            // lblTimePassed2
            // 
            this.lblTimePassed2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimePassed2.AutoSize = true;
            this.lblTimePassed2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimePassed2.Location = new System.Drawing.Point(399, 400);
            this.lblTimePassed2.Name = "lblTimePassed2";
            this.lblTimePassed2.Size = new System.Drawing.Size(75, 19);
            this.lblTimePassed2.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblTimePassed2.TabIndex = 6;
            this.lblTimePassed2.Text = "-----------";
            this.lblTimePassed2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimePassed2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTimePassed2.UseStyleColors = true;
            // 
            // txtBoxTime1
            // 
            // 
            // 
            // 
            this.txtBoxTime1.CustomButton.Image = null;
            this.txtBoxTime1.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtBoxTime1.CustomButton.Name = "";
            this.txtBoxTime1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxTime1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxTime1.CustomButton.TabIndex = 1;
            this.txtBoxTime1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxTime1.CustomButton.UseSelectable = true;
            this.txtBoxTime1.CustomButton.Visible = false;
            this.txtBoxTime1.Lines = new string[0];
            this.txtBoxTime1.Location = new System.Drawing.Point(23, 63);
            this.txtBoxTime1.MaxLength = 32767;
            this.txtBoxTime1.Name = "txtBoxTime1";
            this.txtBoxTime1.PasswordChar = '\0';
            this.txtBoxTime1.PromptText = "2h5m10s";
            this.txtBoxTime1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxTime1.SelectedText = "";
            this.txtBoxTime1.SelectionLength = 0;
            this.txtBoxTime1.SelectionStart = 0;
            this.txtBoxTime1.ShortcutsEnabled = true;
            this.txtBoxTime1.Size = new System.Drawing.Size(118, 23);
            this.txtBoxTime1.TabIndex = 7;
            this.txtBoxTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBoxTime1.UseSelectable = true;
            this.txtBoxTime1.WaterMark = "2h5m10s";
            this.txtBoxTime1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxTime1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxTime2
            // 
            // 
            // 
            // 
            this.txtBoxTime2.CustomButton.Image = null;
            this.txtBoxTime2.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtBoxTime2.CustomButton.Name = "";
            this.txtBoxTime2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxTime2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxTime2.CustomButton.TabIndex = 1;
            this.txtBoxTime2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxTime2.CustomButton.UseSelectable = true;
            this.txtBoxTime2.CustomButton.Visible = false;
            this.txtBoxTime2.Lines = new string[0];
            this.txtBoxTime2.Location = new System.Drawing.Point(275, 61);
            this.txtBoxTime2.MaxLength = 32767;
            this.txtBoxTime2.Name = "txtBoxTime2";
            this.txtBoxTime2.PasswordChar = '\0';
            this.txtBoxTime2.PromptText = "2h5m10s";
            this.txtBoxTime2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxTime2.SelectedText = "";
            this.txtBoxTime2.SelectionLength = 0;
            this.txtBoxTime2.SelectionStart = 0;
            this.txtBoxTime2.ShortcutsEnabled = true;
            this.txtBoxTime2.Size = new System.Drawing.Size(118, 23);
            this.txtBoxTime2.TabIndex = 8;
            this.txtBoxTime2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBoxTime2.UseSelectable = true;
            this.txtBoxTime2.WaterMark = "2h5m10s";
            this.txtBoxTime2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxTime2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmdSetTime1
            // 
            this.cmdSetTime1.Location = new System.Drawing.Point(181, 63);
            this.cmdSetTime1.Name = "cmdSetTime1";
            this.cmdSetTime1.Size = new System.Drawing.Size(75, 23);
            this.cmdSetTime1.TabIndex = 9;
            this.cmdSetTime1.Text = "Set";
            this.cmdSetTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdSetTime1.UseCustomBackColor = true;
            this.cmdSetTime1.UseSelectable = true;
            this.cmdSetTime1.Click += new System.EventHandler(this.cmdSetTime1_Click);
            // 
            // cmdSetTime2
            // 
            this.cmdSetTime2.Location = new System.Drawing.Point(433, 61);
            this.cmdSetTime2.Name = "cmdSetTime2";
            this.cmdSetTime2.Size = new System.Drawing.Size(75, 23);
            this.cmdSetTime2.TabIndex = 10;
            this.cmdSetTime2.Text = "Set";
            this.cmdSetTime2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmdSetTime2.UseCustomBackColor = true;
            this.cmdSetTime2.UseSelectable = true;
            this.cmdSetTime2.Click += new System.EventHandler(this.cmdSetTime2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.cmdSetTime2);
            this.Controls.Add(this.cmdSetTime1);
            this.Controls.Add(this.txtBoxTime2);
            this.Controls.Add(this.txtBoxTime1);
            this.Controls.Add(this.lblTimePassed2);
            this.Controls.Add(this.cmdTimer2);
            this.Controls.Add(this.cmdTimer1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblTimePassed1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Simple Timer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblTimePassed1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton cmdTimer1;
        private MetroFramework.Controls.MetroButton cmdTimer2;
        private MetroFramework.Controls.MetroLabel lblTimePassed2;
        private MetroFramework.Controls.MetroTextBox txtBoxTime1;
        private MetroFramework.Controls.MetroTextBox txtBoxTime2;
        private MetroFramework.Controls.MetroButton cmdSetTime1;
        private MetroFramework.Controls.MetroButton cmdSetTime2;
    }
}

