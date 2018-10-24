namespace ControlandEventsDemo
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
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.lblHexi = new System.Windows.Forms.Label();
            this.tbHexiDecimal = new System.Windows.Forms.TextBox();
            this.colorSelection1 = new CustomControls.ColorSelection();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(323, 20);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(34, 16);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(320, 122);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 16);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(320, 73);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(45, 16);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // tbRed
            // 
            this.tbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRed.Location = new System.Drawing.Point(323, 36);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(100, 22);
            this.tbRed.TabIndex = 4;
            this.tbRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRed.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlue.Location = new System.Drawing.Point(323, 138);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(100, 22);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBlue.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGreen.Location = new System.Drawing.Point(323, 89);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(100, 22);
            this.tbGreen.TabIndex = 6;
            this.tbGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGreen.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblHexi
            // 
            this.lblHexi.AutoSize = true;
            this.lblHexi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexi.Location = new System.Drawing.Point(328, 172);
            this.lblHexi.Name = "lblHexi";
            this.lblHexi.Size = new System.Drawing.Size(88, 16);
            this.lblHexi.TabIndex = 8;
            this.lblHexi.Text = "Hexi Decimal";
            // 
            // tbHexiDecimal
            // 
            this.tbHexiDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHexiDecimal.Location = new System.Drawing.Point(323, 191);
            this.tbHexiDecimal.Name = "tbHexiDecimal";
            this.tbHexiDecimal.Size = new System.Drawing.Size(100, 22);
            this.tbHexiDecimal.TabIndex = 9;
            this.tbHexiDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorSelection1
            // 
            this.colorSelection1.ControlColor = System.Drawing.Color.Empty;
            this.colorSelection1.Location = new System.Drawing.Point(9, 9);
            this.colorSelection1.Name = "colorSelection1";
            this.colorSelection1.Size = new System.Drawing.Size(305, 263);
            this.colorSelection1.TabIndex = 10;
            this.colorSelection1.ColorChanged += new System.EventHandler(this.colorSelection1_ColorChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(334, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 26);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 284);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.colorSelection1);
            this.Controls.Add(this.tbHexiDecimal);
            this.Controls.Add(this.lblHexi);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.MaximumSize = new System.Drawing.Size(459, 322);
            this.MinimumSize = new System.Drawing.Size(459, 322);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.Label lblHexi;
        private System.Windows.Forms.TextBox tbHexiDecimal;
        private CustomControls.ColorSelection colorSelection1;
        private System.Windows.Forms.Button btnClose;
    }
}

