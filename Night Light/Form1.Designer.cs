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
            this.btnSet = new System.Windows.Forms.Button();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.cboGamma = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBrightnessVal = new System.Windows.Forms.Label();
            this.cbxRunAtStartup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(127, 62);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(66, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.BackColor = System.Drawing.Color.DarkGray;
            this.tbrBrightness.Location = new System.Drawing.Point(12, 12);
            this.tbrBrightness.Maximum = 100;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Size = new System.Drawing.Size(261, 45);
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
            this.cboGamma.Location = new System.Drawing.Point(12, 63);
            this.cboGamma.Name = "cboGamma";
            this.cboGamma.Size = new System.Drawing.Size(108, 21);
            this.cboGamma.TabIndex = 2;
            this.cboGamma.Text = "Select Gamma";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBrightnessVal
            // 
            this.lblBrightnessVal.AutoSize = true;
            this.lblBrightnessVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessVal.Location = new System.Drawing.Point(277, 12);
            this.lblBrightnessVal.Name = "lblBrightnessVal";
            this.lblBrightnessVal.Size = new System.Drawing.Size(53, 37);
            this.lblBrightnessVal.TabIndex = 4;
            this.lblBrightnessVal.Text = "00";
            // 
            // cbxRunAtStartup
            // 
            this.cbxRunAtStartup.AutoSize = true;
            this.cbxRunAtStartup.Location = new System.Drawing.Point(284, 67);
            this.cbxRunAtStartup.Name = "cbxRunAtStartup";
            this.cbxRunAtStartup.Size = new System.Drawing.Size(95, 17);
            this.cbxRunAtStartup.TabIndex = 5;
            this.cbxRunAtStartup.Text = "Run at Startup";
            this.cbxRunAtStartup.UseVisualStyleBackColor = true;
            this.cbxRunAtStartup.CheckedChanged += new System.EventHandler(this.cbxRunAtStartup_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 97);
            this.Controls.Add(this.cbxRunAtStartup);
            this.Controls.Add(this.lblBrightnessVal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboGamma);
            this.Controls.Add(this.tbrBrightness);
            this.Controls.Add(this.btnSet);
            this.Name = "Form1";
            this.Text = "Night Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
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
    }
}

