using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;


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

        //connection string
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        //list of genres
        private List<string> genres = new List<string>();
        //list of channels
        private List<string> channels = new List<string>();

        //selections
        private string selected_Genre = "No selection";
        private string selected_Channel = "No selection";

        //refreshes <genres> and <channels> drop menus
        private void refresh_lists()
        {
            tick_count = 0;

            using (SQLiteConnection refresh_connection = new SQLiteConnection(ConnectionString))
            {
                refresh_connection.Open();
                String query = "SELECT * FROM tv_schedule";
                using (SQLiteCommand command = new SQLiteCommand(query, refresh_connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
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
                
                }
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

        //tick counter (seconds)
        private int tick_count = 0;

        //timer
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            tick_count += 1;
            if (tick_count == 60)
            {
                refresh_lists();
                tick_count = 0;
            }
        }

        //ADD BUTTON
        private void but_search_Click(object sender, EventArgs e)
        {
            //correctness of the new title
            Boolean is_correct = false;
            //is there an identical or an overlapping event in the table already
            Boolean is_avaliable = false;
            //validity checklist
            Boolean[] chck = { false, false, false, false, false, false, false, false, false, false };

            //CORRECTNESS CHECK
            //no title
            if (enter_title.Text == "")
            {
                MessageBox.Show("Enter the name of the title");
            }
            else
            {
                //DateTime checks
                Int32 compare_result;
                //if date is in the past
                compare_result = DateTime.Compare(set_date.Value, DateTime.Today);
                if (compare_result < 0)
                {
                    MessageBox.Show("Error: Cannot add an event in the past.");
                }
                else
                //if end_time <= start_time
                {
                    compare_result = DateTime.Compare(end_time.Value, start_time.Value);
                    if (compare_result <= 0)
                    {
                        MessageBox.Show("Error: invalid duration of the show.");
                    }
                    else
                    //if GENRE is not entered
                    {
                        if (genre_select.Text == "Select existing or enter new")
                        {
                            MessageBox.Show("Enter the genre.");
                        }
                        else
                        {
                            //if CHANNEL is not entered
                            if (channel_select.Text == "Select existing or enter new")
                            {
                                MessageBox.Show("Enter the channel.");
                            }
                            else
                            {
                                //title is correct
                                is_correct = true;
                            }
                        }
                    }
                }
            }

            //AVALIABILITY CHECK
            if (is_correct == true)
            {
                //DATE
                string selected_date = set_date.Value.ToString("yyyy-MM-dd");
                //START time
                string selected_start = start_time.Value.ToString("HH:mm");
                //END time
                string selected_end = end_time.Value.ToString("HH:mm");

                //if there is a similar title already
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    String query = "SELECT * FROM tv_schedule";
                    using (SQLiteCommand execute = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = execute.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //DAY, CHANNEL and TITLE are the same?
                                    chck[0] = reader.GetValue(reader.GetOrdinal("Day")).ToString() == selected_date;
                                    chck[1] = reader.GetValue(reader.GetOrdinal("Channel")).ToString() == selected_Channel;
                                    chck[2] = reader.GetValue(reader.GetOrdinal("Title")).ToString() == enter_title.Text;
                                    //START and END are the same?
                                    chck[3] = reader.GetValue(reader.GetOrdinal("start")).ToString() == selected_start;
                                    chck[4] = reader.GetValue(reader.GetOrdinal("end")).ToString() == selected_end;

                                    //START>r_st? <r_end?
                                    chck[5] = DateTime.Parse(reader.GetValue(reader.GetOrdinal("start")).ToString()) < DateTime.Parse(selected_start);
                                    chck[6] = DateTime.Parse(reader.GetValue(reader.GetOrdinal("end")).ToString()) > DateTime.Parse(selected_start);

                                    //END>r_st? <r_end?
                                    chck[7] = DateTime.Parse(reader.GetValue(reader.GetOrdinal("start")).ToString()) < DateTime.Parse(selected_end);
                                    chck[8] = DateTime.Parse(reader.GetValue(reader.GetOrdinal("end")).ToString()) > DateTime.Parse(selected_end);

                                    //if DAY, CHANNEL and TITLE are found
                                    if (chck[0] && chck[1] && chck[2])
                                    {
                                        //if the START and END are the same
                                        if (chck[3] && chck[4])
                                        {
                                            //this title is alredy existing
                                            MessageBox.Show("Error: That title already exists.");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        //if DAY and CHANNEL are found
                                        if (chck[0] && chck[1])
                                        {
                                            //if START overlaps with an existing title
                                            if (chck[5] && chck[6])
                                            {
                                                MessageBox.Show("Error: Start overlaps with an existing event."); break;
                                            }
                                            else
                                            //if END overlaps with an existing title
                                            {
                                                if (chck[7] && chck[8])
                                                {
                                                    MessageBox.Show("Error: End overlaps with an existing event."); break;
                                                }
                                                else
                                                {
                                                    is_avaliable = true; break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            is_avaliable = true; break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (is_avaliable == true)
                {
                    using (SQLiteConnection insert_connection = new SQLiteConnection(ConnectionString))
                    {
                        insert_connection.Open();

                        String query_add = "INSERT INTO tv_schedule(Day,start,end,Channel,Title,Genre) VALUES (@Day, @start, @end, @Channel, @Title, @Genre)";
                        using (SQLiteCommand command = new SQLiteCommand(query_add, insert_connection))
                        {
                            command.Parameters.AddWithValue("@Day", selected_date);
                            command.Parameters.AddWithValue("@start", selected_start);
                            command.Parameters.AddWithValue("@end", selected_end);
                            command.Parameters.AddWithValue("@Channel", selected_Channel);
                            command.Parameters.AddWithValue("@Title", enter_title.Text);
                            command.Parameters.AddWithValue("@Genre", selected_Genre);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Added the event.");
                            Add_entry.ActiveForm.Close();
                        }
                    }
                }
            }
        }

        //on change of genre, write into SELECTED_GENRE
        private void genre_select_TextChanged(object sender, EventArgs e)
        {
            selected_Genre = genre_select.Text;
        }

        //on change of genre, write into SELECTED_CHANNEL
        private void channel_select_TextChanged(object sender, EventArgs e)
        {
            selected_Channel = channel_select.Text;
        }


        private void genre_select_Click(object sender, EventArgs e)
        {
            genre_select.Text = "";
        }

        private void channel_select_Click(object sender, EventArgs e)
        {
            channel_select.Text = "";
        }
    }
}