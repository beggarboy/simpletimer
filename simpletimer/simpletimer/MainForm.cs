using MetroFramework.Forms;
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
        string timestring1 = "00:05:00";
        string timestring2 = "00:10:00";
        DateTime time1;  
        DateTime time2; 

        public MainForm()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timestring1 = "00:05:00";
            timestring2 = "00:10:00";
            time1 = DateTime.ParseExact(timestring1, "HH:mm:ss", CultureInfo.InvariantCulture);
            time2 = DateTime.ParseExact(timestring2, "HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private void cmdTimer1_Click(object sender, EventArgs e)
        {
            time1.Subtract(DateTime.Now);
            MessageBox.Show(time1.ToString());
        }

        private void cmdTimer2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdSetTime1_Click(object sender, EventArgs e)
        {
            if (txtBoxTime1.Text != "")
            {
                timestring1 = txtBoxTime1.Text;
                time1 = DateTime.ParseExact(timestring1, "HH:mm:ss", CultureInfo.InvariantCulture);
            }
        }

        private void cmdSetTime2_Click(object sender, EventArgs e)
        {
            if (txtBoxTime2.Text != "")
            {
                timestring2 = txtBoxTime1.Text;
                time2 = DateTime.ParseExact(timestring2, "HH:mm:ss", CultureInfo.InvariantCulture);
            }
        }
    }
}
