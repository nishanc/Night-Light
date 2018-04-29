namespace Night_Light
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSet = new System.Windows.Forms.Button();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.cboGamma = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBrightnessVal = new System.Windows.Forms.Label();
            this.cbxRunAtStartup = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(169, 76);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(88, 28);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.BackColor = System.Drawing.Color.DarkGray;
            this.tbrBrightness.Location = new System.Drawing.Point(16, 15);
            this.tbrBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.tbrBrightness.Maximum = 100;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Size = new System.Drawing.Size(348, 56);
            this.tbrBrightness.TabIndex = 1;
            this.tbrBrightness.Scroll += new System.EventHandler(this.tbrBrightness_Scroll);
            // 
            // cboGamma
            // 
            this.cboGamma.FormattingEnabled = true;
            this.cboGamma.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.cboGamma.Location = new System.Drawing.Point(16, 78);
            this.cboGamma.Margin = new System.Windows.Forms.Padding(4);
            this.cboGamma.Name = "cboGamma";
            this.cboGamma.Size = new System.Drawing.Size(143, 24);
            this.cboGamma.TabIndex = 2;
            this.cboGamma.Text = "Select Gamma";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(264, 76);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBrightnessVal
            // 
            this.lblBrightnessVal.AutoSize = true;
            this.lblBrightnessVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessVal.Location = new System.Drawing.Point(366, 18);
            this.lblBrightnessVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightnessVal.Name = "lblBrightnessVal";
            this.lblBrightnessVal.Size = new System.Drawing.Size(64, 46);
            this.lblBrightnessVal.TabIndex = 4;
            this.lblBrightnessVal.Text = "00";
            // 
            // cbxRunAtStartup
            // 
            this.cbxRunAtStartup.AutoSize = true;
            this.cbxRunAtStartup.Location = new System.Drawing.Point(377, 80);
            this.cbxRunAtStartup.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRunAtStartup.Name = "cbxRunAtStartup";
            this.cbxRunAtStartup.Size = new System.Drawing.Size(122, 21);
            this.cbxRunAtStartup.TabIndex = 5;
            this.cbxRunAtStartup.Text = "Run at Startup";
            this.cbxRunAtStartup.UseVisualStyleBackColor = true;
            this.cbxRunAtStartup.CheckedChanged += new System.EventHandler(this.cbxRunAtStartup_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click to open, right click to exit";
            this.notifyIcon1.BalloonTipTitle = "Night Light";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Night Light";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 119);
            this.Controls.Add(this.cbxRunAtStartup);
            this.Controls.Add(this.lblBrightnessVal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboGamma);
            this.Controls.Add(this.tbrBrightness);
            this.Controls.Add(this.btnSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Night Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TrackBar tbrBrightness;
        private System.Windows.Forms.ComboBox cboGamma;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBrightnessVal;
        private System.Windows.Forms.CheckBox cbxRunAtStartup;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

