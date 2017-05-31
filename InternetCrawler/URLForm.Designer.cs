namespace InternetCrawler
{
    partial class URLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLForm));
            this.linkLabURL = new System.Windows.Forms.LinkLabel();
            this.labState = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.labDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabURL
            // 
            this.linkLabURL.AutoSize = true;
            this.linkLabURL.Location = new System.Drawing.Point(5, 5);
            this.linkLabURL.Name = "linkLabURL";
            this.linkLabURL.Size = new System.Drawing.Size(174, 13);
            this.linkLabURL.TabIndex = 0;
            this.linkLabURL.TabStop = true;
            this.linkLabURL.Text = "https://habrahabr.ru/post/139734/";
            this.linkLabURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabURL_LinkClicked);
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(5, 30);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(45, 13);
            this.labState.TabIndex = 1;
            this.labState.Text = "STATE:";
            // 
            // tbState
            // 
            this.tbState.Enabled = false;
            this.tbState.Location = new System.Drawing.Point(46, 27);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 2;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(190, 64);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(80, 13);
            this.labDescription.TabIndex = 3;
            this.labDescription.Text = "DESCRIPTION";
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(5, 80);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(423, 74);
            this.tbDescription.TabIndex = 4;
            // 
            // URLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 162);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.linkLabURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "URLForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "URL Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabURL;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.TextBox tbDescription;
    }
}