namespace TV_Guide
{
    partial class main_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_channel = new System.Windows.Forms.Label();
            this.select_channel = new System.Windows.Forms.ComboBox();
            this.label_day = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.select_genre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toggle_end = new System.Windows.Forms.CheckBox();
            this.end_time = new System.Windows.Forms.DateTimePicker();
            this.toggle_start = new System.Windows.Forms.CheckBox();
            this.start_time = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.but_search = new System.Windows.Forms.Button();
            this.but_timetable = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.label_refresh_time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_channel
            // 
            this.label_channel.AutoSize = true;
            this.label_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_channel.Location = new System.Drawing.Point(6, 176);
            this.label_channel.Name = "label_channel";
            this.label_channel.Size = new System.Drawing.Size(166, 24);
            this.label_channel.TabIndex = 11;
            this.label_channel.Text = "Select the channel";
            // 
            // select_channel
            // 
            this.select_channel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.select_channel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.select_channel.FormattingEnabled = true;
            this.select_channel.Location = new System.Drawing.Point(10, 203);
            this.select_channel.Name = "select_channel";
            this.select_channel.Size = new System.Drawing.Size(243, 32);
            this.select_channel.TabIndex = 10;
            this.select_channel.Text = "Optional";
            this.select_channel.SelectedIndexChanged += new System.EventHandler(this.select_channel_SelectedIndexChanged);
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_day.Location = new System.Drawing.Point(6, 42);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(134, 24);
            this.label_day.TabIndex = 9;
            this.label_day.Text = "Select the date";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_genre.Location = new System.Drawing.Point(6, 109);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(148, 24);
            this.label_genre.TabIndex = 7;
            this.label_genre.Text = "Select the genre";
            // 
            // select_genre
            // 
            this.select_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.select_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_genre.FormattingEnabled = true;
            this.select_genre.Location = new System.Drawing.Point(10, 136);
            this.select_genre.Name = "select_genre";
            this.select_genre.Size = new System.Drawing.Size(243, 32);
            this.select_genre.TabIndex = 6;
            this.select_genre.Text = "Click to select";
            this.select_genre.SelectedIndexChanged += new System.EventHandler(this.select_genre_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toggle_end);
            this.groupBox1.Controls.Add(this.end_time);
            this.groupBox1.Controls.Add(this.toggle_start);
            this.groupBox1.Controls.Add(this.start_time);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.but_search);
            this.groupBox1.Controls.Add(this.label_channel);
            this.groupBox1.Controls.Add(this.select_channel);
            this.groupBox1.Controls.Add(this.label_day);
            this.groupBox1.Controls.Add(this.label_genre);
            this.groupBox1.Controls.Add(this.select_genre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 358);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // toggle_end
            // 
            this.toggle_end.AutoSize = true;
            this.toggle_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.toggle_end.Location = new System.Drawing.Point(144, 241);
            this.toggle_end.Name = "toggle_end";
            this.toggle_end.Size = new System.Drawing.Size(88, 28);
            this.toggle_end.TabIndex = 16;
            this.toggle_end.Text = "End at:";
            this.toggle_end.UseVisualStyleBackColor = true;
            this.toggle_end.CheckedChanged += new System.EventHandler(this.toggle_end_CheckedChanged);
            // 
            // end_time
            // 
            this.end_time.CustomFormat = "HH:mm";
            this.end_time.Enabled = false;
            this.end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_time.Location = new System.Drawing.Point(144, 271);
            this.end_time.Name = "end_time";
            this.end_time.ShowUpDown = true;
            this.end_time.Size = new System.Drawing.Size(95, 29);
            this.end_time.TabIndex = 15;
            this.end_time.ValueChanged += new System.EventHandler(this.end_time_ValueChanged);
            this.end_time.EnabledChanged += new System.EventHandler(this.end_time_EnabledChanged);
            // 
            // toggle_start
            // 
            this.toggle_start.AutoSize = true;
            this.toggle_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.toggle_start.Location = new System.Drawing.Point(21, 241);
            this.toggle_start.Name = "toggle_start";
            this.toggle_start.Size = new System.Drawing.Size(89, 28);
            this.toggle_start.TabIndex = 15;
            this.toggle_start.Text = "Start at:";
            this.toggle_start.UseVisualStyleBackColor = true;
            this.toggle_start.CheckedChanged += new System.EventHandler(this.toggle_start_CheckedChanged);
            // 
            // start_time
            // 
            this.start_time.CustomFormat = "HH:mm";
            this.start_time.Enabled = false;
            this.start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time.Location = new System.Drawing.Point(21, 271);
            this.start_time.Name = "start_time";
            this.start_time.ShowUpDown = true;
            this.start_time.Size = new System.Drawing.Size(95, 29);
            this.start_time.TabIndex = 14;
            this.start_time.ValueChanged += new System.EventHandler(this.start_time_ValueChanged);
            this.start_time.EnabledChanged += new System.EventHandler(this.start_time_EnabledChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd, d MMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(79, 306);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(93, 43);
            this.but_search.TabIndex = 12;
            this.but_search.Text = "Search";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // but_timetable
            // 
            this.but_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_timetable.Location = new System.Drawing.Point(265, 12);
            this.but_timetable.Name = "but_timetable";
            this.but_timetable.Size = new System.Drawing.Size(235, 40);
            this.but_timetable.TabIndex = 13;
            this.but_timetable.Text = "Show the timetable";
            this.but_timetable.UseVisualStyleBackColor = true;
            this.but_timetable.Click += new System.EventHandler(this.but_timetable_Click);
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add.Location = new System.Drawing.Point(265, 58);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(235, 40);
            this.but_add.TabIndex = 14;
            this.but_add.Text = "Add a new show";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.refresh.Location = new System.Drawing.Point(265, 104);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(235, 40);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Refresh the table";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // label_refresh_time
            // 
            this.label_refresh_time.AutoSize = true;
            this.label_refresh_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_refresh_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_refresh_time.Location = new System.Drawing.Point(301, 149);
            this.label_refresh_time.Name = "label_refresh_time";
            this.label_refresh_time.Size = new System.Drawing.Size(167, 18);
            this.label_refresh_time.TabIndex = 15;
            this.label_refresh_time.Text = "Auto-refresh in 60 seconds";
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.label_refresh_time);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_timetable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_window";
            this.Text = "TV Guide";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_channel;
        private System.Windows.Forms.ComboBox select_channel;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.ComboBox select_genre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Button but_timetable;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker start_time;
        private System.Windows.Forms.DateTimePicker end_time;
        private System.Windows.Forms.CheckBox toggle_end;
        private System.Windows.Forms.CheckBox toggle_start;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Label label_refresh_time;
    }
}

