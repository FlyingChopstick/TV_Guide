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
        public Results()
        {
            InitializeComponent();

            //DateTime dateTime = new DateTime(2020, 1, 25, 15, 51, 0);
            //label1.Text = to_short_time(dateTime);
        }

        public Results(string Day)
        {
            InitializeComponent();


            label1.Text = Day;
        }

        public Results(DateTime date, string genre, string channel)
        {
            InitializeComponent();


            label1.Text = date.DayOfWeek.ToString();
            label2.Text = genre;
            label3.Text = channel;
        }

        public Results(string Day, string Genre, string Channel, string start_time, string end_time)
        {
            InitializeComponent();

            label1.Text = Day;
            label2.Text = Genre;
            label3.Text = Channel;
            label4.Text = start_time;
            label5.Text = end_time;
        }


        
    }
}
