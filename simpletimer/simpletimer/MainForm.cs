using MetroFramework.Forms;
using NodaTime;
using System;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;


namespace simpletimer
{
    public partial class MainForm : MetroForm
    {
        //Durations
        private Duration dur1 = new Duration(),         
                         dur2 = new Duration(),         
                         onesecond = new Duration(),
                         sessiondur1 = new Duration(),  //Total Session Duration for Timer 1
                         sessiondur2 = new Duration();  //Total Session Duration for Timer 2
        
        //Timers
        private System.Timers.Timer timer1 = new System.Timers.Timer();
        private System.Timers.Timer timer2 = new System.Timers.Timer();
        private bool t1started = false;
        private bool t2started = false;

        //Timer 1 Options
        private bool timer1_playsound = false;
        private bool timer1_windowstoast = false;
        private bool timer1_messagebox = false;

        //Timer 2 Options
        private bool timer2_playsound = false;
        private bool timer2_windowstoast = false;
        private bool timer2_messagebox = false;


        public MainForm()
        {
            InitializeComponent();
            //Hooking EventHandlers
            time1_days.TextChanged += new EventHandler(time1_days_TextChanged);
            time1_hours.TextChanged += new EventHandler(time1_hours_TextChanged);
            time1_minutes.TextChanged += new EventHandler(time1_minutes_TextChanged);
            time1_seconds.TextChanged += new EventHandler(time1_seconds_TextChanged);

            time2_days.TextChanged += new EventHandler(time2_days_TextChanged);
            time2_hours.TextChanged += new EventHandler(time2_hours_TextChanged);
            time2_minutes.TextChanged += new EventHandler(time2_minutes_TextChanged);
            time2_seconds.TextChanged += new EventHandler(time2_seconds_TextChanged);

            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Elapsed += new ElapsedEventHandler(timer1Elapsed);
            timer2.Elapsed += new ElapsedEventHandler(timer2Elapsed);
            onesecond = Duration.FromSeconds(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region helperfunctions
        //extra stuff to be able to write to labels from other threads. God I hate C# and its threading system
        private delegate void SetControlPropertyThreadSafeDelegate(
            Control control,
            string propertyName,
            object propertyValue);

        public static void SetControlPropertyThreadSafe(
            Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }

            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }
        #endregion

        private void startTimer1_Click(object sender, EventArgs e)
        {
            //Starting
            if (t1started != true)
            {
                //Lock Timefields
                time1_days.Enabled = false;
                time1_hours.Enabled = false;
                time1_minutes.Enabled = false;
                time1_seconds.Enabled = false;

                timer1.Enabled = true;
                timer1.Start();
                t1started = true;
                startTimer1.Text = "Stop";
            }

            //Stopping
            else
            {
                timer1.Stop();
                t1started = false;
                startTimer1.Text = "Start";

                //TODO: FIX FEATURE - BUGGED! Writes 0 when Value is 59
                //TODO: readd clean field conversion so that 0 becomes "" so the field gives the user a suggestion again
                //Unlock Timefields and Fill with Current Values
                time1_days.Text = timer1_days.Text;
                time1_hours.Text = timer1_hours.Text;
                time1_minutes.Text = timer1_minutes.Text;
                time1_seconds.Text = timer1_seconds.Text;

                time1_days.Enabled = true;
                time1_hours.Enabled = true;
                time1_minutes.Enabled = true;
                time1_seconds.Enabled = true;
            }
                
        }
        
        private void startTimer2_Click(object sender, EventArgs e)
        {
            //Starting
            if (t2started != true)
            {
                //Lock Timefields
                time2_days.Enabled = false;
                time2_hours.Enabled = false;
                time2_minutes.Enabled = false;
                time2_seconds.Enabled = false;

                timer2.Enabled = true;
                timer2.Start();
                t2started = true;
                startTimer2.Text = "Stop";
            }

            //Stopping
            else
            {
                timer2.Stop();
                t2started = false;
                startTimer2.Text = "Start";

                //TODO: FIX FEATURE - BUGGED! Writes 0 when Value is 59
                //Unlock Timefields and Fill with Current Values
                time2_days.Text = timer2_days.Text;
                time2_hours.Text = timer2_hours.Text;
                time2_minutes.Text = timer2_minutes.Text;
                time2_seconds.Text = timer2_seconds.Text;

                time2_days.Enabled = true;
                time2_hours.Enabled = true;
                time2_minutes.Enabled = true;
                time2_seconds.Enabled = true;
            }
        }

        private void timer1Elapsed(object source, ElapsedEventArgs e)
        {
            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
            dur1 = dur1 - onesecond; //dur3 is just a 1 second duration
            sessiondur1 = sessiondur1 + onesecond;
            SetControlPropertyThreadSafe(timer1_timepassed, "Text", sessiondur1.Days + "d:" + sessiondur1.Hours + "h:" + sessiondur1.Minutes + "m:" + sessiondur1.Seconds + "s");

            if(dur1.Days == 0 && dur1.Hours == 0 && dur1.Minutes == 0 && dur1.Seconds == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1finished();
            }

        }

        private void timer2Elapsed(object sender, ElapsedEventArgs e)
        {
            SetControlPropertyThreadSafe(timer2_days, "Text", dur2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", dur2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", dur2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", dur2.Seconds.ToString());
            dur2 = dur2 - onesecond;
            sessiondur2 = sessiondur2 + onesecond;
            SetControlPropertyThreadSafe(timer2_timepassed, "Text", sessiondur2.Days + "d:" + sessiondur2.Hours + "h:" + sessiondur2.Minutes + "m:" + sessiondur2.Seconds + "s");

            if (dur2.Days == 0 && dur2.Hours == 0 && dur2.Minutes == 0 && dur2.Seconds == 0)
            {
                timer2.Stop();
                timer2.Enabled = false;
                timer2finished();

            }
        }
        #region dynamicinputhandlers
        //Time1: Dynamic Input Handlers
        private void time1_days_TextChanged(object sender, EventArgs e)
        {
            dur1 = Duration.FromDays(0);
            if (time1_days.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromDays(Convert.ToInt32(time1_days.Text)));
            }

            if (time1_hours.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromHours(Convert.ToInt32(time1_hours.Text)));
            }

            if (time1_minutes.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromMinutes(Convert.ToInt32(time1_minutes.Text)));
            }

            if (time1_seconds.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromSeconds(Convert.ToInt32(time1_seconds.Text)));
            }


            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
        }

        private void time1_hours_TextChanged(object sender, EventArgs e)
        {
            dur1 = Duration.FromHours(0);
            if (time1_days.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromDays(Convert.ToInt32(time1_days.Text)));
            }

            if (time1_hours.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromHours(Convert.ToInt32(time1_hours.Text)));
            }

            if (time1_minutes.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromMinutes(Convert.ToInt32(time1_minutes.Text)));
            }

            if (time1_seconds.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromSeconds(Convert.ToInt32(time1_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
        }

        private void time1_minutes_TextChanged(object sender, EventArgs e)
        {
            dur1 = Duration.FromMinutes(0);
            if (time1_days.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromDays(Convert.ToInt32(time1_days.Text)));
            }

            if (time1_hours.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromHours(Convert.ToInt32(time1_hours.Text)));
            }

            if (time1_minutes.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromMinutes(Convert.ToInt32(time1_minutes.Text)));
            }

            if (time1_seconds.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromSeconds(Convert.ToInt32(time1_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
        }

        private void time1_seconds_TextChanged(object sender, EventArgs e)
        {
            dur1 = Duration.FromSeconds(0);

            if (time1_days.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromDays(Convert.ToInt32(time1_days.Text)));
            }

            if (time1_hours.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromHours(Convert.ToInt32(time1_hours.Text)));
            }

            if (time1_minutes.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromMinutes(Convert.ToInt32(time1_minutes.Text)));
            }

            if (time1_seconds.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromSeconds(Convert.ToInt32(time1_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
        }


        //Time2: Dynamic Input Handlers
        private void time2_days_TextChanged(object sender, EventArgs e)
        {
            dur2 = Duration.FromDays(0);
            if (time2_days.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromDays(Convert.ToInt32(time2_days.Text)));
            }

            if (time2_hours.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromHours(Convert.ToInt32(time2_hours.Text)));
            }

            if (time2_minutes.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromMinutes(Convert.ToInt32(time2_minutes.Text)));
            }

            if (time2_seconds.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromSeconds(Convert.ToInt32(time2_seconds.Text)));
            }


            SetControlPropertyThreadSafe(timer2_days, "Text", dur2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", dur2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", dur2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", dur2.Seconds.ToString());
        }

        private void time2_hours_TextChanged(object sender, EventArgs e)
        {
            dur2 = Duration.FromHours(0);
            if (time2_days.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromDays(Convert.ToInt32(time2_days.Text)));
            }

            if (time2_hours.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromHours(Convert.ToInt32(time2_hours.Text)));
            }

            if (time2_minutes.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromMinutes(Convert.ToInt32(time2_minutes.Text)));
            }

            if (time2_seconds.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromSeconds(Convert.ToInt32(time2_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer2_days, "Text", dur2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", dur2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", dur2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", dur2.Seconds.ToString());
        }

        private void time2_minutes_TextChanged(object sender, EventArgs e)
        {
            dur2 = Duration.FromMinutes(0);
            if (time2_days.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromDays(Convert.ToInt32(time2_days.Text)));
            }

            if (time2_hours.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromHours(Convert.ToInt32(time2_hours.Text)));
            }

            if (time2_minutes.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromMinutes(Convert.ToInt32(time2_minutes.Text)));
            }

            if (time2_seconds.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromSeconds(Convert.ToInt32(time2_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer2_days, "Text", dur2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", dur2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", dur2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", dur2.Seconds.ToString());
        }

        private void time2_seconds_TextChanged(object sender, EventArgs e)
        {
            dur2 = Duration.FromSeconds(0);

            if (time2_days.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromDays(Convert.ToInt32(time2_days.Text)));
            }

            if (time2_hours.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromHours(Convert.ToInt32(time2_hours.Text)));
            }

            if (time2_minutes.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromMinutes(Convert.ToInt32(time2_minutes.Text)));
            }

            if (time2_seconds.Text != "")
            {
                dur2 = Duration.Add(dur2, Duration.FromSeconds(Convert.ToInt32(time2_seconds.Text)));
            }

            SetControlPropertyThreadSafe(timer2_days, "Text", dur2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", dur2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", dur2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", dur2.Seconds.ToString());
        }
        #endregion

        #region notificationoptions
        private void timer1finished()
        {
            //playsound
            if(timer1_playsound)
            {

            }

            //windowstoast
            if(timer1_windowstoast)
            {

            }

            //messagebox
            if(timer1_messagebox)
            {
                MessageBox.Show("Timer 1 finished.");
            }

            //reset stuff
            SetControlPropertyThreadSafe(timer1_seconds, "Text", "0");
            SetControlPropertyThreadSafe(startTimer1, "Text", "Start");
        }

        private void timer2finished()
        {
            //playsound
            if(timer2_playsound)
            {

            }

            //windowstoast
            if(timer2_windowstoast)
            {

            }

            //messagebox
            if(timer2_messagebox)
            {
                MessageBox.Show("Timer 2 finished.");
            }

            //reset stuff
            SetControlPropertyThreadSafe(timer2_seconds, "Text", "0");
            SetControlPropertyThreadSafe(startTimer2, "Text", "Start");
            
        }

        //Timer 1 Options
        private void timer1_optionPlaySound_CheckedChanged(object sender, EventArgs e)
        {
            timer1_playsound = timer1_optionPlaySound.Checked ? true : false;
        }

        private void timer1_optionShowWindowsToast_CheckedChanged(object sender, EventArgs e)
        {
            timer1_windowstoast = timer1_optionShowWindowsToast.Checked ? true : false; 
        }

        private void timer1_optionShowMessageBox_CheckedChanged(object sender, EventArgs e)
        {
            timer1_messagebox = timer1_optionShowMessageBox.Checked ? true : false;
        }

        //Timer 2 Options
        private void timer2_optionPlaySound_CheckedChanged(object sender, EventArgs e)
        {
            timer2_playsound = timer2_optionPlaySound.Checked ? true : false;
        }

        private void timer2_optionShowWindowsToast_CheckedChanged(object sender, EventArgs e)
        {
            timer2_windowstoast = timer2_optionShowWindowsToast.Checked ? true : false;
        }

        private void timer2_optionShowMessageBox_CheckedChanged(object sender, EventArgs e)
        {
            timer2_messagebox = timer2_optionShowMessageBox.Checked ? true : false; 
        }

        #endregion
    }
}
