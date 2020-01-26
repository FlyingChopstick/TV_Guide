namespace TV_Guide
{
    partial class Timetable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_table = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).BeginInit();
            this.SuspendLayout();
            // 
            // main_table
            // 
            this.main_table.AllowUserToAddRows = false;
            this.main_table.AllowUserToDeleteRows = false;
            this.main_table.AllowUserToResizeRows = false;
            this.main_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.main_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.main_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.main_table.ColumnHeadersHeight = 35;
            this.main_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.name,
            this.type,
            this.channel,
            this.time_start,
            this.time_end});
            this.main_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table.Location = new System.Drawing.Point(0, 0);
            this.main_table.Name = "main_table";
            this.main_table.ReadOnly = true;
            this.main_table.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.main_table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.main_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.main_table.RowTemplate.ReadOnly = true;
            this.main_table.Size = new System.Drawing.Size(670, 401);
            this.main_table.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 73;
            // 
            // name
            // 
            this.name.HeaderText = "Title";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 68;
            // 
            // type
            // 
            this.type.HeaderText = "Genre";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 84;
            // 
            // channel
            // 
            this.channel.HeaderText = "Channel";
            this.channel.Name = "channel";
            this.channel.ReadOnly = true;
            // 
            // time_start
            // 
            this.time_start.HeaderText = "Begins";
            this.time_start.Name = "time_start";
            this.time_start.ReadOnly = true;
            this.time_start.Width = 89;
            // 
            // time_end
            // 
            this.time_end.HeaderText = "Ends";
            this.time_end.Name = "time_end";
            this.time_end.ReadOnly = true;
            this.time_end.Width = 75;
            // 
            // Timetable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 401);
            this.Controls.Add(this.main_table);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Timetable";
            this.Text = "Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView main_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_end;
    }
}