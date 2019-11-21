namespace TimeTableGenerator.Template
{
    partial class templateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(templateForm));
            this.topPanelMover = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanelMover.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanelMover
            // 
            this.topPanelMover.BackColor = System.Drawing.Color.Maroon;
            this.topPanelMover.Controls.Add(this.label1);
            this.topPanelMover.Controls.Add(this.btnMinimize);
            this.topPanelMover.Controls.Add(this.btnMaximze);
            this.topPanelMover.Controls.Add(this.btnClose);
            this.topPanelMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelMover.Location = new System.Drawing.Point(0, 0);
            this.topPanelMover.Name = "topPanelMover";
            this.topPanelMover.Size = new System.Drawing.Size(1400, 50);
            this.topPanelMover.TabIndex = 0;
            this.topPanelMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseDown);
            this.topPanelMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseMove);
            this.topPanelMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(1250, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximze
            // 
            this.btnMaximze.BackColor = System.Drawing.Color.Black;
            this.btnMaximze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximze.FlatAppearance.BorderSize = 0;
            this.btnMaximze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximze.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaximze.Location = new System.Drawing.Point(1300, 0);
            this.btnMaximze.Name = "btnMaximze";
            this.btnMaximze.Size = new System.Drawing.Size(50, 50);
            this.btnMaximze.TabIndex = 1;
            this.btnMaximze.Text = "^";
            this.btnMaximze.UseVisualStyleBackColor = false;
            this.btnMaximze.Click += new System.EventHandler(this.btnMaximze_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1350, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(551, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Table Generator";
            // 
            // templateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 630);
            this.Controls.Add(this.topPanelMover);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "templateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "templateForm";
            this.Load += new System.EventHandler(this.templateForm_Load);
            this.topPanelMover.ResumeLayout(false);
            this.topPanelMover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanelMover;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximze;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
    }
}