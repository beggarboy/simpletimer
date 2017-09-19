using MetroFramework.Forms;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpletimer
{
    public partial class MainForm : MetroForm
    {
        private PeriodBuilder pbuilder = new PeriodBuilder();
        private Period p1, p2;

        public MainForm()
        {
            InitializeComponent();
        }

        //functions. Too lazy for a seperate class
        private void buildTimer()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdTimer1_Click(object sender, EventArgs e)
        {

        }

        private void cmdTimer2_Click(object sender, EventArgs e)
        {
            
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

        }

        private void timer1_playsound_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_playsound_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
