namespace LiteDownloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new MetroFramework.Controls.MetroTextBox();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Download Link:";
            // 
            // txtLink
            // 
            // 
            // 
            // 
            this.txtLink.CustomButton.Image = null;
            this.txtLink.CustomButton.Location = new System.Drawing.Point(441, 2);
            this.txtLink.CustomButton.Name = "";
            this.txtLink.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLink.CustomButton.TabIndex = 1;
            this.txtLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLink.CustomButton.UseSelectable = true;
            this.txtLink.CustomButton.Visible = false;
            this.txtLink.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLink.Lines = new string[] {
        "https://"};
            this.txtLink.Location = new System.Drawing.Point(221, 116);
            this.txtLink.MaxLength = 32767;
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PromptText = "Enter the download link here...";
            this.txtLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLink.SelectedText = "";
            this.txtLink.SelectionLength = 0;
            this.txtLink.SelectionStart = 0;
            this.txtLink.ShortcutsEnabled = true;
            this.txtLink.Size = new System.Drawing.Size(475, 36);
            this.txtLink.Style = MetroFramework.MetroColorStyle.Black;
            this.txtLink.TabIndex = 1;
            this.txtLink.Text = "https://";
            this.txtLink.UseSelectable = true;
            this.txtLink.WaterMark = "Enter the download link here...";
            this.txtLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = null;
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(381, 2);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.CustomButton.Visible = false;
            this.txtLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(163, 176);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PromptText = "Enter the download link here...";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(415, 36);
            this.txtLocation.Style = MetroFramework.MetroColorStyle.Black;
            this.txtLocation.TabIndex = 2;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMark = "Enter the download link here...";
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save as:";
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.White;
            this.btnLocation.Location = new System.Drawing.Point(584, 175);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(112, 37);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "Change Path";
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(221, 282);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(253, 68);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LiteDownloader.Properties.Resources.icons8_save_100;
            this.pictureBox3.Location = new System.Drawing.Point(23, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LiteDownloader.Properties.Resources.icons8_link_96;
            this.pictureBox2.Location = new System.Drawing.Point(23, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiteDownloader.Properties.Resources.icons8_download_52__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "       Welcome to LiteDownloader!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtLink;
        private MetroFramework.Controls.MetroTextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnDownload;
    }
}

