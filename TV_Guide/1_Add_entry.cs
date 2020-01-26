using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TV_Guide
{
    public partial class Add_entry : Form
    {
        public Add_entry()
        {
            InitializeComponent();

            //gets the data for the lists
            refresh_lists();
            //starts the refresh timer
            timer_refresh.Start();
        }



        //POPULATION
        //==========================================================================
        //refreshes <genres> and <channels> drop menus
        private void refresh_lists()
        {
            tick_count = 0;

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
                    string temp_genre = reader.GetValue(reader.GetOrdinal("genre")).ToString();
                    is_unique(temp_genre, genres);

                    string temp_channel = reader.GetValue(reader.GetOrdinal("channel")).ToString();
                    is_unique(temp_channel, channels);
                }
            }

            db.CloseConnection();

            //fill the GENRES dropbox
            genre_select.Items.Clear();
            foreach (string genre in genres)
            {
                genre_select.Items.Add(genre);
            }

            //fill the CHANNELS dropbox
            channel_select.Items.Clear();
            foreach (string channel in channels)
            {
                channel_select.Items.Add(channel);
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



        //DATA SOURCES
        //==========================================================================
        //list of genres
        private List<string> genres = new List<string>();
        //list of channels
        private List<string> channels = new List<string>();

        //selections
        //private string selected_Day = "No selection";
        //private string selected_Date = "No selection";
        private string selected_Genre = "No selection";
        private string selected_Channel = "No selection";
        //private string selected_start = "No selection";
        //private string selected_end = "No selection";
        //==========================================================================



        //swap between rb's
        private void change_state(RadioButton rb_select, ComboBox cb_select, RadioButton rb_enter, TextBox tb_enter)
        {
            if (rb_select.Checked == true)
            {
                cb_select.Enabled = true;

                tb_enter.Enabled = false;
            }
            else
            {
                tb_enter.Enabled = true;

                cb_select.Enabled = false;
            }
        }



        //GENRE
        //rb_select
        private void rb_genre_select_CheckedChanged(object sender, EventArgs e)
        {
            change_state(rb_genre_select, genre_select, rb_genre_enter, genre_enter);
        }



        //CHANNEL
        //rb_select
        private void rb_channel_select_CheckedChanged(object sender, EventArgs e)
        {
            change_state(rb_channel_select, channel_select, rb_channel_enter, channel_enter);
        }



        //TIME
        //==========================================================================
        //start
        private void start_time_ValueChanged(object sender, EventArgs e)
        {
            //selected_start = start_time.Value.ToString();
        }
        //end
        private void end_time_ValueChanged(object sender, EventArgs e)
        {
             //selected_end = end_time.Value.ToString();
        }

        private void set_date_ValueChanged(object sender, EventArgs e)
        {
            //selected_Day = set_date.Value.DayOfWeek.ToString();
            //selected_Date = set_date.Value.ToString("yyyy-MM-dd");
        }
        //==========================================================================



        //SELECTORS
        //==========================================================================
        //genre
        private void genre_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Genre = genre_select.Text;
        }
        //channel
        private void channel_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_Channel = channel_select.Text;
        }
        //==========================================================================



        //REFRESH TIMER
        //==========================================================================
        //tick counter (seconds)
        private int tick_count = 0;
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            tick_count += 1;
            if (tick_count == 60)
            {
                refresh_lists();
                tick_count = 0;
            }
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            Boolean ready = false;

            //DateTime checks
            Int32 compare_result;
            //if date is in the past
            compare_result = DateTime.Compare(set_date.Value, DateTime.Now);
            if (compare_result < 0)
            {
                MessageBox.Show("Error: Cannot add an event in the past.");
            }
            else
            {
                //if end_time <= start_time
                compare_result = DateTime.Compare(end_time.Value, start_time.Value);
                if (compare_result <= 0)
                {
                    MessageBox.Show("Error: invalid duration of the show.");
                }
                else
                {
                    ready = true;
                }
            }

            /**/
            if (ready==true)
            {
                Database db = new Database();

                String query = "INSERT INTO tv_schedule(Day,start,end,Channel,Title,Genre) VALUES (@Day, @start, @end, @Channel, @Title, @Genre)";
                SQLiteCommand command = new SQLiteCommand(query, db.Connection);
                db.OpenConnection();

                command.Parameters.AddWithValue("@Day", set_date.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@start", start_time.Value.ToString("HH:mm"));
                command.Parameters.AddWithValue("@end", end_time.Value.ToString("HH:mm"));
                command.Parameters.AddWithValue("@Channel", selected_Channel);
                command.Parameters.AddWithValue("@Title", enter_title.Text);
                command.Parameters.AddWithValue("@Genre", selected_Genre);

                command.ExecuteNonQuery();

                db.CloseConnection();

                MessageBox.Show("Added the event.");
                refresh_lists();
            }
            /**/
            //label1.Text = $"{selected_Date} {selected_Genre}{selected_Channel} {selected_start}{selected_end}";
            //label1.Text = $"{set_date.Value.ToString("yyyy-MM-dd")} {genre_select.Text}{channel_select.Text} {start_time.Value.ToString("HH:mm")}{end_time.Value.ToString("HH:mm")}";
        }
        //==========================================================================

        private void genre_enter_TextChanged(object sender, EventArgs e)
        {
            selected_Genre = genre_enter.Text;
        }

        private void channel_enter_TextChanged(object sender, EventArgs e)
        {
            selected_Channel = channel_enter.Text;
        }

        private void genre_select_TextChanged(object sender, EventArgs e)
        {
            selected_Genre = genre_select.Text;
        }

        private void channel_select_TextChanged(object sender, EventArgs e)
        {
            selected_Channel = channel_select.Text;
        }
    }
}
