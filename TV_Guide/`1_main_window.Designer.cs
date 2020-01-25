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
            this.label_channel = new System.Windows.Forms.Label();
            this.select_channel = new System.Windows.Forms.ComboBox();
            this.label_day = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.select_genre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.but_search = new System.Windows.Forms.Button();
            this.but_timetable = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_channel
            // 
            this.label_channel.AutoSize = true;
            this.label_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_channel.Location = new System.Drawing.Point(6, 194);
            this.label_channel.Name = "label_channel";
            this.label_channel.Size = new System.Drawing.Size(166, 24);
            this.label_channel.TabIndex = 11;
            this.label_channel.Text = "Select the channel";
            // 
            // select_channel
            // 
            this.select_channel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.select_channel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_channel.FormattingEnabled = true;
            this.select_channel.Location = new System.Drawing.Point(10, 221);
            this.select_channel.Name = "select_channel";
            this.select_channel.Size = new System.Drawing.Size(218, 28);
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
            this.label_genre.Location = new System.Drawing.Point(6, 119);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(148, 24);
            this.label_genre.TabIndex = 7;
            this.label_genre.Text = "Select the genre";
            // 
            // select_genre
            // 
            this.select_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.select_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_genre.FormattingEnabled = true;
            this.select_genre.Location = new System.Drawing.Point(10, 146);
            this.select_genre.Name = "select_genre";
            this.select_genre.Size = new System.Drawing.Size(218, 28);
            this.select_genre.TabIndex = 6;
            this.select_genre.Text = "Click to select";
            this.select_genre.SelectedIndexChanged += new System.EventHandler(this.select_genre_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.but_search);
            this.groupBox1.Controls.Add(this.label_channel);
            this.groupBox1.Controls.Add(this.select_channel);
            this.groupBox1.Controls.Add(this.label_day);
            this.groupBox1.Controls.Add(this.label_genre);
            this.groupBox1.Controls.Add(this.select_genre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 323);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 29);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(79, 266);
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
            this.but_timetable.Location = new System.Drawing.Point(10, 375);
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
            this.but_add.Location = new System.Drawing.Point(10, 421);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(235, 40);
            this.but_add.TabIndex = 14;
            this.but_add.Text = "Add new show";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.refresh.Location = new System.Drawing.Point(10, 329);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(235, 40);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Refresh the table";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 468);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_timetable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_window";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

