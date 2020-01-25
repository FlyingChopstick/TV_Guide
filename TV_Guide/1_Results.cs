using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Guide
{
    public partial class Results : Form
    {
        public Results(DateTime date, string genre, string channel, string start_time, string end_time)
        {
            InitializeComponent();


            label1.Text = date.DayOfWeek.ToString();
            label2.Text = genre;
            label3.Text = channel;
            label4.Text = start_time;
            label5.Text = end_time;
        }        
    }
}
