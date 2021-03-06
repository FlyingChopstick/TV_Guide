﻿namespace TV_Guide
{
    partial class Add_entry
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
            this.set_date = new System.Windows.Forms.DateTimePicker();
            this.label_select_date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_title = new System.Windows.Forms.TextBox();
            this.time_box = new System.Windows.Forms.GroupBox();
            this.label_end_at = new System.Windows.Forms.Label();
            this.label_start_at = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.DateTimePicker();
            this.start_time = new System.Windows.Forms.DateTimePicker();
            this.channel_box = new System.Windows.Forms.GroupBox();
            this.channel_select = new System.Windows.Forms.ComboBox();
            this.genre_box = new System.Windows.Forms.GroupBox();
            this.genre_select = new System.Windows.Forms.ComboBox();
            this.but_search = new System.Windows.Forms.Button();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.time_box.SuspendLayout();
            this.channel_box.SuspendLayout();
            this.genre_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // set_date
            // 
            this.set_date.CustomFormat = "dddd, d MMM yyyy";
            this.set_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.set_date.Location = new System.Drawing.Point(12, 108);
            this.set_date.Name = "set_date";
            this.set_date.Size = new System.Drawing.Size(270, 26);
            this.set_date.TabIndex = 13;
            // 
            // label_select_date
            // 
            this.label_select_date.AutoSize = true;
            this.label_select_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_select_date.Location = new System.Drawing.Point(8, 82);
            this.label_select_date.Name = "label_select_date";
            this.label_select_date.Size = new System.Drawing.Size(134, 24);
            this.label_select_date.TabIndex = 9;
            this.label_select_date.Text = "Select the date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enter_title);
            this.groupBox1.Controls.Add(this.time_box);
            this.groupBox1.Controls.Add(this.channel_box);
            this.groupBox1.Controls.Add(this.genre_box);
            this.groupBox1.Controls.Add(this.set_date);
            this.groupBox1.Controls.Add(this.but_search);
            this.groupBox1.Controls.Add(this.label_select_date);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 490);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter the title";
            // 
            // enter_title
            // 
            this.enter_title.Location = new System.Drawing.Point(12, 50);
            this.enter_title.Name = "enter_title";
            this.enter_title.Size = new System.Drawing.Size(270, 29);
            this.enter_title.TabIndex = 29;
            // 
            // time_box
            // 
            this.time_box.Controls.Add(this.label_end_at);
            this.time_box.Controls.Add(this.label_start_at);
            this.time_box.Controls.Add(this.end_time);
            this.time_box.Controls.Add(this.start_time);
            this.time_box.Location = new System.Drawing.Point(6, 316);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(282, 116);
            this.time_box.TabIndex = 27;
            this.time_box.TabStop = false;
            this.time_box.Text = "Time";
            // 
            // label_end_at
            // 
            this.label_end_at.AutoSize = true;
            this.label_end_at.Location = new System.Drawing.Point(141, 37);
            this.label_end_at.Name = "label_end_at";
            this.label_end_at.Size = new System.Drawing.Size(69, 24);
            this.label_end_at.TabIndex = 26;
            this.label_end_at.Text = "End at:";
            // 
            // label_start_at
            // 
            this.label_start_at.AutoSize = true;
            this.label_start_at.Location = new System.Drawing.Point(6, 37);
            this.label_start_at.Name = "label_start_at";
            this.label_start_at.Size = new System.Drawing.Size(70, 24);
            this.label_start_at.TabIndex = 25;
            this.label_start_at.Text = "Start at:";
            // 
            // end_time
            // 
            this.end_time.CustomFormat = "HH:mm";
            this.end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_time.Location = new System.Drawing.Point(145, 64);
            this.end_time.Name = "end_time";
            this.end_time.ShowUpDown = true;
            this.end_time.Size = new System.Drawing.Size(95, 29);
            this.end_time.TabIndex = 15;
            // 
            // start_time
            // 
            this.start_time.CustomFormat = "HH:mm";
            this.start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time.Location = new System.Drawing.Point(10, 64);
            this.start_time.Name = "start_time";
            this.start_time.ShowUpDown = true;
            this.start_time.Size = new System.Drawing.Size(95, 29);
            this.start_time.TabIndex = 14;
            // 
            // channel_box
            // 
            this.channel_box.Controls.Add(this.channel_select);
            this.channel_box.Location = new System.Drawing.Point(6, 231);
            this.channel_box.Name = "channel_box";
            this.channel_box.Size = new System.Drawing.Size(282, 79);
            this.channel_box.TabIndex = 24;
            this.channel_box.TabStop = false;
            this.channel_box.Text = "Channel";
            // 
            // channel_select
            // 
            this.channel_select.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.channel_select.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.channel_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channel_select.FormattingEnabled = true;
            this.channel_select.Location = new System.Drawing.Point(6, 36);
            this.channel_select.Name = "channel_select";
            this.channel_select.Size = new System.Drawing.Size(270, 32);
            this.channel_select.Sorted = true;
            this.channel_select.TabIndex = 20;
            this.channel_select.Text = "Select existing or enter new";
            this.channel_select.TextChanged += new System.EventHandler(this.channel_select_TextChanged);
            this.channel_select.Click += new System.EventHandler(this.channel_select_Click);
            // 
            // genre_box
            // 
            this.genre_box.Controls.Add(this.genre_select);
            this.genre_box.Location = new System.Drawing.Point(6, 151);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(282, 74);
            this.genre_box.TabIndex = 20;
            this.genre_box.TabStop = false;
            this.genre_box.Text = "Genre";
            // 
            // genre_select
            // 
            this.genre_select.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genre_select.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genre_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_select.FormattingEnabled = true;
            this.genre_select.Location = new System.Drawing.Point(6, 30);
            this.genre_select.Name = "genre_select";
            this.genre_select.Size = new System.Drawing.Size(270, 32);
            this.genre_select.Sorted = true;
            this.genre_select.TabIndex = 20;
            this.genre_select.Text = "Select existing or enter new";
            this.genre_select.TextChanged += new System.EventHandler(this.genre_select_TextChanged);
            this.genre_select.Click += new System.EventHandler(this.genre_select_Click);
            // 
            // but_search
            // 
            this.but_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_search.Location = new System.Drawing.Point(98, 443);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(93, 43);
            this.but_search.TabIndex = 12;
            this.but_search.Text = "Add";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // Add_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 490);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.time_box.ResumeLayout(false);
            this.time_box.PerformLayout();
            this.channel_box.ResumeLayout(false);
            this.genre_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker set_date;
        private System.Windows.Forms.Label label_select_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker end_time;
        private System.Windows.Forms.DateTimePicker start_time;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.GroupBox time_box;
        private System.Windows.Forms.Label label_end_at;
        private System.Windows.Forms.Label label_start_at;
        private System.Windows.Forms.GroupBox channel_box;
        private System.Windows.Forms.ComboBox channel_select;
        private System.Windows.Forms.GroupBox genre_box;
        private System.Windows.Forms.ComboBox genre_select;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.TextBox enter_title;
        private System.Windows.Forms.Label label2;
    }
}