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
        private PeriodBuilder pbuilder = new PeriodBuilder(), p3builder = new PeriodBuilder();
        private Period p1, p2, p3;
        public System.Timers.Timer timer1 = new System.Timers.Timer();
        public System.Timers.Timer timer2 = new System.Timers.Timer();
        public bool t1started = false;
        public bool t2started = false;


        public MainForm()
        {
            InitializeComponent();
            timer1.Elapsed += new ElapsedEventHandler(timer1Elapsed);
            timer2.Elapsed += new ElapsedEventHandler(timer2Elapsed);
            p3builder.Seconds = 1;
            p3 = p3builder.Build();
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

        }

        private void timer2finished()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdTimer1_Click(object sender, EventArgs e)
        {
            if (t1started != true)
            {
                timer1.Enabled = true;
                timer1.Start();
                t1started = true;
            }

            else
            {
                timer1.Stop();
                t1started = false;
            }
                
        }
        
        private void cmdTimer2_Click(object sender, EventArgs e)
        {
            if (t2started != true)
            {
                timer2.Enabled = true;
                timer2.Start();
                t2started = true;
            }

            else
            {
                timer2.Stop();
                t2started = false;
            }
        }

        private void timer1Elapsed(object source, ElapsedEventArgs e)
        {
            SetControlPropertyThreadSafe(timer1_days, "Text", p1.Days.ToString());
            SetControlPropertyThreadSafe(timer1_hours, "Text", p1.Hours.ToString());
            SetControlPropertyThreadSafe(timer1_minutes, "Text", p1.Minutes.ToString());
            SetControlPropertyThreadSafe(timer1_seconds, "Text", p1.Seconds.ToString());
            p1 = p1 - p3;

            if(p1.Days == 0 && p1.Hours == 0 && p1.Minutes == 0 && p1.Seconds == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1finished();
            }

        }

        private void timer2Elapsed(object sender, ElapsedEventArgs e)
        {
            SetControlPropertyThreadSafe(timer2_days, "Text", p2.Days.ToString());
            SetControlPropertyThreadSafe(timer2_hours, "Text", p2.Hours.ToString());
            SetControlPropertyThreadSafe(timer2_minutes, "Text", p2.Minutes.ToString());
            SetControlPropertyThreadSafe(timer2_seconds, "Text", p2.Seconds.ToString());
            p2 = p2 - p3;

            if (p1.Days == 0 && p1.Hours == 0 && p1.Minutes == 0 && p1.Seconds == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer2finished();

            }
        }

        private void cmdSetTime1_Click(object sender, EventArgs e)
        {
            if(time1_days.Text != "")
            {
                pbuilder.Days = Convert.ToInt32(time1_days.Text);
            }

            if(time1_hours.Text != "")
            {
                pbuilder.Hours = Convert.ToInt32(time1_hours.Text);
            }

            if(time1_minutes.Text != "")
            {
                pbuilder.Minutes = Convert.ToInt32(time1_minutes.Text);
            }

            if(time1_seconds.Text != "")
            {
                pbuilder.Seconds = Convert.ToInt32(time1_seconds.Text);
            }

            p1 = pbuilder.Build();
            timer1.Interval = 1000;

        }

        private void cmdSetTime2_Click(object sender, EventArgs e)
        {
            if (time2_days.Text != "")
            {
                pbuilder.Days = Convert.ToInt32(time2_days.Text);
            }

            if (time2_hours.Text != "")
            {
                pbuilder.Hours = Convert.ToInt32(time2_hours.Text);
            }

            if (time2_minutes.Text != "")
            {
                pbuilder.Minutes = Convert.ToInt32(time2_minutes.Text);
            }

            if (time2_seconds.Text != "")
            {
                pbuilder.Seconds = Convert.ToInt32(time2_seconds.Text);
            }

            p2 = pbuilder.Build();
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
