namespace WFClock
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.userControlClock1 = new WFClock.UserControlClock();
            this.userControlClock2 = new WFClock.UserControlClock();
            this.userControlClock3 = new WFClock.UserControlClock();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userControlClock3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.userControlClock1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.userControlClock2);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 88;
            this.splitContainer2.TabIndex = 0;
            // 
            // userControlClock1
            // 
            this.userControlClock1.AutoSize = true;
            this.userControlClock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlClock1.ClockColor = System.Drawing.Color.White;
            this.userControlClock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClock1.IsDigital = true;
            this.userControlClock1.Location = new System.Drawing.Point(0, 0);
            this.userControlClock1.Name = "userControlClock1";
            this.userControlClock1.Size = new System.Drawing.Size(266, 88);
            this.userControlClock1.TabIndex = 0;
            // 
            // userControlClock2
            // 
            this.userControlClock2.AutoSize = true;
            this.userControlClock2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlClock2.ClockColor = System.Drawing.Color.White;
            this.userControlClock2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClock2.IsDigital = false;
            this.userControlClock2.Location = new System.Drawing.Point(0, 0);
            this.userControlClock2.Name = "userControlClock2";
            this.userControlClock2.Size = new System.Drawing.Size(266, 358);
            this.userControlClock2.TabIndex = 0;
            // 
            // userControlClock3
            // 
            this.userControlClock3.AutoSize = true;
            this.userControlClock3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlClock3.ClockColor = System.Drawing.Color.White;
            this.userControlClock3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClock3.IsDigital = false;
            this.userControlClock3.Location = new System.Drawing.Point(0, 0);
            this.userControlClock3.Name = "userControlClock3";
            this.userControlClock3.Size = new System.Drawing.Size(530, 450);
            this.userControlClock3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Zegar";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UserControlClock userControlClock1;
        private UserControlClock userControlClock2;
        private UserControlClock userControlClock3;
    }
}

