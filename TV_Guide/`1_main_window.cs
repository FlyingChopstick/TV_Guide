using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TV_Guide
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();

            refresh_lists();
        }

        private void refresh_lists()
        {
            Database db = new Database();
            String query = "SELECT * FROM tv_schedule";
            SQLiteCommand command = new SQLiteCommand(query, db.Connection);
            db.OpenConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            //fill list with unique values
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    /**
                    string temp_date = reader.GetValue(reader.GetOrdinal("day_date")).ToString();
                    if (is_unique(temp_date, dates) == true)
                        dates.Add(temp_date);
                    /**/

                    string temp_genre = reader.GetValue(reader.GetOrdinal("type")).ToString();
                    if (is_unique(temp_genre, genres) == true)
                        genres.Add(temp_genre);

                    string temp_channel = reader.GetValue(reader.GetOrdinal("channel")).ToString();
                    if (is_unique(temp_channel, channels) == true)
                        channels.Add(temp_channel);
                }
            }

            db.CloseConnection();


            //fill the DAYS dropbox
            select_day.Items.Clear();
            foreach (string day in dates)
            {
                select_day.Items.Add(day);
            }

            //fill the GENRES dropbox
            select_genre.Items.Clear();
            foreach (string genre in genres)
            {
                select_genre.Items.Add(genre);
            }

            //fill the CHANNELS dropbox
            select_channel.Items.Clear();
            foreach (string channel in channels)
            {
                select_channel.Items.Add(channel);
            }
        }

        private bool is_unique(string temp_item, List<string> items)
        {
            bool is_unique = true;
            //checks whether the genre is unique - adds to the droplist if true
            foreach (string item in items)
            {
                if (temp_item == item)
                    is_unique = false;
            }
            if (is_unique == true)
                return true;
            else return false;
        }


        private void but_timetable_Click(object sender, EventArgs e)
        {
            Timetable o_timetable = new Timetable();

            o_timetable.ShowDialog();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Add_entry o_add_entry = new Add_entry();

            o_add_entry.ShowDialog();

            refresh_lists();
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            Results o_results = new Results(dateTimePicker1.Value, selected_Genre, selected_Channel);

            o_results.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refresh_lists();
        }

        //data sources
        
        //replaced by datetimepicker
        private List<string> dates = new List<string>{
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };

        //list of genres
        private List<string> genres = new List<string>();
        //list of channels
        private List<string> channels = new List<string>();

        //replaced by raw DateTime
        //private string selected_Day = DateTime.Today.DayOfWeek.ToString();
        
        private string selected_Genre = "No selection";
        private string selected_Channel = "No selection";


        private void select_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Day_selection = select_day.SelectedIndex;
        }

        private string return_day(int Day_selected)
        {
            switch (Day_selected)
            {
                case 0: return "Monday";
                case 1: return "Tuesday";
                case 2: return "Wednesday";
                case 3: return "Thursday";
                case 4: return "Friday";
                case 5: return "Saturday";
                case 6: return "Sunday";

                default: return "Error: Wrong index";
            }
        }

        private string to_short_time(DateTime dateTime)
        {

            string long_time = dateTime.TimeOfDay.ToString(); //(dateTime.ToUniversalTime().ToString("s").Remove(0, 11));
            //return long_time.Remove(long_time.Length - 3);
            return long_time;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selected_Day = dateTimePicker1.Value.DayOfWeek.ToString();
        }

        private void select_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Genre = select_genre.Text;
        }

        private void select_channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Channel = select_channel.Text;
        }
    }
}
