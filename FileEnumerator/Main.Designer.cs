namespace FileEnumerator {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Browse = new System.Windows.Forms.Button();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Enumerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MinNumber = new System.Windows.Forms.TextBox();
            this.ProgressReport = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(466, 224);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(161, 30);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add Folder";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FolderList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // FolderList
            // 
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Location = new System.Drawing.Point(9, 32);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(616, 186);
            this.FolderList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folders to search for files in:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgressReport);
            this.groupBox2.Controls.Add(this.MinNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Browse);
            this.groupBox2.Controls.Add(this.OutputFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Progress);
            this.groupBox2.Controls.Add(this.Enumerate);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(536, 32);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(89, 21);
            this.Browse.TabIndex = 8;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // OutputFolder
            // 
            this.OutputFolder.Enabled = false;
            this.OutputFolder.Location = new System.Drawing.Point(9, 32);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(528, 20);
            this.OutputFolder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Folder:";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(9, 108);
            this.Progress.Maximum = 10000000;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(449, 30);
            this.Progress.TabIndex = 5;
            // 
            // Enumerate
            // 
            this.Enumerate.Location = new System.Drawing.Point(464, 108);
            this.Enumerate.Name = "Enumerate";
            this.Enumerate.Size = new System.Drawing.Size(161, 30);
            this.Enumerate.TabIndex = 3;
            this.Enumerate.Text = "Enumerate!";
            this.Enumerate.UseVisualStyleBackColor = true;
            this.Enumerate.Click += new System.EventHandler(this.Enumerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Counting At:";
            // 
            // MinNumber
            // 
            this.MinNumber.Location = new System.Drawing.Point(102, 56);
            this.MinNumber.Name = "MinNumber";
            this.MinNumber.Size = new System.Drawing.Size(91, 20);
            this.MinNumber.TabIndex = 10;
            this.MinNumber.Text = "0";
            this.MinNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProgressReport
            // 
            this.ProgressReport.AutoSize = true;
            this.ProgressReport.Location = new System.Drawing.Point(9, 89);
            this.ProgressReport.Name = "ProgressReport";
            this.ProgressReport.Size = new System.Drawing.Size(0, 13);
            this.ProgressReport.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileEnumerator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox FolderList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button Enumerate;
        private System.Windows.Forms.TextBox MinNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProgressReport;
    }
}

