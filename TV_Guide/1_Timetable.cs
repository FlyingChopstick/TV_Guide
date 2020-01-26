using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TV_Guide
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();

            Database db = new Database();
            String query = "SELECT * FROM tv_schedule";
            SQLiteCommand command = new SQLiteCommand(query, db.Connection);
           
            
            db.OpenConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    main_table.Rows.Add(new object[] 
                    {
                        reader.GetValue(reader.GetOrdinal("Day")).ToString(),
                        reader.GetValue(reader.GetOrdinal("Title")).ToString(),
                        reader.GetValue(reader.GetOrdinal("Genre")).ToString(),
                        reader.GetValue(reader.GetOrdinal("Channel")).ToString(),
                        reader.GetValue(reader.GetOrdinal("start")).ToString(),
                        reader.GetValue(reader.GetOrdinal("end")).ToString(),
                    }
                    );
                }
            }
            
            db.CloseConnection();



            main_table.Sort(Date, ListSortDirection.Ascending);
            this.Date.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
        }
    }
}
