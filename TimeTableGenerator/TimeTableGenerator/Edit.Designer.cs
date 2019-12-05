using System.Collections.Generic;

namespace TimeTableGenerator
{
    partial class Edit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBclassNameOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBcStartTimeNew = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcEndTimeNew = new System.Windows.Forms.Label();
            this.lblClassNameNew = new System.Windows.Forms.Label();
            this.CBcEndTimeNew = new System.Windows.Forms.ComboBox();
            this.TBclassNameNew = new System.Windows.Forms.TextBox();
            this.lblcStartTimeNew = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBcEndTimeOld = new System.Windows.Forms.TextBox();
            this.TBcStartTimeOld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(198, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(198, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Class Name:";
            // 
            // TBclassNameOld
            // 
            this.TBclassNameOld.BackColor = System.Drawing.Color.DarkRed;
            this.TBclassNameOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclassNameOld.ForeColor = System.Drawing.SystemColors.Control;
            this.TBclassNameOld.Location = new System.Drawing.Point(405, 239);
            this.TBclassNameOld.Name = "TBclassNameOld";
            this.TBclassNameOld.Size = new System.Drawing.Size(200, 31);
            this.TBclassNameOld.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(198, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Start Time:";
            // 
            // CBcStartTimeNew
            // 
            this.CBcStartTimeNew.BackColor = System.Drawing.Color.DarkRed;
            this.CBcStartTimeNew.DropDownHeight = 100;
            this.CBcStartTimeNew.DropDownWidth = 200;
            this.CBcStartTimeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBcStartTimeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcStartTimeNew.ForeColor = System.Drawing.Color.White;
            this.CBcStartTimeNew.FormattingEnabled = true;
            this.CBcStartTimeNew.IntegralHeight = false;
            this.CBcStartTimeNew.Items.AddRange(new object[] {
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
            this.CBcStartTimeNew.Location = new System.Drawing.Point(1202, 323);
            this.CBcStartTimeNew.Name = "CBcStartTimeNew";
            this.CBcStartTimeNew.Size = new System.Drawing.Size(200, 33);
            this.CBcStartTimeNew.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1092, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 58);
            this.button1.TabIndex = 37;
            this.button1.Text = "Update Class";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblcEndTimeNew
            // 
            this.lblcEndTimeNew.AutoSize = true;
            this.lblcEndTimeNew.BackColor = System.Drawing.Color.DarkRed;
            this.lblcEndTimeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcEndTimeNew.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcEndTimeNew.Location = new System.Drawing.Point(995, 403);
            this.lblcEndTimeNew.Name = "lblcEndTimeNew";
            this.lblcEndTimeNew.Size = new System.Drawing.Size(103, 25);
            this.lblcEndTimeNew.TabIndex = 36;
            this.lblcEndTimeNew.Text = "End Time";
            // 
            // lblClassNameNew
            // 
            this.lblClassNameNew.AutoSize = true;
            this.lblClassNameNew.BackColor = System.Drawing.Color.DarkRed;
            this.lblClassNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassNameNew.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClassNameNew.Location = new System.Drawing.Point(995, 241);
            this.lblClassNameNew.Name = "lblClassNameNew";
            this.lblClassNameNew.Size = new System.Drawing.Size(134, 25);
            this.lblClassNameNew.TabIndex = 32;
            this.lblClassNameNew.Text = "Class Name:";
            // 
            // CBcEndTimeNew
            // 
            this.CBcEndTimeNew.BackColor = System.Drawing.Color.DarkRed;
            this.CBcEndTimeNew.DropDownHeight = 100;
            this.CBcEndTimeNew.DropDownWidth = 200;
            this.CBcEndTimeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBcEndTimeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcEndTimeNew.ForeColor = System.Drawing.Color.White;
            this.CBcEndTimeNew.FormattingEnabled = true;
            this.CBcEndTimeNew.IntegralHeight = false;
            this.CBcEndTimeNew.Items.AddRange(new object[] {
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
            this.CBcEndTimeNew.Location = new System.Drawing.Point(1202, 398);
            this.CBcEndTimeNew.Name = "CBcEndTimeNew";
            this.CBcEndTimeNew.Size = new System.Drawing.Size(200, 33);
            this.CBcEndTimeNew.TabIndex = 35;
            // 
            // TBclassNameNew
            // 
            this.TBclassNameNew.BackColor = System.Drawing.Color.DarkRed;
            this.TBclassNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclassNameNew.ForeColor = System.Drawing.SystemColors.Control;
            this.TBclassNameNew.Location = new System.Drawing.Point(1202, 238);
            this.TBclassNameNew.Name = "TBclassNameNew";
            this.TBclassNameNew.Size = new System.Drawing.Size(200, 31);
            this.TBclassNameNew.TabIndex = 33;
            // 
            // lblcStartTimeNew
            // 
            this.lblcStartTimeNew.AutoSize = true;
            this.lblcStartTimeNew.BackColor = System.Drawing.Color.DarkRed;
            this.lblcStartTimeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcStartTimeNew.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcStartTimeNew.Location = new System.Drawing.Point(995, 322);
            this.lblcStartTimeNew.Name = "lblcStartTimeNew";
            this.lblcStartTimeNew.Size = new System.Drawing.Size(116, 25);
            this.lblcStartTimeNew.TabIndex = 34;
            this.lblcStartTimeNew.Text = "Start Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(214, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 33);
            this.label7.TabIndex = 39;
            this.label7.Text = "Old Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1085, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 33);
            this.label8.TabIndex = 40;
            this.label8.Text = "New Data";
            // 
            // TBcEndTimeOld
            // 
            this.TBcEndTimeOld.BackColor = System.Drawing.Color.DarkRed;
            this.TBcEndTimeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcEndTimeOld.ForeColor = System.Drawing.SystemColors.Control;
            this.TBcEndTimeOld.Location = new System.Drawing.Point(405, 401);
            this.TBcEndTimeOld.Name = "TBcEndTimeOld";
            this.TBcEndTimeOld.Size = new System.Drawing.Size(200, 31);
            this.TBcEndTimeOld.TabIndex = 41;
            // 
            // TBcStartTimeOld
            // 
            this.TBcStartTimeOld.BackColor = System.Drawing.Color.DarkRed;
            this.TBcStartTimeOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcStartTimeOld.ForeColor = System.Drawing.SystemColors.Control;
            this.TBcStartTimeOld.Location = new System.Drawing.Point(405, 320);
            this.TBcStartTimeOld.Name = "TBcStartTimeOld";
            this.TBcStartTimeOld.Size = new System.Drawing.Size(200, 31);
            this.TBcStartTimeOld.TabIndex = 42;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this.TBcStartTimeOld);
            this.Controls.Add(this.TBcEndTimeOld);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBcStartTimeNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcEndTimeNew);
            this.Controls.Add(this.lblClassNameNew);
            this.Controls.Add(this.CBcEndTimeNew);
            this.Controls.Add(this.TBclassNameNew);
            this.Controls.Add(this.lblcStartTimeNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBclassNameOld);
            this.Controls.Add(this.label3);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TBclassNameOld, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblcStartTimeNew, 0);
            this.Controls.SetChildIndex(this.TBclassNameNew, 0);
            this.Controls.SetChildIndex(this.CBcEndTimeNew, 0);
            this.Controls.SetChildIndex(this.lblClassNameNew, 0);
            this.Controls.SetChildIndex(this.lblcEndTimeNew, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.CBcStartTimeNew, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TBcEndTimeOld, 0);
            this.Controls.SetChildIndex(this.TBcStartTimeOld, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBclassNameOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBcStartTimeNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcEndTimeNew;
        private System.Windows.Forms.Label lblClassNameNew;
        private System.Windows.Forms.ComboBox CBcEndTimeNew;
        private System.Windows.Forms.TextBox TBclassNameNew;
        private System.Windows.Forms.Label lblcStartTimeNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBcEndTimeOld;
        private System.Windows.Forms.TextBox TBcStartTimeOld;
    }
}