namespace TimeTableGenerator
{
    partial class Time_Table
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
            this.CBnumberOfRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBclassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBstartTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBendTIme = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVoutputData = new System.Windows.Forms.DataGridView();
            this.DGVinputData = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVoutputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinputData)).BeginInit();
            this.SuspendLayout();
            // 
            // CBnumberOfRooms
            // 
            this.CBnumberOfRooms.BackColor = System.Drawing.Color.DarkRed;
            this.CBnumberOfRooms.DropDownHeight = 100;
            this.CBnumberOfRooms.DropDownWidth = 200;
            this.CBnumberOfRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBnumberOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBnumberOfRooms.ForeColor = System.Drawing.Color.White;
            this.CBnumberOfRooms.FormattingEnabled = true;
            this.CBnumberOfRooms.IntegralHeight = false;
            this.CBnumberOfRooms.Items.AddRange(new object[] {
            "...",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CBnumberOfRooms.Location = new System.Drawing.Point(247, 93);
            this.CBnumberOfRooms.Name = "CBnumberOfRooms";
            this.CBnumberOfRooms.Size = new System.Drawing.Size(190, 33);
            this.CBnumberOfRooms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Rooms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(40, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class Name:";
            // 
            // TBclassName
            // 
            this.TBclassName.BackColor = System.Drawing.Color.DarkRed;
            this.TBclassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclassName.ForeColor = System.Drawing.SystemColors.Control;
            this.TBclassName.Location = new System.Drawing.Point(247, 174);
            this.TBclassName.Name = "TBclassName";
            this.TBclassName.Size = new System.Drawing.Size(190, 31);
            this.TBclassName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(40, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time:";
            // 
            // CBstartTime
            // 
            this.CBstartTime.BackColor = System.Drawing.Color.DarkRed;
            this.CBstartTime.DropDownHeight = 100;
            this.CBstartTime.DropDownWidth = 200;
            this.CBstartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBstartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBstartTime.ForeColor = System.Drawing.Color.White;
            this.CBstartTime.FormattingEnabled = true;
            this.CBstartTime.IntegralHeight = false;
            this.CBstartTime.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CBstartTime.Location = new System.Drawing.Point(247, 253);
            this.CBstartTime.Name = "CBstartTime";
            this.CBstartTime.Size = new System.Drawing.Size(190, 33);
            this.CBstartTime.TabIndex = 5;
            this.CBstartTime.SelectedIndexChanged += new System.EventHandler(this.CBstartTime_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(40, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Time";
            // 
            // CBendTIme
            // 
            this.CBendTIme.BackColor = System.Drawing.Color.DarkRed;
            this.CBendTIme.DropDownHeight = 100;
            this.CBendTIme.DropDownWidth = 200;
            this.CBendTIme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBendTIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBendTIme.ForeColor = System.Drawing.Color.White;
            this.CBendTIme.FormattingEnabled = true;
            this.CBendTIme.IntegralHeight = false;
            this.CBendTIme.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CBendTIme.Location = new System.Drawing.Point(247, 334);
            this.CBendTIme.Name = "CBendTIme";
            this.CBendTIme.Size = new System.Drawing.Size(190, 33);
            this.CBendTIme.TabIndex = 7;
            this.CBendTIme.SelectedIndexChanged += new System.EventHandler(this.CBendTIme_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(247, 429);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(212, 58);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate Optimal";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // inputPanel
            // 
            this.inputPanel.AutoSize = true;
            this.inputPanel.Controls.Add(this.btnInsert);
            this.inputPanel.Controls.Add(this.CBnumberOfRooms);
            this.inputPanel.Controls.Add(this.btnGenerate);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.CBendTIme);
            this.inputPanel.Controls.Add(this.TBclassName);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.CBstartTime);
            this.inputPanel.Location = new System.Drawing.Point(0, 50);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(476, 580);
            this.inputPanel.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkRed;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(12, 429);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(212, 58);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert Class";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVoutputData);
            this.panel1.Controls.Add(this.DGVinputData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(468, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 580);
            this.panel1.TabIndex = 11;
            // 
            // DGVoutputData
            // 
            this.DGVoutputData.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVoutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVoutputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVoutputData.Location = new System.Drawing.Point(0, 292);
            this.DGVoutputData.Name = "DGVoutputData";
            this.DGVoutputData.Size = new System.Drawing.Size(918, 292);
            this.DGVoutputData.TabIndex = 1;
            // 
            // DGVinputData
            // 
            this.DGVinputData.BackgroundColor = System.Drawing.Color.Black;
            this.DGVinputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVinputData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.DGVinputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVinputData.GridColor = System.Drawing.Color.Black;
            this.DGVinputData.Location = new System.Drawing.Point(0, 0);
            this.DGVinputData.Name = "DGVinputData";
            this.DGVinputData.Size = new System.Drawing.Size(918, 292);
            this.DGVinputData.TabIndex = 0;
            this.DGVinputData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVinputData_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Time_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPanel);
            this.Name = "Time_Table";
            this.Text = "Time_Table";
            this.Controls.SetChildIndex(this.inputPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVoutputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBnumberOfRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBclassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBstartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBendTIme;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVoutputData;
        private System.Windows.Forms.DataGridView DGVinputData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}