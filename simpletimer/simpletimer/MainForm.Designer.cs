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
            this.timer1_timepassed = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.startTimer1 = new MetroFramework.Controls.MetroButton();
            this.startTimer2 = new MetroFramework.Controls.MetroButton();
            this.timer2_timepassed = new MetroFramework.Controls.MetroLabel();
            this.setTimeTimer1 = new MetroFramework.Controls.MetroButton();
            this.setTimeTimer2 = new MetroFramework.Controls.MetroButton();
            this.time1_days = new MetroFramework.Controls.MetroTextBox();
            this.time1_hours = new MetroFramework.Controls.MetroTextBox();
            this.time1_minutes = new MetroFramework.Controls.MetroTextBox();
            this.time1_seconds = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.time2_seconds = new MetroFramework.Controls.MetroTextBox();
            this.time2_minutes = new MetroFramework.Controls.MetroTextBox();
            this.time2_hours = new MetroFramework.Controls.MetroTextBox();
            this.time2_days = new MetroFramework.Controls.MetroTextBox();
            this.timer1_playsound = new MetroFramework.Controls.MetroCheckBox();
            this.timer2_playsound = new MetroFramework.Controls.MetroCheckBox();
            this.timer1_showWindowsToast = new MetroFramework.Controls.MetroCheckBox();
            this.timer2_showWindowsToast = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
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
            // timer1_timepassed
            // 
            this.timer1_timepassed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer1_timepassed.AutoSize = true;
            this.timer1_timepassed.ForeColor = System.Drawing.SystemColors.Control;
            this.timer1_timepassed.Location = new System.Drawing.Point(147, 400);
            this.timer1_timepassed.Name = "timer1_timepassed";
            this.timer1_timepassed.Size = new System.Drawing.Size(81, 19);
            this.timer1_timepassed.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_timepassed.TabIndex = 2;
            this.timer1_timepassed.Text = "------------";
            this.timer1_timepassed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_timepassed.UseStyleColors = true;
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
            // startTimer1
            // 
            this.startTimer1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.startTimer1.Location = new System.Drawing.Point(24, 334);
            this.startTimer1.Name = "startTimer1";
            this.startTimer1.Size = new System.Drawing.Size(233, 63);
            this.startTimer1.Style = MetroFramework.MetroColorStyle.Orange;
            this.startTimer1.TabIndex = 4;
            this.startTimer1.Text = "Start";
            this.startTimer1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startTimer1.UseCustomBackColor = true;
            this.startTimer1.UseSelectable = true;
            this.startTimer1.UseStyleColors = true;
            this.startTimer1.Click += new System.EventHandler(this.cmdTimer1_Click);
            // 
            // startTimer2
            // 
            this.startTimer2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.startTimer2.Location = new System.Drawing.Point(276, 334);
            this.startTimer2.Name = "startTimer2";
            this.startTimer2.Size = new System.Drawing.Size(233, 63);
            this.startTimer2.Style = MetroFramework.MetroColorStyle.Orange;
            this.startTimer2.TabIndex = 5;
            this.startTimer2.Text = "Start";
            this.startTimer2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startTimer2.UseCustomBackColor = true;
            this.startTimer2.UseSelectable = true;
            this.startTimer2.UseStyleColors = true;
            this.startTimer2.Click += new System.EventHandler(this.cmdTimer2_Click);
            // 
            // timer2_timepassed
            // 
            this.timer2_timepassed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer2_timepassed.AutoSize = true;
            this.timer2_timepassed.ForeColor = System.Drawing.SystemColors.Control;
            this.timer2_timepassed.Location = new System.Drawing.Point(399, 400);
            this.timer2_timepassed.Name = "timer2_timepassed";
            this.timer2_timepassed.Size = new System.Drawing.Size(75, 19);
            this.timer2_timepassed.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_timepassed.TabIndex = 6;
            this.timer2_timepassed.Text = "-----------";
            this.timer2_timepassed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timer2_timepassed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_timepassed.UseStyleColors = true;
            // 
            // setTimeTimer1
            // 
            this.setTimeTimer1.Location = new System.Drawing.Point(181, 63);
            this.setTimeTimer1.Name = "setTimeTimer1";
            this.setTimeTimer1.Size = new System.Drawing.Size(75, 23);
            this.setTimeTimer1.TabIndex = 9;
            this.setTimeTimer1.Text = "Set";
            this.setTimeTimer1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setTimeTimer1.UseCustomBackColor = true;
            this.setTimeTimer1.UseSelectable = true;
            this.setTimeTimer1.Click += new System.EventHandler(this.cmdSetTime1_Click);
            // 
            // setTimeTimer2
            // 
            this.setTimeTimer2.Location = new System.Drawing.Point(433, 61);
            this.setTimeTimer2.Name = "setTimeTimer2";
            this.setTimeTimer2.Size = new System.Drawing.Size(75, 23);
            this.setTimeTimer2.TabIndex = 10;
            this.setTimeTimer2.Text = "Set";
            this.setTimeTimer2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setTimeTimer2.UseCustomBackColor = true;
            this.setTimeTimer2.UseSelectable = true;
            this.setTimeTimer2.Click += new System.EventHandler(this.cmdSetTime2_Click);
            // 
            // time1_days
            // 
            // 
            // 
            // 
            this.time1_days.CustomButton.Image = null;
            this.time1_days.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time1_days.CustomButton.Name = "";
            this.time1_days.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time1_days.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time1_days.CustomButton.TabIndex = 1;
            this.time1_days.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time1_days.CustomButton.UseSelectable = true;
            this.time1_days.CustomButton.Visible = false;
            this.time1_days.Lines = new string[0];
            this.time1_days.Location = new System.Drawing.Point(23, 63);
            this.time1_days.MaxLength = 32767;
            this.time1_days.Name = "time1_days";
            this.time1_days.PasswordChar = '\0';
            this.time1_days.PromptText = "d";
            this.time1_days.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time1_days.SelectedText = "";
            this.time1_days.SelectionLength = 0;
            this.time1_days.SelectionStart = 0;
            this.time1_days.ShortcutsEnabled = true;
            this.time1_days.Size = new System.Drawing.Size(34, 23);
            this.time1_days.TabIndex = 7;
            this.time1_days.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time1_days.UseSelectable = true;
            this.time1_days.WaterMark = "d";
            this.time1_days.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time1_days.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time1_hours
            // 
            // 
            // 
            // 
            this.time1_hours.CustomButton.Image = null;
            this.time1_hours.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time1_hours.CustomButton.Name = "";
            this.time1_hours.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time1_hours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time1_hours.CustomButton.TabIndex = 1;
            this.time1_hours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time1_hours.CustomButton.UseSelectable = true;
            this.time1_hours.CustomButton.Visible = false;
            this.time1_hours.Lines = new string[0];
            this.time1_hours.Location = new System.Drawing.Point(63, 63);
            this.time1_hours.MaxLength = 32767;
            this.time1_hours.Name = "time1_hours";
            this.time1_hours.PasswordChar = '\0';
            this.time1_hours.PromptText = "h";
            this.time1_hours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time1_hours.SelectedText = "";
            this.time1_hours.SelectionLength = 0;
            this.time1_hours.SelectionStart = 0;
            this.time1_hours.ShortcutsEnabled = true;
            this.time1_hours.Size = new System.Drawing.Size(34, 23);
            this.time1_hours.TabIndex = 11;
            this.time1_hours.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time1_hours.UseSelectable = true;
            this.time1_hours.WaterMark = "h";
            this.time1_hours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time1_hours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time1_minutes
            // 
            // 
            // 
            // 
            this.time1_minutes.CustomButton.Image = null;
            this.time1_minutes.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time1_minutes.CustomButton.Name = "";
            this.time1_minutes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time1_minutes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time1_minutes.CustomButton.TabIndex = 1;
            this.time1_minutes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time1_minutes.CustomButton.UseSelectable = true;
            this.time1_minutes.CustomButton.Visible = false;
            this.time1_minutes.Lines = new string[0];
            this.time1_minutes.Location = new System.Drawing.Point(103, 63);
            this.time1_minutes.MaxLength = 32767;
            this.time1_minutes.Name = "time1_minutes";
            this.time1_minutes.PasswordChar = '\0';
            this.time1_minutes.PromptText = "m";
            this.time1_minutes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time1_minutes.SelectedText = "";
            this.time1_minutes.SelectionLength = 0;
            this.time1_minutes.SelectionStart = 0;
            this.time1_minutes.ShortcutsEnabled = true;
            this.time1_minutes.Size = new System.Drawing.Size(34, 23);
            this.time1_minutes.TabIndex = 12;
            this.time1_minutes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time1_minutes.UseSelectable = true;
            this.time1_minutes.WaterMark = "m";
            this.time1_minutes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time1_minutes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time1_seconds
            // 
            // 
            // 
            // 
            this.time1_seconds.CustomButton.Image = null;
            this.time1_seconds.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time1_seconds.CustomButton.Name = "";
            this.time1_seconds.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time1_seconds.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time1_seconds.CustomButton.TabIndex = 1;
            this.time1_seconds.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time1_seconds.CustomButton.UseSelectable = true;
            this.time1_seconds.CustomButton.Visible = false;
            this.time1_seconds.Lines = new string[0];
            this.time1_seconds.Location = new System.Drawing.Point(141, 63);
            this.time1_seconds.MaxLength = 32767;
            this.time1_seconds.Name = "time1_seconds";
            this.time1_seconds.PasswordChar = '\0';
            this.time1_seconds.PromptText = "s";
            this.time1_seconds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time1_seconds.SelectedText = "";
            this.time1_seconds.SelectionLength = 0;
            this.time1_seconds.SelectionStart = 0;
            this.time1_seconds.ShortcutsEnabled = true;
            this.time1_seconds.Size = new System.Drawing.Size(34, 23);
            this.time1_seconds.TabIndex = 13;
            this.time1_seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time1_seconds.UseSelectable = true;
            this.time1_seconds.WaterMark = "s";
            this.time1_seconds.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time1_seconds.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(12, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = ":";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(94, 65);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(12, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = ":";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(133, 65);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(12, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = ":";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(12, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = ":";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(346, 63);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = ":";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(306, 63);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(12, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = ":";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // time2_seconds
            // 
            // 
            // 
            // 
            this.time2_seconds.CustomButton.Image = null;
            this.time2_seconds.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time2_seconds.CustomButton.Name = "";
            this.time2_seconds.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time2_seconds.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time2_seconds.CustomButton.TabIndex = 1;
            this.time2_seconds.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time2_seconds.CustomButton.UseSelectable = true;
            this.time2_seconds.CustomButton.Visible = false;
            this.time2_seconds.Lines = new string[0];
            this.time2_seconds.Location = new System.Drawing.Point(393, 61);
            this.time2_seconds.MaxLength = 32767;
            this.time2_seconds.Name = "time2_seconds";
            this.time2_seconds.PasswordChar = '\0';
            this.time2_seconds.PromptText = "s";
            this.time2_seconds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time2_seconds.SelectedText = "";
            this.time2_seconds.SelectionLength = 0;
            this.time2_seconds.SelectionStart = 0;
            this.time2_seconds.ShortcutsEnabled = true;
            this.time2_seconds.Size = new System.Drawing.Size(34, 23);
            this.time2_seconds.TabIndex = 25;
            this.time2_seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time2_seconds.UseSelectable = true;
            this.time2_seconds.WaterMark = "s";
            this.time2_seconds.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time2_seconds.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time2_minutes
            // 
            // 
            // 
            // 
            this.time2_minutes.CustomButton.Image = null;
            this.time2_minutes.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time2_minutes.CustomButton.Name = "";
            this.time2_minutes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time2_minutes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time2_minutes.CustomButton.TabIndex = 1;
            this.time2_minutes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time2_minutes.CustomButton.UseSelectable = true;
            this.time2_minutes.CustomButton.Visible = false;
            this.time2_minutes.Lines = new string[0];
            this.time2_minutes.Location = new System.Drawing.Point(355, 61);
            this.time2_minutes.MaxLength = 32767;
            this.time2_minutes.Name = "time2_minutes";
            this.time2_minutes.PasswordChar = '\0';
            this.time2_minutes.PromptText = "m";
            this.time2_minutes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time2_minutes.SelectedText = "";
            this.time2_minutes.SelectionLength = 0;
            this.time2_minutes.SelectionStart = 0;
            this.time2_minutes.ShortcutsEnabled = true;
            this.time2_minutes.Size = new System.Drawing.Size(34, 23);
            this.time2_minutes.TabIndex = 24;
            this.time2_minutes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time2_minutes.UseSelectable = true;
            this.time2_minutes.WaterMark = "m";
            this.time2_minutes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time2_minutes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time2_hours
            // 
            // 
            // 
            // 
            this.time2_hours.CustomButton.Image = null;
            this.time2_hours.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time2_hours.CustomButton.Name = "";
            this.time2_hours.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time2_hours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time2_hours.CustomButton.TabIndex = 1;
            this.time2_hours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time2_hours.CustomButton.UseSelectable = true;
            this.time2_hours.CustomButton.Visible = false;
            this.time2_hours.Lines = new string[0];
            this.time2_hours.Location = new System.Drawing.Point(315, 61);
            this.time2_hours.MaxLength = 32767;
            this.time2_hours.Name = "time2_hours";
            this.time2_hours.PasswordChar = '\0';
            this.time2_hours.PromptText = "h";
            this.time2_hours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time2_hours.SelectedText = "";
            this.time2_hours.SelectionLength = 0;
            this.time2_hours.SelectionStart = 0;
            this.time2_hours.ShortcutsEnabled = true;
            this.time2_hours.Size = new System.Drawing.Size(34, 23);
            this.time2_hours.TabIndex = 23;
            this.time2_hours.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time2_hours.UseSelectable = true;
            this.time2_hours.WaterMark = "h";
            this.time2_hours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time2_hours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // time2_days
            // 
            // 
            // 
            // 
            this.time2_days.CustomButton.Image = null;
            this.time2_days.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.time2_days.CustomButton.Name = "";
            this.time2_days.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.time2_days.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.time2_days.CustomButton.TabIndex = 1;
            this.time2_days.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.time2_days.CustomButton.UseSelectable = true;
            this.time2_days.CustomButton.Visible = false;
            this.time2_days.Lines = new string[0];
            this.time2_days.Location = new System.Drawing.Point(275, 61);
            this.time2_days.MaxLength = 32767;
            this.time2_days.Name = "time2_days";
            this.time2_days.PasswordChar = '\0';
            this.time2_days.PromptText = "d";
            this.time2_days.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.time2_days.SelectedText = "";
            this.time2_days.SelectionLength = 0;
            this.time2_days.SelectionStart = 0;
            this.time2_days.ShortcutsEnabled = true;
            this.time2_days.Size = new System.Drawing.Size(34, 23);
            this.time2_days.TabIndex = 22;
            this.time2_days.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time2_days.UseSelectable = true;
            this.time2_days.WaterMark = "d";
            this.time2_days.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.time2_days.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timer1_playsound
            // 
            this.timer1_playsound.AutoSize = true;
            this.timer1_playsound.Location = new System.Drawing.Point(23, 129);
            this.timer1_playsound.Name = "timer1_playsound";
            this.timer1_playsound.Size = new System.Drawing.Size(82, 15);
            this.timer1_playsound.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_playsound.TabIndex = 29;
            this.timer1_playsound.Text = "Play Sound";
            this.timer1_playsound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_playsound.UseCustomBackColor = true;
            this.timer1_playsound.UseSelectable = true;
            this.timer1_playsound.CheckedChanged += new System.EventHandler(this.timer1_playsound_CheckedChanged);
            // 
            // timer2_playsound
            // 
            this.timer2_playsound.AutoSize = true;
            this.timer2_playsound.Location = new System.Drawing.Point(276, 129);
            this.timer2_playsound.Name = "timer2_playsound";
            this.timer2_playsound.Size = new System.Drawing.Size(82, 15);
            this.timer2_playsound.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_playsound.TabIndex = 30;
            this.timer2_playsound.Text = "Play Sound";
            this.timer2_playsound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_playsound.UseCustomBackColor = true;
            this.timer2_playsound.UseSelectable = true;
            this.timer2_playsound.CheckedChanged += new System.EventHandler(this.timer2_playsound_CheckedChanged);
            // 
            // timer1_showWindowsToast
            // 
            this.timer1_showWindowsToast.AutoSize = true;
            this.timer1_showWindowsToast.Location = new System.Drawing.Point(23, 150);
            this.timer1_showWindowsToast.Name = "timer1_showWindowsToast";
            this.timer1_showWindowsToast.Size = new System.Drawing.Size(135, 15);
            this.timer1_showWindowsToast.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_showWindowsToast.TabIndex = 31;
            this.timer1_showWindowsToast.Text = "Show Windows Toast";
            this.timer1_showWindowsToast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_showWindowsToast.UseCustomBackColor = true;
            this.timer1_showWindowsToast.UseSelectable = true;
            // 
            // timer2_showWindowsToast
            // 
            this.timer2_showWindowsToast.AutoSize = true;
            this.timer2_showWindowsToast.Location = new System.Drawing.Point(276, 150);
            this.timer2_showWindowsToast.Name = "timer2_showWindowsToast";
            this.timer2_showWindowsToast.Size = new System.Drawing.Size(135, 15);
            this.timer2_showWindowsToast.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_showWindowsToast.TabIndex = 32;
            this.timer2_showWindowsToast.Text = "Show Windows Toast";
            this.timer2_showWindowsToast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_showWindowsToast.UseCustomBackColor = true;
            this.timer2_showWindowsToast.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 107);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(55, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "Options";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(263, 107);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(55, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 34;
            this.metroLabel10.Text = "Options";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.timer2_showWindowsToast);
            this.Controls.Add(this.timer1_showWindowsToast);
            this.Controls.Add(this.timer2_playsound);
            this.Controls.Add(this.timer1_playsound);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.time2_seconds);
            this.Controls.Add(this.time2_minutes);
            this.Controls.Add(this.time2_hours);
            this.Controls.Add(this.time2_days);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.time1_seconds);
            this.Controls.Add(this.time1_minutes);
            this.Controls.Add(this.time1_hours);
            this.Controls.Add(this.setTimeTimer2);
            this.Controls.Add(this.setTimeTimer1);
            this.Controls.Add(this.time1_days);
            this.Controls.Add(this.timer2_timepassed);
            this.Controls.Add(this.startTimer2);
            this.Controls.Add(this.startTimer1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.timer1_timepassed);
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
        private MetroFramework.Controls.MetroLabel timer1_timepassed;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton startTimer1;
        private MetroFramework.Controls.MetroButton startTimer2;
        private MetroFramework.Controls.MetroLabel timer2_timepassed;
        private MetroFramework.Controls.MetroButton setTimeTimer1;
        private MetroFramework.Controls.MetroButton setTimeTimer2;
        private MetroFramework.Controls.MetroTextBox time1_days;
        private MetroFramework.Controls.MetroTextBox time1_hours;
        private MetroFramework.Controls.MetroTextBox time1_minutes;
        private MetroFramework.Controls.MetroTextBox time1_seconds;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox time2_seconds;
        private MetroFramework.Controls.MetroTextBox time2_minutes;
        private MetroFramework.Controls.MetroTextBox time2_hours;
        private MetroFramework.Controls.MetroTextBox time2_days;
        private MetroFramework.Controls.MetroCheckBox timer1_playsound;
        private MetroFramework.Controls.MetroCheckBox timer2_playsound;
        private MetroFramework.Controls.MetroCheckBox timer1_showWindowsToast;
        private MetroFramework.Controls.MetroCheckBox timer2_showWindowsToast;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}

