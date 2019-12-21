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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBclassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBendTime = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.TBFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBstartTime = new System.Windows.Forms.ComboBox();
            this.txtNumberofrooms = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.DGVinputData = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinputData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(127, 502);
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
            this.label2.Location = new System.Drawing.Point(134, 272);
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
            this.TBclassName.Location = new System.Drawing.Point(341, 269);
            this.TBclassName.Name = "TBclassName";
            this.TBclassName.Size = new System.Drawing.Size(200, 31);
            this.TBclassName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(79, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(379, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Time";
            // 
            // CBendTime
            // 
            this.CBendTime.BackColor = System.Drawing.Color.DarkRed;
            this.CBendTime.DropDownHeight = 100;
            this.CBendTime.DropDownWidth = 200;
            this.CBendTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBendTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBendTime.ForeColor = System.Drawing.Color.White;
            this.CBendTime.FormattingEnabled = true;
            this.CBendTime.IntegralHeight = false;
            this.CBendTime.Items.AddRange(new object[] {
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
            this.CBendTime.Location = new System.Drawing.Point(524, 334);
            this.CBendTime.Name = "CBendTime";
            this.CBendTime.Size = new System.Drawing.Size(93, 33);
            this.CBendTime.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(84, 563);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(212, 58);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate Optimal";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.AutoSize = true;
            this.inputPanel.BackColor = System.Drawing.Color.Black;
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.btnBrowse);
            this.inputPanel.Controls.Add(this.TBFileName);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.CBstartTime);
            this.inputPanel.Controls.Add(this.txtNumberofrooms);
            this.inputPanel.Controls.Add(this.btnInsert);
            this.inputPanel.Controls.Add(this.btnPrint);
            this.inputPanel.Controls.Add(this.btnGenerate);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.CBendTime);
            this.inputPanel.Controls.Add(this.TBclassName);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Location = new System.Drawing.Point(0, 50);
            this.inputPanel.MaximumSize = new System.Drawing.Size(800, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(684, 650);
            this.inputPanel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(208, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Insert A Class";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkRed;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Location = new System.Drawing.Point(563, 121);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 40);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // TBFileName
            // 
            this.TBFileName.BackColor = System.Drawing.Color.DarkRed;
            this.TBFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFileName.ForeColor = System.Drawing.SystemColors.Control;
            this.TBFileName.Location = new System.Drawing.Point(204, 84);
            this.TBFileName.Name = "TBFileName";
            this.TBFileName.ReadOnly = true;
            this.TBFileName.Size = new System.Drawing.Size(477, 31);
            this.TBFileName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Load from a File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(127, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Load Data From Csv File";
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
            this.CBstartTime.Location = new System.Drawing.Point(224, 334);
            this.CBstartTime.Name = "CBstartTime";
            this.CBstartTime.Size = new System.Drawing.Size(93, 33);
            this.CBstartTime.TabIndex = 13;
            // 
            // txtNumberofrooms
            // 
            this.txtNumberofrooms.BackColor = System.Drawing.Color.DarkRed;
            this.txtNumberofrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofrooms.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNumberofrooms.Location = new System.Drawing.Point(341, 499);
            this.txtNumberofrooms.Name = "txtNumberofrooms";
            this.txtNumberofrooms.Size = new System.Drawing.Size(200, 31);
            this.txtNumberofrooms.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkRed;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(236, 393);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(212, 58);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Load / Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(384, 563);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(212, 58);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Create CSV File";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DGVinputData
            // 
            this.DGVinputData.BackgroundColor = System.Drawing.Color.Black;
            this.DGVinputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVinputData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Delete,
            this.Edit});
            this.DGVinputData.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGVinputData.GridColor = System.Drawing.Color.Black;
            this.DGVinputData.Location = new System.Drawing.Point(687, 50);
            this.DGVinputData.Name = "DGVinputData";
            this.DGVinputData.Size = new System.Drawing.Size(913, 650);
            this.DGVinputData.TabIndex = 0;
            this.DGVinputData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVinputData_CellContentClick);
            this.DGVinputData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGVinputData_RowPostPaint);
            // 
            // Sr_No
            // 
            this.Sr_No.Frozen = true;
            this.Sr_No.HeaderText = "Sr. No.";
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
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
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.DGVinputData);
            this.Name = "Time_Table";
            this.Text = "Time_Table";
            this.Controls.SetChildIndex(this.DGVinputData, 0);
            this.Controls.SetChildIndex(this.inputPanel, 0);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVinputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBclassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBendTime;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.DataGridView DGVinputData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtNumberofrooms;
        private System.Windows.Forms.ComboBox CBstartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox TBFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
    }
}