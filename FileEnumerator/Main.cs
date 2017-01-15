using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEnumerator {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            var success = dialog.ShowDialog();
            if (success == DialogResult.OK) {
                FolderList.Items.Add(dialog.SelectedPath);
            }
        }

        private void Browse_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            var success = dialog.ShowDialog();
            if (success == DialogResult.OK) {
                OutputFolder.Text = dialog.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            Int32 val = 0;
            Int32.TryParse(MinNumber.Text, out val);
            MinNumber.Text = val.ToString();
        }

        private void Main_Load(object sender, EventArgs e) {
            OutputFolder.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output");
        }

        private void Enumerate_Click(object sender, EventArgs e) {
            // Disable all our input.
            Enumerate.Enabled = false;
            Browse.Enabled = false;
            Add.Enabled = false;
            MinNumber.Enabled = false;

            // Set up our background worker.
            var worker = new BackgroundWorker();
            worker.RunWorkerCompleted += (s, a) => {
                Enumerate.Enabled = true;
                Browse.Enabled = true;
                Add.Enabled = true;
                MinNumber.Enabled = true;

                MessageBox.Show("Task Completed!\nSee your output folder for your files.");
            };
            worker.DoWork += (s, a) => {
                var w = (BackgroundWorker)s;
                var args = (List<Object>)a.Argument;
                var folders = (List<String>)args[0];
                var startcount = (Int32)args[1];
                var output = (String)args[2];
                var files = new List<String>();

                if (!Directory.Exists(output)) Directory.CreateDirectory(output);

                w.ReportProgress(0, "Scanning for files..");
                foreach (var dir in folders) {
                    foreach (var f in new DirectoryInfo(dir).EnumerateFiles("*.*", SearchOption.AllDirectories)) {
                        files.Add(f.FullName);
                    }
                }

                var cur = 0;
                var add = 10000000 / files.Count();
                for (var i = 0; i < files.Count(); i++) {
                    cur += add;
                    w.ReportProgress(cur, String.Format("Processing file {0}/{1}..", i + 1, files.Count()));
                    File.Copy(files[i], Path.Combine(output, String.Format("{0}{1}", i + startcount, Path.GetExtension(files[i]))), true);
                }
                w.ReportProgress(10000000, "Completed!");
            };
            worker.ProgressChanged += (s, a) => { Progress.Value = a.ProgressPercentage; ProgressReport.Text = (String)a.UserState; };
            worker.WorkerReportsProgress = true;

            var fl = new List<String>();
            foreach (var i in FolderList.Items) fl.Add((String)i);
            worker.RunWorkerAsync(new List<Object>() { fl, Int32.Parse(MinNumber.Text), OutputFolder.Text });
        }
    }
}
