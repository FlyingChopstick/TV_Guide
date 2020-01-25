namespace TV_Guide
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
            this.set_date = new System.Windows.Forms.DateTimePicker();
            this.label_select_date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.end_time = new System.Windows.Forms.DateTimePicker();
            this.start_time = new System.Windows.Forms.DateTimePicker();
            this.but_search = new System.Windows.Forms.Button();
            this.genre_box = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_genre_enter = new System.Windows.Forms.RadioButton();
            this.rb_genre_select = new System.Windows.Forms.RadioButton();
            this.select_genre = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rb_channel_select = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.channel_box = new System.Windows.Forms.GroupBox();
            this.rb_channel_enter = new System.Windows.Forms.RadioButton();
            this.label_start_at = new System.Windows.Forms.Label();
            this.label_end_at = new System.Windows.Forms.Label();
            this.time_box = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.genre_box.SuspendLayout();
            this.channel_box.SuspendLayout();
            this.time_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // set_date
            // 
            this.set_date.CustomFormat = "dddd, d MMM yyyy";
            this.set_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.set_date.Location = new System.Drawing.Point(12, 57);
            this.set_date.Name = "set_date";
            this.set_date.Size = new System.Drawing.Size(243, 26);
            this.set_date.TabIndex = 13;
            // 
            // label_select_date
            // 
            this.label_select_date.AutoSize = true;
            this.label_select_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_select_date.Location = new System.Drawing.Point(8, 31);
            this.label_select_date.Name = "label_select_date";
            this.label_select_date.Size = new System.Drawing.Size(134, 24);
            this.label_select_date.TabIndex = 9;
            this.label_select_date.Text = "Select the date";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(294, 505);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new show";
            // 
            // end_time
            // 
            this.end_time.CustomFormat = "HH:mm";
            this.end_time.Enabled = false;
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
            this.start_time.Enabled = false;
            this.start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time.Location = new System.Drawing.Point(10, 64);
            this.start_time.Name = "start_time";
            this.start_time.ShowUpDown = true;
            this.start_time.Size = new System.Drawing.Size(95, 29);
            this.start_time.TabIndex = 14;
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(103, 458);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(93, 43);
            this.but_search.TabIndex = 12;
            this.but_search.Text = "Add";
            this.but_search.UseVisualStyleBackColor = true;
            // 
            // genre_box
            // 
            this.genre_box.Controls.Add(this.textBox1);
            this.genre_box.Controls.Add(this.rb_genre_enter);
            this.genre_box.Controls.Add(this.rb_genre_select);
            this.genre_box.Controls.Add(this.select_genre);
            this.genre_box.Location = new System.Drawing.Point(6, 100);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(282, 112);
            this.genre_box.TabIndex = 20;
            this.genre_box.TabStop = false;
            this.genre_box.Text = "Genre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 29);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Enter a new channel";
            // 
            // rb_genre_enter
            // 
            this.rb_genre_enter.AutoSize = true;
            this.rb_genre_enter.Location = new System.Drawing.Point(6, 80);
            this.rb_genre_enter.Name = "rb_genre_enter";
            this.rb_genre_enter.Size = new System.Drawing.Size(14, 13);
            this.rb_genre_enter.TabIndex = 22;
            this.rb_genre_enter.TabStop = true;
            this.rb_genre_enter.UseVisualStyleBackColor = true;
            // 
            // rb_genre_select
            // 
            this.rb_genre_select.AutoSize = true;
            this.rb_genre_select.Location = new System.Drawing.Point(6, 39);
            this.rb_genre_select.Name = "rb_genre_select";
            this.rb_genre_select.Size = new System.Drawing.Size(14, 13);
            this.rb_genre_select.TabIndex = 21;
            this.rb_genre_select.TabStop = true;
            this.rb_genre_select.UseVisualStyleBackColor = true;
            // 
            // select_genre
            // 
            this.select_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.select_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_genre.FormattingEnabled = true;
            this.select_genre.Location = new System.Drawing.Point(22, 30);
            this.select_genre.Name = "select_genre";
            this.select_genre.Size = new System.Drawing.Size(243, 32);
            this.select_genre.TabIndex = 20;
            this.select_genre.Text = "Click to select";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 29);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Enter a new channel";
            // 
            // rb_channel_select
            // 
            this.rb_channel_select.AutoSize = true;
            this.rb_channel_select.Location = new System.Drawing.Point(6, 39);
            this.rb_channel_select.Name = "rb_channel_select";
            this.rb_channel_select.Size = new System.Drawing.Size(14, 13);
            this.rb_channel_select.TabIndex = 21;
            this.rb_channel_select.TabStop = true;
            this.rb_channel_select.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 32);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Click to select";
            // 
            // channel_box
            // 
            this.channel_box.Controls.Add(this.textBox2);
            this.channel_box.Controls.Add(this.rb_channel_enter);
            this.channel_box.Controls.Add(this.rb_channel_select);
            this.channel_box.Controls.Add(this.comboBox1);
            this.channel_box.Location = new System.Drawing.Point(6, 218);
            this.channel_box.Name = "channel_box";
            this.channel_box.Size = new System.Drawing.Size(282, 112);
            this.channel_box.TabIndex = 24;
            this.channel_box.TabStop = false;
            this.channel_box.Text = "Channel";
            // 
            // rb_channel_enter
            // 
            this.rb_channel_enter.AutoSize = true;
            this.rb_channel_enter.Location = new System.Drawing.Point(6, 80);
            this.rb_channel_enter.Name = "rb_channel_enter";
            this.rb_channel_enter.Size = new System.Drawing.Size(14, 13);
            this.rb_channel_enter.TabIndex = 22;
            this.rb_channel_enter.TabStop = true;
            this.rb_channel_enter.UseVisualStyleBackColor = true;
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
            // label_end_at
            // 
            this.label_end_at.AutoSize = true;
            this.label_end_at.Location = new System.Drawing.Point(141, 37);
            this.label_end_at.Name = "label_end_at";
            this.label_end_at.Size = new System.Drawing.Size(69, 24);
            this.label_end_at.TabIndex = 26;
            this.label_end_at.Text = "End at:";
            // 
            // time_box
            // 
            this.time_box.Controls.Add(this.label_end_at);
            this.time_box.Controls.Add(this.label_start_at);
            this.time_box.Controls.Add(this.end_time);
            this.time_box.Controls.Add(this.start_time);
            this.time_box.Location = new System.Drawing.Point(6, 336);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(282, 116);
            this.time_box.TabIndex = 27;
            this.time_box.TabStop = false;
            this.time_box.Text = "Time";
            // 
            // Add_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 505);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.genre_box.ResumeLayout(false);
            this.genre_box.PerformLayout();
            this.channel_box.ResumeLayout(false);
            this.channel_box.PerformLayout();
            this.time_box.ResumeLayout(false);
            this.time_box.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rb_channel_enter;
        private System.Windows.Forms.RadioButton rb_channel_select;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox genre_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_genre_enter;
        private System.Windows.Forms.RadioButton rb_genre_select;
        private System.Windows.Forms.ComboBox select_genre;
    }
}