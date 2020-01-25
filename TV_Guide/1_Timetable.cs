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

            //Font row_font = new Font("Arial", 14);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    main_table.Rows.Add(new object[] {
                        reader.GetValue(reader.GetOrdinal("day_date")).ToString(),
                        reader.GetValue(reader.GetOrdinal("name")).ToString(),
                        reader.GetValue(reader.GetOrdinal("type")).ToString(),
                        reader.GetValue(reader.GetOrdinal("channel")).ToString(),
                        reader.GetValue(reader.GetOrdinal("time_start")).ToString(),
                        reader.GetValue(reader.GetOrdinal("time_end")).ToString(),
                    });
                }
            }




            db.CloseConnection();

            main_table.Sort(Date, ListSortDirection.Ascending);
            this.Date.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    }
}
