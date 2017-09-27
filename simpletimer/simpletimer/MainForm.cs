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
        private Duration dur1 = new Duration(),
                         dur2 = new Duration(),
                         dur3 = new Duration();
        
        public System.Timers.Timer timer1 = new System.Timers.Timer();
        public System.Timers.Timer timer2 = new System.Timers.Timer();
        public bool t1started = false;
        public bool t2started = false;


        public MainForm()
        {
            InitializeComponent();
            timer1.Elapsed += new ElapsedEventHandler(timer1Elapsed);
            timer2.Elapsed += new ElapsedEventHandler(timer2Elapsed);
            dur3 = Duration.FromSeconds(1);
        }

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


        //functions. Too lazy for a seperate class
        private void timer1finished()
        {
            SetControlPropertyThreadSafe(timer1_seconds, "Text", "0");
            SetControlPropertyThreadSafe(startTimer1, "Text", "Start");
            MessageBox.Show("Timer 1 finished.");
        }

        private void timer2finished()
        {
            SetControlPropertyThreadSafe(timer2_seconds, "Text", "0");
            SetControlPropertyThreadSafe(startTimer2, "Text", "Start");
            MessageBox.Show("Timer 2 finished.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startTimer1_Click(object sender, EventArgs e)
        {
            if (t1started != true)
            {
                timer1.Enabled = true;
                timer1.Start();
                t1started = true;
                startTimer1.Text = "Stop";
            }

            else
            {
                timer1.Stop();
                t1started = false;
                startTimer1.Text = "Start";
            }
                
        }
        
        private void startTimer2_Click(object sender, EventArgs e)
        {
            if (t2started != true)
            {
                timer2.Enabled = true;
                timer2.Start();
                t2started = true;
                startTimer2.Text = "Stop";
            }

            else
            {
                timer2.Stop();
                t2started = false;
                startTimer2.Text = "Start";
            }
        }

        private void timer1Elapsed(object source, ElapsedEventArgs e)
        {
            SetControlPropertyThreadSafe(timer1_days, "Text", dur1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", dur1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", dur1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", dur1.Seconds.ToString());
            dur1 = dur1 - dur3; //dur3 is just a 1 second duration

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
            dur2 = dur2 - dur3;

            if (dur2.Days == 0 && dur2.Hours == 0 && dur2.Minutes == 0 && dur2.Seconds == 0)
            {
                timer2.Stop();
                timer2.Enabled = false;
                timer2finished();

            }
        }

        private void setTimeTimer1_Click(object sender, EventArgs e)
        {
            dur1 = Duration.FromDays(0);
            dur1 = Duration.FromHours(0);
            dur1 = Duration.FromMinutes(0);
            dur1 = Duration.FromSeconds(0);

            if(time1_days.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromDays(Convert.ToInt32(time1_days.Text)));
            }

            if(time1_hours.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromHours(Convert.ToInt32(time1_hours.Text)));
            }

            if(time1_minutes.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromMinutes(Convert.ToInt32(time1_minutes.Text)));
            }

            if(time1_seconds.Text != "")
            {
                dur1 = Duration.Add(dur1, Duration.FromSeconds(Convert.ToInt32(time1_seconds.Text)));
            }

            timer1.Interval = 1000;
        }

        private void setTimeTimer2_Click(object sender, EventArgs e)
        {
            dur2 = Duration.FromDays(0);
            dur2 = Duration.FromHours(0);
            dur2 = Duration.FromMinutes(0);
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

            timer2.Interval = 1000;
        }

        private void timer1_playsound_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_playsound_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
