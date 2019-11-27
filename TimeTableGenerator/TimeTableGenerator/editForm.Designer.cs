namespace TimeTableGenerator
{
    partial class editForm
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
            this.CBstartTime = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBendTime = new System.Windows.Forms.ComboBox();
            this.TBclassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.CBstartTime.Location = new System.Drawing.Point(258, 190);
            this.CBstartTime.Name = "CBstartTime";
            this.CBstartTime.Size = new System.Drawing.Size(200, 33);
            this.CBstartTime.TabIndex = 24;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkRed;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(148, 370);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(212, 58);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert Class";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(51, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Class Name:";
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
            this.CBendTime.Location = new System.Drawing.Point(258, 265);
            this.CBendTime.Name = "CBendTime";
            this.CBendTime.Size = new System.Drawing.Size(200, 33);
            this.CBendTime.TabIndex = 20;
            // 
            // TBclassName
            // 
            this.TBclassName.BackColor = System.Drawing.Color.DarkRed;
            this.TBclassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclassName.ForeColor = System.Drawing.SystemColors.Control;
            this.TBclassName.Location = new System.Drawing.Point(258, 105);
            this.TBclassName.Name = "TBclassName";
            this.TBclassName.Size = new System.Drawing.Size(200, 31);
            this.TBclassName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Start Time:";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 532);
            this.Controls.Add(this.CBstartTime);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBendTime);
            this.Controls.Add(this.TBclassName);
            this.Controls.Add(this.label3);
            this.Name = "editForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TBclassName, 0);
            this.Controls.SetChildIndex(this.CBendTime, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.CBstartTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBstartTime;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBendTime;
        private System.Windows.Forms.TextBox TBclassName;
        private System.Windows.Forms.Label label3;
    }
}