using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;

namespace Mp3Sorter
{
	public partial class Form1 : Form
	{
		Controller ctrl = new Controller();

		string baseDir = "";

		protected void loadFiles()
		{
			FileGrid.Rows.Clear();

			var files = Directory.GetFiles(baseDir);
			foreach (var file in files)
			{
				FileGrid.Rows.Add(file);
			}
		}

		protected void loadDirs()
		{
			DirGrid.Rows.Clear();

			int i = 1;
			var dirs = Directory.GetDirectories(baseDir);
			foreach (var dir in dirs)
			{
				DirGrid.Rows.Add(i, dir);
				i++;
			}
		}

		protected void loadSelectedFile()
		{
			if (FileGrid.SelectedCells.Count == 0)
				return;

			string selectedFile = (string)FileGrid.SelectedCells[0].Value;
			if (File.Exists(selectedFile))
			{
				TextboxFile.Text = selectedFile;
				ctrl.loadFile(TextboxFile.Text);
				if (CheckboxAutoplay.Checked)
					ctrl.play(0.25);

				var info = ctrl.getTag();
				loadMP3Info(info);
			}
			else
				MessageBox.Show("File does not exist:\n" + selectedFile);
		}

		protected void loadMP3Info(MP3Info info)
		{
			checkBoxAlbum.Checked = false;
			checkBoxAlbumArtist.Checked = false;
			checkBoxArtist.Checked = false;
			checkBoxComment.Checked = false;
			checkBoxGenre.Checked = false;
			checkBoxTitle.Checked = false;
			checkBoxTrackNumber.Checked = false;
			checkBoxYear.Checked = false;

			if (info != null)
			{

				textBoxAlbum.Text = info.Album;
				textBoxAlbumArtist.Text = info.AlbumArtist;
				textBoxArtist.Text = info.Artist;
				labelBitrate.Text = "Bit Rate: " + info.Bitrate + "kbps";
				textBoxComment.Text = info.Comment;
				textBoxGenre.Text = info.Genre;
				labelDuration.Text = "Duration: " + (info.Length.Hours * 60 + info.Length.Minutes).ToString() + ":" + String.Format("{0:00}", info.Length.Seconds) + "." + info.Length.Milliseconds / 10;
				labelSamplerate.Text = "Sample Rate: " + String.Format("{0:#,##0}", info.Samplerate) + "Hz";
				textBoxTitle.Text = info.Title;
				textBoxTrackNumber.Text = info.Tracknumber.ToString();
				textBoxYear.Text = info.Year.ToString();
			}
			else
			{
				textBoxAlbum.Text = "";
				textBoxAlbumArtist.Text = "";
				textBoxArtist.Text = "";
				labelBitrate.Text = "Bit Rate: ";
				textBoxComment.Text = "";
				textBoxGenre.Text = "";
				labelDuration.Text = "Duration: ";
				labelSamplerate.Text = "Sample Rate: ";
				textBoxTitle.Text = "";
				textBoxTrackNumber.Text = "";
				textBoxYear.Text = "";
			}
		}

		protected void saveMP3Info()
		{
			var info = new MP3Info();

			info.Album			= checkBoxAlbum.Checked			? textBoxAlbum.Text : null;
			info.AlbumArtist	= checkBoxAlbumArtist.Checked	? textBoxAlbumArtist.Text : null;
			info.Artist			= checkBoxArtist.Checked		? textBoxArtist.Text : null;
			info.Comment		= checkBoxComment.Checked		? textBoxComment.Text : null;
			info.Genre			= checkBoxGenre.Checked			? textBoxGenre.Text : null;
			info.Title			= checkBoxTitle.Checked			? textBoxTitle.Text : null;
			info.Tracknumber	= checkBoxTrackNumber.Checked	? (int?)Convert.ToInt32(textBoxTrackNumber.Text) : null;
			info.Year			= checkBoxYear.Checked			? (int?)Convert.ToInt32(textBoxYear.Text) : null;

			ctrl.setTag(info);
		}

		protected void tryMove()
		{
			if(DirGrid.SelectedCells.Count == 0)
				return;

			int index = DirGrid.SelectedCells[0].RowIndex;
			string dir = (string)DirGrid.Rows[index].Cells[1].Value;

			if (Directory.Exists(dir))
			{
				bool success = ctrl.moveFile(dir);
				if (success)
				{
					// remove selection in DirGrid
					DirGrid.SelectedCells[0].Selected = false;

					// select next item in FileGrid
					int rowIndex = FileGrid.SelectedCells[0].RowIndex;
					loadFiles();
					if (rowIndex >= FileGrid.Rows.Count)
						rowIndex--;
					if (rowIndex >= 0)
						FileGrid.Rows[rowIndex].Cells[0].Selected = true;

					// Load the newly-selected file for playback
					loadSelectedFile();
				}
			}
			else
				MessageBox.Show("Directory does not exist:\n" + dir);
		}

		Timer timer = new Timer();

		// --------------------------------------------------------------------------------

		public Form1()
		{
			InitializeComponent();
			timer.Tick += new EventHandler(trackUpdate);
			timer.Interval = 100;
			timer.Enabled = true;

			baseDir = @"E:\music unsorted\__Tagged";
			loadFiles();
			loadDirs();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ctrl.play(0.25);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ctrl.play(0.5);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ctrl.play(0.75);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ctrl.stop();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var dia = new FolderBrowserDialog();

			if (dia.ShowDialog() == DialogResult.OK)
			{
				if(Directory.Exists(dia.SelectedPath))
					baseDir = dia.SelectedPath;
				else
					MessageBox.Show("Directory does not exist:\n" + dia.SelectedPath);

				loadFiles();
				loadDirs();
			}
		}

		private void FileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			loadSelectedFile();
		}

		private void DirGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tryMove();
		}

		private void DirGrid_Resize(object sender, EventArgs e)
		{
			FileGrid.Columns[0].Width = FileGrid.Width - 25;
			DirGrid.Columns[1].Width = DirGrid.Width - 25 - 50;
		}

		private void trackUpdate(object sender, EventArgs e)
		{
			if (!ctrl.playing)
			{
				trackBar1.Value = 0;
			}
			else
			{
				double pos = ctrl.getPos();
				trackBar1.Value = (int)(pos * trackBar1.Maximum);
			}
		}

		private void trackBar1_MouseDown(object sender, MouseEventArgs e)
		{
			timer.Enabled = false;
			double pos = (e.X-15) / (double)(trackBar1.Width-30);
			if (pos < 0)
				pos = 0.0;
			if (pos >= 1)
				pos = 0.99999;

			//ctrl.play(pos);
			trackBar1.Value = (int)(pos * trackBar1.Maximum);
		}

		private void trackBar1_MouseUp(object sender, MouseEventArgs e)
		{
			timer.Enabled = true;
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			if (!timer.Enabled)
				ctrl.play(trackBar1.Value / (double)trackBar1.Maximum);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ctrl.pause();
		}

		private void trackBarVolume_ValueChanged(object sender, EventArgs e)
		{
			ctrl.setVolume(trackBarVolume.Value / (double)trackBarVolume.Maximum);
		}

		private void trackBarVolume_MouseDown(object sender, MouseEventArgs e)
		{
			double pos = (e.X - 15) / (double)(trackBarVolume.Width - 30);
			if (pos < 0)
				pos = 0.0;
			if (pos >= 1)
				pos = 0.99999;

			trackBarVolume.Value = (int)(pos * trackBarVolume.Maximum);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			saveMP3Info();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (panel1.ContainsFocus)
				return;

			if (e.KeyCode == Keys.D1)
			{
				if (DirGrid.Rows.Count < 1)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[0].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D2)
			{
				if (DirGrid.Rows.Count < 2)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[1].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D3)
			{
				if (DirGrid.Rows.Count < 3)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[2].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D4)
			{
				if (DirGrid.Rows.Count < 4)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[3].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D5)
			{
				if (DirGrid.Rows.Count < 5)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[4].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D6)
			{
				if (DirGrid.Rows.Count < 6)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[5].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D7)
			{
				if (DirGrid.Rows.Count < 7)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[6].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D8)
			{
				if (DirGrid.Rows.Count < 8)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[7].Cells[1].Selected = true;
				tryMove();
			}
			else if (e.KeyCode == Keys.D9)
			{
				if (DirGrid.Rows.Count < 9)
					return;

				if (DirGrid.SelectedCells.Count != 0)
					DirGrid.SelectedCells[0].Selected = false;
				DirGrid.Rows[8].Cells[1].Selected = true;
				tryMove();
			}



			else if (e.KeyCode == Keys.Right)
			{
				var val = trackBar1.Value + 100;
				if (val > trackBar1.Maximum)
					val = trackBar1.Maximum;

				trackBar1.Value = val;
				ctrl.play(trackBar1.Value / (double)trackBar1.Maximum);
			}
			else if (e.KeyCode == Keys.Left)
			{
				var val = trackBar1.Value - 100;
				if (val < 0)
					val = 0;

				trackBar1.Value = val;
				ctrl.play(trackBar1.Value / (double)trackBar1.Maximum);
			}



			else if (e.KeyCode == Keys.PageUp)
			{
				var val = trackBarVolume.Value + 100;
				if (val > trackBarVolume.Maximum)
					val = trackBarVolume.Maximum;

				trackBarVolume.Value = val;
			}
			else if (e.KeyCode == Keys.PageDown)
			{
				var val = trackBarVolume.Value - 100;
				if (val < 0)
					val = 0;

				trackBarVolume.Value = val;
			}



			else if (e.KeyCode == Keys.Up)
			{
				int index = 0;
				if(FileGrid.SelectedCells.Count != 0)
					index = FileGrid.SelectedCells[0].RowIndex - 1;

				if (index < 0)
					index = 0;

				if (FileGrid.Rows.Count < 1)
					return;

				FileGrid.SelectedCells[0].Selected = false;
				FileGrid.Rows[index].Cells[0].Selected = true;
				loadSelectedFile();
			}
			else if (e.KeyCode == Keys.Down)
			{
				int index = 0;
				if(FileGrid.SelectedCells.Count != 0)
					index = FileGrid.SelectedCells[0].RowIndex + 1;

				if (index >= FileGrid.Rows.Count)
					index = FileGrid.Rows.Count - 1;

				if(FileGrid.Rows.Count < 1)
					return;

				FileGrid.SelectedCells[0].Selected = false;
				FileGrid.Rows[index].Cells[0].Selected = true;
				loadSelectedFile();
			}

			e.Handled = true;

		}

		private void label11_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		private void textBoxArtist_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxArtist.Checked = true;
		}

		private void textBoxAlbumArtist_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxAlbumArtist.Checked = true;
		}

		private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxTitle.Checked = true;
		}

		private void textBoxAlbum_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxAlbum.Checked = true;
		}

		private void textBoxGenre_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxGenre.Checked = true;
		}

		private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxYear.Checked = true;
		}

		private void textBoxTrackNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxTrackNumber.Checked = true;
		}

		private void textBoxComment_KeyPress(object sender, KeyPressEventArgs e)
		{
			checkBoxComment.Checked = true;
		}

		

	}
}
