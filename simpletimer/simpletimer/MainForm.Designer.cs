﻿namespace simpletimer
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
            this.timer1_optionPlaySound = new MetroFramework.Controls.MetroCheckBox();
            this.timer2_optionPlaySound = new MetroFramework.Controls.MetroCheckBox();
            this.timer1_optionShowWindowsToast = new MetroFramework.Controls.MetroCheckBox();
            this.timer2_optionShowWindowsToast = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.timer1_days = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.timer1_hours = new MetroFramework.Controls.MetroLabel();
            this.timer1_minutes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.timer1_seconds = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.timer2_seconds = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.timer2_minutes = new MetroFramework.Controls.MetroLabel();
            this.timer2_hours = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.timer2_days = new MetroFramework.Controls.MetroLabel();
            this.timer1_optionShowMessageBox = new MetroFramework.Controls.MetroCheckBox();
            this.timer2_optionShowMessageBox = new MetroFramework.Controls.MetroCheckBox();
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
            this.timer1_timepassed.ForeColor = System.Drawing.SystemColors.Control;
            this.timer1_timepassed.Location = new System.Drawing.Point(141, 400);
            this.timer1_timepassed.Name = "timer1_timepassed";
            this.timer1_timepassed.Size = new System.Drawing.Size(115, 19);
            this.timer1_timepassed.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_timepassed.TabIndex = 2;
            this.timer1_timepassed.Text = "- - -";
            this.timer1_timepassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.startTimer1.Click += new System.EventHandler(this.startTimer1_Click);
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
            this.startTimer2.Click += new System.EventHandler(this.startTimer2_Click);
            // 
            // timer2_timepassed
            // 
            this.timer2_timepassed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer2_timepassed.ForeColor = System.Drawing.SystemColors.Control;
            this.timer2_timepassed.Location = new System.Drawing.Point(393, 400);
            this.timer2_timepassed.Name = "timer2_timepassed";
            this.timer2_timepassed.Size = new System.Drawing.Size(115, 19);
            this.timer2_timepassed.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_timepassed.TabIndex = 6;
            this.timer2_timepassed.Text = "- - -";
            this.timer2_timepassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer2_timepassed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_timepassed.UseStyleColors = true;
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
            this.time1_days.Location = new System.Drawing.Point(64, 63);
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
            this.time1_hours.Location = new System.Drawing.Point(104, 63);
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
            this.time1_minutes.Location = new System.Drawing.Point(144, 63);
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
            this.time1_seconds.Location = new System.Drawing.Point(182, 63);
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
            this.metroLabel3.Location = new System.Drawing.Point(95, 65);
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
            this.metroLabel5.Location = new System.Drawing.Point(135, 65);
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
            this.metroLabel6.Location = new System.Drawing.Point(174, 65);
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
            this.metroLabel2.Location = new System.Drawing.Point(426, 63);
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
            this.metroLabel7.Location = new System.Drawing.Point(387, 63);
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
            this.metroLabel8.Location = new System.Drawing.Point(347, 63);
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
            this.time2_seconds.Location = new System.Drawing.Point(434, 61);
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
            this.time2_minutes.Location = new System.Drawing.Point(396, 61);
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
            this.time2_hours.Location = new System.Drawing.Point(356, 61);
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
            this.time2_days.Location = new System.Drawing.Point(316, 61);
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
            // timer1_optionPlaySound
            // 
            this.timer1_optionPlaySound.AutoSize = true;
            this.timer1_optionPlaySound.Location = new System.Drawing.Point(23, 129);
            this.timer1_optionPlaySound.Name = "timer1_optionPlaySound";
            this.timer1_optionPlaySound.Size = new System.Drawing.Size(82, 15);
            this.timer1_optionPlaySound.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_optionPlaySound.TabIndex = 29;
            this.timer1_optionPlaySound.Text = "Play Sound";
            this.timer1_optionPlaySound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_optionPlaySound.UseCustomBackColor = true;
            this.timer1_optionPlaySound.UseSelectable = true;
            this.timer1_optionPlaySound.CheckedChanged += new System.EventHandler(this.timer1_optionPlaySound_CheckedChanged);
            // 
            // timer2_optionPlaySound
            // 
            this.timer2_optionPlaySound.AutoSize = true;
            this.timer2_optionPlaySound.Location = new System.Drawing.Point(276, 129);
            this.timer2_optionPlaySound.Name = "timer2_optionPlaySound";
            this.timer2_optionPlaySound.Size = new System.Drawing.Size(82, 15);
            this.timer2_optionPlaySound.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_optionPlaySound.TabIndex = 30;
            this.timer2_optionPlaySound.Text = "Play Sound";
            this.timer2_optionPlaySound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_optionPlaySound.UseCustomBackColor = true;
            this.timer2_optionPlaySound.UseSelectable = true;
            this.timer2_optionPlaySound.CheckedChanged += new System.EventHandler(this.timer2_optionPlaySound_CheckedChanged);
            // 
            // timer1_optionShowWindowsToast
            // 
            this.timer1_optionShowWindowsToast.AutoSize = true;
            this.timer1_optionShowWindowsToast.Location = new System.Drawing.Point(23, 150);
            this.timer1_optionShowWindowsToast.Name = "timer1_optionShowWindowsToast";
            this.timer1_optionShowWindowsToast.Size = new System.Drawing.Size(135, 15);
            this.timer1_optionShowWindowsToast.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_optionShowWindowsToast.TabIndex = 31;
            this.timer1_optionShowWindowsToast.Text = "Show Windows Toast";
            this.timer1_optionShowWindowsToast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_optionShowWindowsToast.UseCustomBackColor = true;
            this.timer1_optionShowWindowsToast.UseSelectable = true;
            this.timer1_optionShowWindowsToast.CheckedChanged += new System.EventHandler(this.timer1_optionShowWindowsToast_CheckedChanged);
            // 
            // timer2_optionShowWindowsToast
            // 
            this.timer2_optionShowWindowsToast.AutoSize = true;
            this.timer2_optionShowWindowsToast.Location = new System.Drawing.Point(276, 150);
            this.timer2_optionShowWindowsToast.Name = "timer2_optionShowWindowsToast";
            this.timer2_optionShowWindowsToast.Size = new System.Drawing.Size(135, 15);
            this.timer2_optionShowWindowsToast.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_optionShowWindowsToast.TabIndex = 32;
            this.timer2_optionShowWindowsToast.Text = "Show Windows Toast";
            this.timer2_optionShowWindowsToast.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_optionShowWindowsToast.UseCustomBackColor = true;
            this.timer2_optionShowWindowsToast.UseSelectable = true;
            this.timer2_optionShowWindowsToast.CheckedChanged += new System.EventHandler(this.timer2_optionShowWindowsToast_CheckedChanged);
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
            // timer1_days
            // 
            this.timer1_days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer1_days.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer1_days.ForeColor = System.Drawing.Color.Black;
            this.timer1_days.Location = new System.Drawing.Point(61, 246);
            this.timer1_days.Name = "timer1_days";
            this.timer1_days.Size = new System.Drawing.Size(43, 25);
            this.timer1_days.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_days.TabIndex = 35;
            this.timer1_days.Text = "d";
            this.timer1_days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer1_days.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.ForeColor = System.Drawing.Color.Black;
            this.metroLabel12.Location = new System.Drawing.Point(110, 246);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel12.TabIndex = 38;
            this.metroLabel12.Text = "d";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1_hours
            // 
            this.timer1_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer1_hours.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer1_hours.ForeColor = System.Drawing.Color.Black;
            this.timer1_hours.Location = new System.Drawing.Point(144, 246);
            this.timer1_hours.Name = "timer1_hours";
            this.timer1_hours.Size = new System.Drawing.Size(43, 25);
            this.timer1_hours.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_hours.TabIndex = 39;
            this.timer1_hours.Text = "h";
            this.timer1_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer1_hours.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1_minutes
            // 
            this.timer1_minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer1_minutes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer1_minutes.ForeColor = System.Drawing.Color.Black;
            this.timer1_minutes.Location = new System.Drawing.Point(61, 291);
            this.timer1_minutes.Name = "timer1_minutes";
            this.timer1_minutes.Size = new System.Drawing.Size(43, 25);
            this.timer1_minutes.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_minutes.TabIndex = 40;
            this.timer1_minutes.Text = "m";
            this.timer1_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer1_minutes.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.ForeColor = System.Drawing.Color.Black;
            this.metroLabel15.Location = new System.Drawing.Point(106, 291);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(28, 25);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel15.TabIndex = 41;
            this.metroLabel15.Text = "m";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.ForeColor = System.Drawing.Color.Black;
            this.metroLabel16.Location = new System.Drawing.Point(190, 246);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(28, 25);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel16.TabIndex = 42;
            this.metroLabel16.Text = "h";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.ForeColor = System.Drawing.Color.Black;
            this.metroLabel17.Location = new System.Drawing.Point(193, 291);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(28, 25);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel17.TabIndex = 44;
            this.metroLabel17.Text = "s";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1_seconds
            // 
            this.timer1_seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer1_seconds.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer1_seconds.ForeColor = System.Drawing.Color.Black;
            this.timer1_seconds.Location = new System.Drawing.Point(144, 291);
            this.timer1_seconds.Name = "timer1_seconds";
            this.timer1_seconds.Size = new System.Drawing.Size(43, 25);
            this.timer1_seconds.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_seconds.TabIndex = 43;
            this.timer1_seconds.Text = "s";
            this.timer1_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer1_seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(447, 291);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(28, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 52;
            this.metroLabel11.Text = "s";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer2_seconds
            // 
            this.timer2_seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer2_seconds.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer2_seconds.ForeColor = System.Drawing.Color.Black;
            this.timer2_seconds.Location = new System.Drawing.Point(398, 291);
            this.timer2_seconds.Name = "timer2_seconds";
            this.timer2_seconds.Size = new System.Drawing.Size(43, 25);
            this.timer2_seconds.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_seconds.TabIndex = 51;
            this.timer2_seconds.Text = "s";
            this.timer2_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer2_seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel20
            // 
            this.metroLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.ForeColor = System.Drawing.Color.Black;
            this.metroLabel20.Location = new System.Drawing.Point(444, 246);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(28, 25);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel20.TabIndex = 50;
            this.metroLabel20.Text = "h";
            this.metroLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.ForeColor = System.Drawing.Color.Black;
            this.metroLabel21.Location = new System.Drawing.Point(360, 291);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(28, 25);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel21.TabIndex = 49;
            this.metroLabel21.Text = "m";
            this.metroLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer2_minutes
            // 
            this.timer2_minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer2_minutes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer2_minutes.ForeColor = System.Drawing.Color.Black;
            this.timer2_minutes.Location = new System.Drawing.Point(315, 291);
            this.timer2_minutes.Name = "timer2_minutes";
            this.timer2_minutes.Size = new System.Drawing.Size(43, 25);
            this.timer2_minutes.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_minutes.TabIndex = 48;
            this.timer2_minutes.Text = "m";
            this.timer2_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer2_minutes.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer2_hours
            // 
            this.timer2_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer2_hours.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer2_hours.ForeColor = System.Drawing.Color.Black;
            this.timer2_hours.Location = new System.Drawing.Point(398, 246);
            this.timer2_hours.Name = "timer2_hours";
            this.timer2_hours.Size = new System.Drawing.Size(43, 25);
            this.timer2_hours.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_hours.TabIndex = 47;
            this.timer2_hours.Text = "h";
            this.timer2_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer2_hours.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel24
            // 
            this.metroLabel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroLabel24.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel24.ForeColor = System.Drawing.Color.Black;
            this.metroLabel24.Location = new System.Drawing.Point(364, 246);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(25, 25);
            this.metroLabel24.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel24.TabIndex = 46;
            this.metroLabel24.Text = "d";
            this.metroLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer2_days
            // 
            this.timer2_days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timer2_days.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timer2_days.ForeColor = System.Drawing.Color.Black;
            this.timer2_days.Location = new System.Drawing.Point(315, 246);
            this.timer2_days.Name = "timer2_days";
            this.timer2_days.Size = new System.Drawing.Size(43, 25);
            this.timer2_days.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_days.TabIndex = 45;
            this.timer2_days.Text = "d";
            this.timer2_days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer2_days.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1_optionShowMessageBox
            // 
            this.timer1_optionShowMessageBox.AutoSize = true;
            this.timer1_optionShowMessageBox.Location = new System.Drawing.Point(23, 171);
            this.timer1_optionShowMessageBox.Name = "timer1_optionShowMessageBox";
            this.timer1_optionShowMessageBox.Size = new System.Drawing.Size(123, 15);
            this.timer1_optionShowMessageBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer1_optionShowMessageBox.TabIndex = 53;
            this.timer1_optionShowMessageBox.Text = "Show Message Box";
            this.timer1_optionShowMessageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer1_optionShowMessageBox.UseCustomBackColor = true;
            this.timer1_optionShowMessageBox.UseSelectable = true;
            this.timer1_optionShowMessageBox.CheckedChanged += new System.EventHandler(this.timer1_optionShowMessageBox_CheckedChanged);
            // 
            // timer2_optionShowMessageBox
            // 
            this.timer2_optionShowMessageBox.AutoSize = true;
            this.timer2_optionShowMessageBox.Location = new System.Drawing.Point(276, 171);
            this.timer2_optionShowMessageBox.Name = "timer2_optionShowMessageBox";
            this.timer2_optionShowMessageBox.Size = new System.Drawing.Size(123, 15);
            this.timer2_optionShowMessageBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.timer2_optionShowMessageBox.TabIndex = 54;
            this.timer2_optionShowMessageBox.Text = "Show Message Box";
            this.timer2_optionShowMessageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timer2_optionShowMessageBox.UseCustomBackColor = true;
            this.timer2_optionShowMessageBox.UseSelectable = true;
            this.timer2_optionShowMessageBox.CheckedChanged += new System.EventHandler(this.timer2_optionShowMessageBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.timer2_optionShowMessageBox);
            this.Controls.Add(this.timer1_optionShowMessageBox);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.timer2_seconds);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.timer2_minutes);
            this.Controls.Add(this.timer2_hours);
            this.Controls.Add(this.metroLabel24);
            this.Controls.Add(this.timer2_days);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.timer1_seconds);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.timer1_minutes);
            this.Controls.Add(this.timer1_hours);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.timer1_days);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.timer2_optionShowWindowsToast);
            this.Controls.Add(this.timer1_optionShowWindowsToast);
            this.Controls.Add(this.timer2_optionPlaySound);
            this.Controls.Add(this.timer1_optionPlaySound);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private MetroFramework.Controls.MetroCheckBox timer1_optionPlaySound;
        private MetroFramework.Controls.MetroCheckBox timer2_optionPlaySound;
        private MetroFramework.Controls.MetroCheckBox timer1_optionShowWindowsToast;
        private MetroFramework.Controls.MetroCheckBox timer2_optionShowWindowsToast;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel timer1_days;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel timer1_hours;
        private MetroFramework.Controls.MetroLabel timer1_minutes;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel timer1_seconds;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel timer2_seconds;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel timer2_minutes;
        private MetroFramework.Controls.MetroLabel timer2_hours;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel timer2_days;
        private MetroFramework.Controls.MetroCheckBox timer1_optionShowMessageBox;
        private MetroFramework.Controls.MetroCheckBox timer2_optionShowMessageBox;
    }
}

