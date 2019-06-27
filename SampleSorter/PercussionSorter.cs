using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Nequeo.IO.Audio;

namespace SampleSorter {
	public partial class PercussionSorter : Form {
		private List<string> wavs;
		private int index;
		WavePlayer player = new WavePlayer(new Device());

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool CreateHardLink(string lpFileName,string lpExistingFileName,IntPtr lpSecurityAttributes);

        private string currentFile {
			get { return wavs[index]; }
		}

		public PercussionSorter() {
			InitializeComponent();
		}

		private void selectDirectory_Click(object sender, EventArgs e) {
			var d = new FolderBrowserDialog();
			var dr = d.ShowDialog();
			tbDirectory.Text = d.SelectedPath;
			ParseDirectory(d.SelectedPath);
		}

		private void ParseDirectory(string theDirectory) {
            if (theDirectory == string.Empty) {
                return;
            }
			wavs = Directory.EnumerateFiles(theDirectory, "*.wav", SearchOption.AllDirectories).ToList();
			if (wavs.Count == 0) {
				MessageBox.Show("No samples here.","Fail",MessageBoxButtons.OK);
				return;
			}
			MakeVisible();

			Directory.CreateDirectory(theDirectory + Path.DirectorySeparatorChar + "SortedSamples");
			index = -1;
			NextFile();
		}

		private void NextFile() {
			index++;
			if (index == wavs.Count) {
				MessageBox.Show("Done.", "Done", MessageBoxButtons.OK);
				return;
			}
			bPlaySample.Text = Path.GetFileName(currentFile);
			player.Open(currentFile);
		}

		private void MakeVisible() {
			foreach (Control control in Controls) {
				control.Visible = true;
			}
            rbMove.Checked = true;
		}

		private void bPlaySample_Click(object sender, EventArgs e) {
			player.Play();
		}

        private void custom_Click(object sender, MouseEventArgs e) {
            player.Stop();
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right || b.Text == "(set)") {
                var d = new NameDialog(b.Text);
                var dr = d.ShowDialog();
                if (dr == DialogResult.OK) {
                    b.Text = d.name;
                }
            }
            else {
                if (!Directory.Exists("SortedSamples\\" + b.Text)) {
                    Directory.CreateDirectory("SortedSamples\\" + b.Text);
                }
                if (rbMove.Checked)               {
                    File.Move(currentFile, "SortedSamples\\" + b.Text + "\\" + Path.GetFileName(currentFile));
                }
                else if (rbCopy.Checked) {
                    File.Copy(currentFile, "SortedSamples\\" + b.Text + "\\" + Path.GetFileName(currentFile));
                }
                else {
                    CreateHardLink("SortedSamples\\" + b.Text + "\\" + Path.GetFileName(currentFile), currentFile, IntPtr.Zero);
                }
                NextFile();
            }
        }

		private void bGarbage_Click(object sender, EventArgs e) {
			player.Stop();
			File.Delete(currentFile);
			NextFile();
		}

        private void bSkip_Click(object sender, EventArgs e)
        {
            player.Stop();
            NextFile();
        }
    }
}
