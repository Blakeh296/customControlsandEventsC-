namespace CustomControls
{
    partial class ColorSelection
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
            this.lblRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(6, 37);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(34, 16);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.SystemColors.Control;
            this.tbRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbRed.Location = new System.Drawing.Point(39, 21);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(250, 45);
            this.tbRed.TabIndex = 1;
            this.tbRed.TickFrequency = 5;
            this.tbRed.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(6, 117);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 16);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(5, 78);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(45, 16);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(42, 69);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(250, 45);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(39, 107);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(250, 45);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.TickFrequency = 5;
            this.tbBlue.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(9, 158);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(280, 77);
            this.pnlColor.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Controls.Add(this.pnlColor);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.lblBlue);
            this.groupBox1.Controls.Add(this.tbRed);
            this.groupBox1.Controls.Add(this.tbBlue);
            this.groupBox1.Controls.Add(this.tbGreen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 257);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ColorSelection";
            // 
            // ColorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorSelection";
            this.Size = new System.Drawing.Size(305, 263);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
