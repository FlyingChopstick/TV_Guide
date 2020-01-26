namespace TV_Guide
{
    partial class Results
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
            this.table_result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_result)).BeginInit();
            this.SuspendLayout();
            // 
            // table_result
            // 
            this.table_result.AllowUserToAddRows = false;
            this.table_result.AllowUserToDeleteRows = false;
            this.table_result.AllowUserToResizeRows = false;
            this.table_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_result.ColumnHeadersHeight = 35;
            this.table_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.channel,
            this.time_start,
            this.time_end});
            this.table_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_result.Location = new System.Drawing.Point(0, 0);
            this.table_result.Name = "table_result";
            this.table_result.ReadOnly = true;
            this.table_result.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.table_result.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_result.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.table_result.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.table_result.RowTemplate.ReadOnly = true;
            this.table_result.Size = new System.Drawing.Size(800, 450);
            this.table_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
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
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_result);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.table_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_end;
    }
}