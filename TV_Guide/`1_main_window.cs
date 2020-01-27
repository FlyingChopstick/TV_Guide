using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;

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
        //connection string
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        //list of titles
        private List<string> titles = new List<string>();
        //list of genres
        private List<string> genres = new List<string>();
        //list of channels
        private List<string> channels = new List<string>();

        //SELECTIONS
        private DateTime selected_Day = DateTime.Today;
        private string selected_Genre = "No selection";
        private string selected_Channel = "No selection";
        private string selected_start = "No selection";
        private string selected_end = "No selection";
        private string selected_Title = "No selection";

        //refreshes <genres> and <channels> drop menus
        private void refresh_lists()
        {
            using (SQLiteConnection read_connection = new SQLiteConnection(ConnectionString))
            {
                read_connection.Open();

                String query = "SELECT * FROM tv_schedule";
                using (SQLiteCommand command = new SQLiteCommand(query, read_connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //fill list with unique values
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string temp_title = reader.GetValue(reader.GetOrdinal("Title")).ToString();
                                is_unique(temp_title, titles);

                                string temp_genre = reader.GetValue(reader.GetOrdinal("genre")).ToString();
                                is_unique(temp_genre, genres);

                                string temp_channel = reader.GetValue(reader.GetOrdinal("channel")).ToString();
                                is_unique(temp_channel, channels);
                            }
                        }
                    }
                }
            }

            //fill the GENRES dropbox
            select_genre.Items.Clear();
            foreach (string genre in genres)
            {
                select_genre.Items.Add(genre);
            }

            //fill the CHANNELS dropbox
            select_channel.Items.Clear();
            select_channel.Items.Add("No selection");
            foreach (string channel in channels)
            {
                select_channel.Items.Add(channel);
            }

            cb_title.Items.Clear();
            foreach (string title in titles)
            {
                cb_title.Items.Add(title);
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
            //if sort by genre is selected, but no genre was provided
            if ((rb_by_genre.Checked == true) && (selected_Genre == "No selection"))
            {
                MessageBox.Show("Enter the genre.");
            }
            else
            {
                //if sort by title is selected, but no title was provided
                if ((rb_by_title.Checked == true) && (selected_Title == "No selection"))
                {
                    MessageBox.Show("Enter the title.");
                }
                else
                {
                    //if start and end are selected, but start>end
                    if ((toggle_start.Checked==true)&&(toggle_end.Checked==true)&&(DateTime.Compare(start_time.Value, end_time.Value) >= 0))
                    {
                        MessageBox.Show("Wrong duration.");
                    }
                    else
                    {
                        //pack necessery data in the string[]
                        //query_strings [0] - date, [1] - genre, [2] - title, [3] - channel, [4] - start, [5] - end
                        string[] query_strings =
                            {dateTimePicker1.Value.ToString("yyyy-MM-dd"),selected_Genre,selected_Title,selected_Channel,selected_start,selected_end};
                        //select the search parametres in the Boolean[]
                        //search_mode: [0] - 1genre/0title [1] - using channel, [2] - start selected, [3] - end selected
                        Boolean[] search_mode =
                            {true,true,true,true,};
                        
                        if (select_genre.Enabled == false)
                            search_mode[0] = false;

                        if (selected_Channel == "No selection")
                            search_mode[1] = false;

                        search_mode[2] = toggle_start.Checked;
                        search_mode[3] = toggle_end.Checked;

                        Results o_results = new Results(query_strings, search_mode);
                        o_results.ShowDialog();
                        refresh_lists();
                    }
                }
            }
        }

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

        //select the GENRE
        private void select_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Genre = select_genre.Text;
        }

        //select the CHANNEL
        private void select_channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Channel = select_channel.Text;
        }

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
                selected_start = start_time.Text;
        }

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
            selected_end = end_time.Text;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selected_Day = dateTimePicker1.Value;
        }

        private void rb_by_genre_CheckedChanged(object sender, EventArgs e)
        {
            select_genre.Enabled = true;
            cb_title.Enabled = false;
            selected_Title = "No selection";
        }
        private void rb_by_title_CheckedChanged(object sender, EventArgs e)
        {
            cb_title.Enabled = true;
            select_genre.Enabled = false;
            selected_Genre = "No selection";
        }
        private void select_genre_TextChanged(object sender, EventArgs e)
        {
            selected_Genre = select_genre.Text;
        }
        private void cb_title_TextChanged(object sender, EventArgs e)
        {
            selected_Title = cb_title.Text;
        }
        private void cb_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Title = cb_title.Text;
        }
    }
}