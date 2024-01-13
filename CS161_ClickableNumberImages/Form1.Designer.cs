namespace CS161_ClickableNumberImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.onePic = new System.Windows.Forms.PictureBox();
            this.twoPic = new System.Windows.Forms.PictureBox();
            this.threePic = new System.Windows.Forms.PictureBox();
            this.fourPic = new System.Windows.Forms.PictureBox();
            this.fivePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.onePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePic)).BeginInit();
            this.SuspendLayout();
            // 
            // onePic
            // 
            this.onePic.Image = ((System.Drawing.Image)(resources.GetObject("onePic.Image")));
            this.onePic.Location = new System.Drawing.Point(12, 12);
            this.onePic.Name = "onePic";
            this.onePic.Size = new System.Drawing.Size(153, 245);
            this.onePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onePic.TabIndex = 0;
            this.onePic.TabStop = false;
            this.onePic.Click += new System.EventHandler(this.onePic_Click);
            // 
            // twoPic
            // 
            this.twoPic.Image = ((System.Drawing.Image)(resources.GetObject("twoPic.Image")));
            this.twoPic.Location = new System.Drawing.Point(182, 12);
            this.twoPic.Name = "twoPic";
            this.twoPic.Size = new System.Drawing.Size(153, 245);
            this.twoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoPic.TabIndex = 1;
            this.twoPic.TabStop = false;
            this.twoPic.Click += new System.EventHandler(this.twoPic_Click);
            // 
            // threePic
            // 
            this.threePic.Image = ((System.Drawing.Image)(resources.GetObject("threePic.Image")));
            this.threePic.Location = new System.Drawing.Point(352, 12);
            this.threePic.Name = "threePic";
            this.threePic.Size = new System.Drawing.Size(153, 245);
            this.threePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threePic.TabIndex = 2;
            this.threePic.TabStop = false;
            this.threePic.Click += new System.EventHandler(this.threePic_Click);
            // 
            // fourPic
            // 
            this.fourPic.Image = ((System.Drawing.Image)(resources.GetObject("fourPic.Image")));
            this.fourPic.Location = new System.Drawing.Point(522, 12);
            this.fourPic.Name = "fourPic";
            this.fourPic.Size = new System.Drawing.Size(153, 245);
            this.fourPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourPic.TabIndex = 3;
            this.fourPic.TabStop = false;
            this.fourPic.Click += new System.EventHandler(this.fourPic_Click);
            // 
            // fivePic
            // 
            this.fivePic.Image = ((System.Drawing.Image)(resources.GetObject("fivePic.Image")));
            this.fivePic.Location = new System.Drawing.Point(692, 12);
            this.fivePic.Name = "fivePic";
            this.fivePic.Size = new System.Drawing.Size(153, 245);
            this.fivePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fivePic.TabIndex = 4;
            this.fivePic.TabStop = false;
            this.fivePic.Click += new System.EventHandler(this.fivePic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 269);
            this.Controls.Add(this.fivePic);
            this.Controls.Add(this.fourPic);
            this.Controls.Add(this.threePic);
            this.Controls.Add(this.twoPic);
            this.Controls.Add(this.onePic);
            this.Name = "Form1";
            this.Text = "CS161 Clickable Number Image";
            ((System.ComponentModel.ISupportInitialize)(this.onePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox onePic;
        private System.Windows.Forms.PictureBox twoPic;
        private System.Windows.Forms.PictureBox threePic;
        private System.Windows.Forms.PictureBox fourPic;
        private System.Windows.Forms.PictureBox fivePic;
    }
}

