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

            //sets the initial visible values of time pickers
            start_time.Value = new DateTime(2019, 1, 1, 0, 0, 0);
            end_time.Value = new DateTime(2019, 1, 1, 0, 0, 0);

            //gets the data for the lists
            refresh_lists();
            //starts the refresh timer
            timer_refresh.Start();
        }

        //==========================================================================
        //refreshes <genres> and <channels> drop menus
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
                    string temp_genre = reader.GetValue(reader.GetOrdinal("type")).ToString();
                    is_unique(temp_genre, genres);

                    string temp_channel = reader.GetValue(reader.GetOrdinal("channel")).ToString();
                    is_unique(temp_channel, channels);
                }
            }

            db.CloseConnection();

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
        //checks if the <item> is not present in List<items>
        private void is_unique(string temp_item, List<string> items)
        {
            bool is_unique = true;
            //checks whether the genre is unique - adds to the droplist if true
            foreach (string item in items)
            {
                if (temp_item == item)
                    is_unique = false;
            }
            if (is_unique == true)
            {
                items.Add(temp_item);
            }
        }
        //==========================================================================



        //==========================================================================
        //NEW WINDOWS
        //TIMETABLE CALL
        private void but_timetable_Click(object sender, EventArgs e)
        {
            Timetable o_timetable = new Timetable();

            o_timetable.ShowDialog();
        }
        //ADD CALL
        private void but_add_Click(object sender, EventArgs e)
        {
            Add_entry o_add_entry = new Add_entry();

            o_add_entry.ShowDialog();

            refresh_lists();
        }
        //SEARCH CALL
        private void but_search_Click(object sender, EventArgs e)
        {
            Results o_results = new Results(dateTimePicker1.Value, selected_Genre, selected_Channel, selected_start, selected_end);

            o_results.ShowDialog();
        }
        //==========================================================================



        //==========================================================================
        //REFRESH
        private void refresh_Click(object sender, EventArgs e)
        {
            refresh_lists();
            tick_count = -1;
        }
        //REFRESH TIMER
        //tick counter (seconds)
        private int tick_count = 0;
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            tick_count += 1;
            label_refresh_time.Text = "Auto-refresh in " + (60 - tick_count).ToString() + " seconds";
            if (tick_count == 60)
            {
                refresh_lists();
                tick_count = 0;
            }
        }
        //==========================================================================



        //DATA SOURCES
        //==========================================================================
        //list of genres
        private List<string> genres = new List<string>();
        //list of channels
        private List<string> channels = new List<string>();
        
        //SELECTIONS
        private string selected_Genre = "No selection";
        private string selected_Channel = "No selection";
        private string selected_start = "No selection";
        private string selected_end = "No selection";
        //==========================================================================



        //==========================================================================
        //select the GENRE
        private void select_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Genre = select_genre.Text;
        }
        //==========================================================================



        //==========================================================================
        //select the CHANNEL
        private void select_channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Channel = select_channel.Text;
        }
        //==========================================================================



        //==========================================================================
        //select START_TIME
        //toggle
        private void toggle_start_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_start.Checked == true)
                start_time.Enabled = true;
            else
            {
                start_time.Enabled = false;

                selected_start = "No selection";
            }
        }
        //enabled
        private void start_time_EnabledChanged(object sender, EventArgs e)
        {
            if (start_time.Enabled == true)
                start_time.Value = DateTime.Now;
        }
        //value
        private void start_time_ValueChanged(object sender, EventArgs e)
        {
            if (start_time.Enabled == true)
                selected_start = start_time.Value.ToString();
        }
        //==========================================================================



        //==========================================================================
        //select END_TIME
        //toggle
        private void toggle_end_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_end.Checked == true)
                end_time.Enabled = true;
            else
            {
                end_time.Enabled = false;

                selected_end = "No selection";
            }
        }
        //enabled
        private void end_time_EnabledChanged(object sender, EventArgs e)
        {
            if (end_time.Enabled == true)
                end_time.Value = DateTime.Now;
        }
        //value
        private void end_time_ValueChanged(object sender, EventArgs e)
        {
            if (end_time.Enabled==true)
            selected_end = end_time.Value.ToString();
        }
        //==========================================================================
    }
}
