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
            this.SuspendLayout();
            // 
            // topPanelMover
            // 
            this.topPanelMover.BackColor = System.Drawing.Color.Maroon;
            this.topPanelMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelMover.Location = new System.Drawing.Point(0, 0);
            this.topPanelMover.Name = "topPanelMover";
            this.topPanelMover.Size = new System.Drawing.Size(1400, 50);
            this.topPanelMover.TabIndex = 0;
            this.topPanelMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseDown);
            this.topPanelMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseMove);
            this.topPanelMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanelMover_MouseUp);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanelMover;
    }
}