using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using System.ComponentModel;

namespace TV_Guide
{
    public partial class Results : Form
    {
        //query_strings [0] - date, [1] - genre, [2] - title, [3] - channel, [4] - start, [5] - end
        //search_mode: [0] - 1genre/0title [1] - using channel, [2] - start selected, [3] - end selected
        public Results(string[] query_strings, Boolean[] search_mode)
        {
            
            InitializeComponent();

            string query = $"SELECT * FROM tv_schedule WHERE (Day = \'{query_strings[0]}\'";

            string[] parts =
                {
            $"Genre = \'{query_strings[1]}\'",
            $"Title = \'{query_strings[2]}\'",
            $"Channel = \'{query_strings[3]}\'",
            $"start > \'{query_strings[4]}\'",
            $"end < \'{query_strings[5]}\'"
                };

            switch (search_mode[0])
            {
                case true: query += $" AND {parts[0]}"; break;
                case false: query += $" AND {parts[1]}"; break;
            }
            switch (search_mode[1])
            {
                case true: query += $" AND {parts[2]}"; break;
                case false: break;
            }
            switch (search_mode[2])
            {
                case true: query += $" AND {parts[3]}"; break;
                case false: break;
            }
            switch (search_mode[3])
            {
                case true: query += $" AND {parts[4]}"; break;
                case false: break;
            }

            query = $"{query})";
            //label1.Text = query;
            display_query(query);
            
        }

        private void display_query(string query)
        {
            using (SQLiteConnection connection= new SQLiteConnection(ConnectionString))
            {
                List<DateTime> ends = new List<DateTime>();
                List<DateTime> starts = new List<DateTime>();


                connection.Open();
               


                using (SQLiteCommand execute = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = execute.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (table_result.RowCount > 1)
                                {
                                    DateTime next_start = DateTime.Parse(reader.GetValue(reader.GetOrdinal("start")).ToString());
                                    DateTime next_end = DateTime.Parse(reader.GetValue(reader.GetOrdinal("end")).ToString());

                                    if ((DateTime.Compare(starts[table_result.RowCount - 1], next_start) < 0)
                                        && (DateTime.Compare(ends[table_result.RowCount - 1], next_start) < 0))
                                    {
                                        table_result.Rows.Add(new object[]
                                        {
                                        //reader.GetValue(reader.GetOrdinal("Day")).ToString(),
                                        reader.GetValue(reader.GetOrdinal("Title")).ToString(),
                                        reader.GetValue(reader.GetOrdinal("Genre")).ToString(),
                                        reader.GetValue(reader.GetOrdinal("Channel")).ToString(),
                                        reader.GetValue(reader.GetOrdinal("start")).ToString(),
                                        reader.GetValue(reader.GetOrdinal("end")).ToString(),
                                        });

                                        starts.Add(DateTime.Parse(reader.GetValue(reader.GetOrdinal("start")).ToString()));
                                        ends.Add(DateTime.Parse(reader.GetValue(reader.GetOrdinal("end")).ToString()));
                                        //label1.Text = starts[1].ToString("HH:mm");
                                    }
                                }
                                else 
                                {
                                    table_result.Rows.Add(new object[]
                                    {
                                    //reader.GetValue(reader.GetOrdinal("Day")).ToString(),
                                    reader.GetValue(reader.GetOrdinal("Title")).ToString(),
                                    reader.GetValue(reader.GetOrdinal("Genre")).ToString(),
                                    reader.GetValue(reader.GetOrdinal("Channel")).ToString(),
                                    reader.GetValue(reader.GetOrdinal("start")).ToString(),
                                    reader.GetValue(reader.GetOrdinal("end")).ToString(),
                                    });

                                    starts.Add(DateTime.Parse(reader.GetValue(reader.GetOrdinal("start")).ToString()));
                                    ends.Add(DateTime.Parse(reader.GetValue(reader.GetOrdinal("end")).ToString()));
                                }
                                
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("No such titles.");
                        }
                    }
                }
            }


            table_result.Sort(time_start, ListSortDirection.Ascending);
        }


        //DATA SOURCES
        //==========================================================================
        //connection string
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        private List<string> titles;
        private List<string> genres;
        private List<string> channels;
        //private List<DateTime> starts;
        //private List<DateTime> ends;
        //==========================================================================



        //==========================================================================
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
                                string temp_genre = reader.GetValue(reader.GetOrdinal("genre")).ToString();
                                is_unique(temp_genre, genres);

                                string temp_channel = reader.GetValue(reader.GetOrdinal("channel")).ToString();
                                is_unique(temp_channel, channels);
                            }
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
    }
}
