using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TV_Guide
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();

            using (SQLiteConnection read_connection = new SQLiteConnection(ConnectionString))
            {
                read_connection.Open();
                String query = "SELECT * FROM tv_schedule";
                using (SQLiteCommand command = new SQLiteCommand(query, read_connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                main_table.Rows.Add(new object[]
                                {
                                    reader.GetValue(reader.GetOrdinal("Day")).ToString(),reader.GetValue(reader.GetOrdinal("Title")).ToString(),reader.GetValue(reader.GetOrdinal("Genre")).ToString(),reader.GetValue(reader.GetOrdinal("Channel")).ToString(),reader.GetValue(reader.GetOrdinal("start")).ToString(),reader.GetValue(reader.GetOrdinal("end")).ToString(),
                                }
                                );
                            }
                        }
                    }
                }
            }
            main_table.Sort(Date, ListSortDirection.Ascending);
            this.Date.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
        }

        //connection string
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}
