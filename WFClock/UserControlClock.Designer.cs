namespace WFClock
{
    partial class UserControlClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pictureBoxAnalog = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.typZegaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarczaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnalog)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDigitalClock.Location = new System.Drawing.Point(0, 0);
            this.labelDigitalClock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(841, 594);
            this.labelDigitalClock.TabIndex = 0;
            this.labelDigitalClock.Text = "label1";
            this.labelDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAnalog
            // 
            this.pictureBoxAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAnalog.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAnalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAnalog.Name = "pictureBoxAnalog";
            this.pictureBoxAnalog.Size = new System.Drawing.Size(841, 594);
            this.pictureBoxAnalog.TabIndex = 1;
            this.pictureBoxAnalog.TabStop = false;
            this.pictureBoxAnalog.SizeChanged += new System.EventHandler(this.pictureBoxAnalog_SizeChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typZegaraToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(130, 70);
            // 
            // typZegaraToolStripMenuItem
            // 
            this.typZegaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyfrowyToolStripMenuItem,
            this.analogowyToolStripMenuItem});
            this.typZegaraToolStripMenuItem.Name = "typZegaraToolStripMenuItem";
            this.typZegaraToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.typZegaraToolStripMenuItem.Text = "Typ zegara";
            // 
            // cyfrowyToolStripMenuItem
            // 
            this.cyfrowyToolStripMenuItem.Name = "cyfrowyToolStripMenuItem";
            this.cyfrowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cyfrowyToolStripMenuItem.Text = "Cyfrowy";
            this.cyfrowyToolStripMenuItem.Click += new System.EventHandler(this.cyfrowyToolStripMenuItem_Click);
            // 
            // analogowyToolStripMenuItem
            // 
            this.analogowyToolStripMenuItem.Name = "analogowyToolStripMenuItem";
            this.analogowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.analogowyToolStripMenuItem.Text = "Analogowy";
            this.analogowyToolStripMenuItem.Click += new System.EventHandler(this.analogowyToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tłoToolStripMenuItem,
            this.tarczaToolStripMenuItem,
            this.czcionkaToolStripMenuItem1});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // tłoToolStripMenuItem
            // 
            this.tłoToolStripMenuItem.Name = "tłoToolStripMenuItem";
            this.tłoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tłoToolStripMenuItem.Text = "Tło";
            this.tłoToolStripMenuItem.Click += new System.EventHandler(this.tłoToolStripMenuItem_Click);
            // 
            // tarczaToolStripMenuItem
            // 
            this.tarczaToolStripMenuItem.Name = "tarczaToolStripMenuItem";
            this.tarczaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tarczaToolStripMenuItem.Text = "Tarcza";
            this.tarczaToolStripMenuItem.Click += new System.EventHandler(this.tarczaToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem1
            // 
            this.czcionkaToolStripMenuItem1.Name = "czcionkaToolStripMenuItem1";
            this.czcionkaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.czcionkaToolStripMenuItem1.Text = "Czcionka";
            this.czcionkaToolStripMenuItem1.Click += new System.EventHandler(this.czcionkaToolStripMenuItem1_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // UserControlClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.pictureBoxAnalog);
            this.Controls.Add(this.labelDigitalClock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlClock";
            this.Size = new System.Drawing.Size(841, 594);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnalog)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDigitalClock;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PictureBox pictureBoxAnalog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem typZegaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarczaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
    }
}
