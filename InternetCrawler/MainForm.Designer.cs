namespace InternetCrawler
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.pbScanProgress = new System.Windows.Forms.ProgressBar();
            this.tbText = new System.Windows.Forms.TextBox();
            this.numUDURLs = new System.Windows.Forms.NumericUpDown();
            this.labURLCount = new System.Windows.Forms.Label();
            this.numUDThreads = new System.Windows.Forms.NumericUpDown();
            this.labThreads = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.spContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbScanning = new System.Windows.Forms.TextBox();
            this.lvScanning = new System.Windows.Forms.ListView();
            this.colHeaderURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbScanned = new System.Windows.Forms.TextBox();
            this.lvScanned = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDURLs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer2)).BeginInit();
            this.spContainer2.Panel1.SuspendLayout();
            this.spContainer2.Panel2.SuspendLayout();
            this.spContainer2.SuspendLayout();
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
            // spContainer
            // 
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 0);
            this.spContainer.Name = "spContainer";
            this.spContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.pbScanProgress);
            this.spContainer.Panel1.Controls.Add(this.tbText);
            this.spContainer.Panel1.Controls.Add(this.numUDURLs);
            this.spContainer.Panel1.Controls.Add(this.labURLCount);
            this.spContainer.Panel1.Controls.Add(this.numUDThreads);
            this.spContainer.Panel1.Controls.Add(this.labThreads);
            this.spContainer.Panel1.Controls.Add(this.btnStop);
            this.spContainer.Panel1.Controls.Add(this.btnPause);
            this.spContainer.Panel1.Controls.Add(this.btnStart);
            this.spContainer.Panel1.Controls.Add(this.tbURL);
            this.spContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.spContainer2);
            this.spContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.spContainer.Size = new System.Drawing.Size(1184, 602);
            this.spContainer.SplitterDistance = 94;
            this.spContainer.TabIndex = 0;
            // 
            // pbScanProgress
            // 
            this.pbScanProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbScanProgress.Location = new System.Drawing.Point(5, 79);
            this.pbScanProgress.Name = "pbScanProgress";
            this.pbScanProgress.Size = new System.Drawing.Size(1174, 10);
            this.pbScanProgress.Step = 1;
            this.pbScanProgress.TabIndex = 9;
            // 
            // tbText
            // 
            this.tbText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbText.Location = new System.Drawing.Point(5, 25);
            this.tbText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(1174, 20);
            this.tbText.TabIndex = 8;
            this.tbText.Tag = "";
            this.tbText.Text = "Enter TEXT to start searchig...";
            // 
            // numUDURLs
            // 
            this.numUDURLs.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUDURLs.Location = new System.Drawing.Point(350, 54);
            this.numUDURLs.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUDURLs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDURLs.Name = "numUDURLs";
            this.numUDURLs.Size = new System.Drawing.Size(65, 20);
            this.numUDURLs.TabIndex = 7;
            this.numUDURLs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labURLCount
            // 
            this.labURLCount.AutoSize = true;
            this.labURLCount.Location = new System.Drawing.Point(270, 56);
            this.labURLCount.Name = "labURLCount";
            this.labURLCount.Size = new System.Drawing.Size(74, 13);
            this.labURLCount.TabIndex = 6;
            this.labURLCount.Text = "URL\'s to scan";
            // 
            // numUDThreads
            // 
            this.numUDThreads.Location = new System.Drawing.Point(220, 54);
            this.numUDThreads.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numUDThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDThreads.Name = "numUDThreads";
            this.numUDThreads.Size = new System.Drawing.Size(40, 20);
            this.numUDThreads.TabIndex = 5;
            this.numUDThreads.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labThreads
            // 
            this.labThreads.AutoSize = true;
            this.labThreads.Location = new System.Drawing.Point(140, 56);
            this.labThreads.Name = "labThreads";
            this.labThreads.Size = new System.Drawing.Size(76, 13);
            this.labThreads.TabIndex = 4;
            this.labThreads.Text = "Threads count";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::InternetCrawler.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(95, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 25);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::InternetCrawler.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(50, 50);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 25);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::InternetCrawler.Properties.Resources.play;
            this.btnStart.Location = new System.Drawing.Point(5, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbURL
            // 
            this.tbURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbURL.Location = new System.Drawing.Point(5, 5);
            this.tbURL.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(1174, 20);
            this.tbURL.TabIndex = 0;
            this.tbURL.Tag = "";
            this.tbURL.Text = "Enter URL to start searchig...";
            // 
            // spContainer2
            // 
            this.spContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer2.IsSplitterFixed = true;
            this.spContainer2.Location = new System.Drawing.Point(5, 5);
            this.spContainer2.Name = "spContainer2";
            // 
            // spContainer2.Panel1
            // 
            this.spContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // spContainer2.Panel2
            // 
            this.spContainer2.Panel2.Controls.Add(this.splitContainer2);
            this.spContainer2.Size = new System.Drawing.Size(1174, 494);
            this.spContainer2.SplitterDistance = 592;
            this.spContainer2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbScanning);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvScanning);
            this.splitContainer1.Size = new System.Drawing.Size(592, 494);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // tbScanning
            // 
            this.tbScanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbScanning.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbScanning.Enabled = false;
            this.tbScanning.Location = new System.Drawing.Point(0, 0);
            this.tbScanning.Name = "tbScanning";
            this.tbScanning.Size = new System.Drawing.Size(592, 20);
            this.tbScanning.TabIndex = 1;
            this.tbScanning.Text = "Scanning";
            this.tbScanning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvScanning
            // 
            this.lvScanning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderURL,
            this.colHeaderState,
            this.colHeaderDescription});
            this.lvScanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScanning.FullRowSelect = true;
            this.lvScanning.Location = new System.Drawing.Point(0, 0);
            this.lvScanning.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.lvScanning.Name = "lvScanning";
            this.lvScanning.Size = new System.Drawing.Size(592, 465);
            this.lvScanning.TabIndex = 0;
            this.lvScanning.UseCompatibleStateImageBehavior = false;
            this.lvScanning.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderURL
            // 
            this.colHeaderURL.Text = "URL";
            this.colHeaderURL.Width = 300;
            // 
            // colHeaderState
            // 
            this.colHeaderState.Text = "State";
            this.colHeaderState.Width = 100;
            // 
            // colHeaderDescription
            // 
            this.colHeaderDescription.Text = "Description";
            this.colHeaderDescription.Width = 250;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbScanned);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvScanned);
            this.splitContainer2.Size = new System.Drawing.Size(578, 494);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 3;
            // 
            // tbScanned
            // 
            this.tbScanned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbScanned.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbScanned.Enabled = false;
            this.tbScanned.Location = new System.Drawing.Point(0, 0);
            this.tbScanned.Name = "tbScanned";
            this.tbScanned.Size = new System.Drawing.Size(578, 20);
            this.tbScanned.TabIndex = 1;
            this.tbScanned.Text = "Scanned";
            this.tbScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvScanned
            // 
            this.lvScanned.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderNum,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvScanned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScanned.FullRowSelect = true;
            this.lvScanned.Location = new System.Drawing.Point(0, 0);
            this.lvScanned.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.lvScanned.MultiSelect = false;
            this.lvScanned.Name = "lvScanned";
            this.lvScanned.Size = new System.Drawing.Size(578, 465);
            this.lvScanned.TabIndex = 0;
            this.lvScanned.UseCompatibleStateImageBehavior = false;
            this.lvScanned.View = System.Windows.Forms.View.Details;
            this.lvScanned.DoubleClick += new System.EventHandler(this.lvScanned_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "State";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 250;
            // 
            // colHeaderNum
            // 
            this.colHeaderNum.Text = "№";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 602);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Crawler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel1.PerformLayout();
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDURLs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThreads)).EndInit();
            this.spContainer2.Panel1.ResumeLayout(false);
            this.spContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer2)).EndInit();
            this.spContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numUDThreads;
        private System.Windows.Forms.Label labThreads;
        private System.Windows.Forms.NumericUpDown numUDURLs;
        private System.Windows.Forms.Label labURLCount;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ProgressBar pbScanProgress;
        private System.Windows.Forms.ListView lvScanning;
        private System.Windows.Forms.ColumnHeader colHeaderURL;
        private System.Windows.Forms.ColumnHeader colHeaderState;
        private System.Windows.Forms.ColumnHeader colHeaderDescription;
        private System.Windows.Forms.SplitContainer spContainer2;
        private System.Windows.Forms.TextBox tbScanning;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbScanned;
        private System.Windows.Forms.ListView lvScanned;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader colHeaderNum;
    }
}

