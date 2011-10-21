using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace Mp3Sorter
{
	class Controller
	{
		[DllImport("winmm.dll")]
		private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

		UInt64 length = 0;
		string currentFile = "";
		public bool playing = false;
		private bool paused = true;
		private double volume = 1000;

		public void loadFile(string filename)
		{
			if (!File.Exists(filename))
			{
				currentFile = "";
				playing = false;
				return;
			}

			try
			{
				currentFile = filename;
				playing = true;
				paused = false;

				mciSendString("close MediaFile", null, 0, IntPtr.Zero);

				mciSendString("open \"" + currentFile + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);

				StringBuilder str = new StringBuilder(128);
				mciSendString("status MediaFile length", str, 128, IntPtr.Zero);
				length = Convert.ToUInt64(str.ToString());
			}
			catch (Exception)
			{
				playing = false;
			}
		}

		public void play(double pos)
		{
			paused = false;
			mciSendString("play MediaFile from " + ((int)(length * pos)).ToString(), null, 0, IntPtr.Zero);
			setVolume(this.volume);
		}

		public void pause()
		{
			if (paused == false)
			{
				mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
				paused = true;
			}
			else
			{
				mciSendString("play MediaFile", null, 0, IntPtr.Zero);
				paused = false;
			}
		}

		public void stop()
		{
			mciSendString("close MediaFile", null, 0, IntPtr.Zero);
			playing = false;
		}

		public void setVolume(double vol)
		{
			volume = vol;
			mciSendString("setaudio MediaFile volume to " + (int)(volume * volume * 1000), null, 0, IntPtr.Zero);
		}

		public double getPos()
		{
			StringBuilder str = new StringBuilder(128);
			mciSendString("status MediaFile position", str, 128, IntPtr.Zero);
			var pos = Convert.ToUInt64(str.ToString());

			return pos / (double)length;
		}

		public bool moveFile(string destFolder)
		{
			stop();

			string filename = Path.GetFileName(currentFile);
			string destFilename = Path.Combine(destFolder, filename);

			if (File.Exists(currentFile) && !File.Exists(destFilename))
				File.Move(currentFile, destFilename);

			if (!File.Exists(currentFile) && File.Exists(destFilename))
				return true;
			else
				return false;
		}

		public MP3Info getTag()
		{
			string filename = currentFile;
			try
			{
				TagLib.File tagFile = TagLib.File.Create(filename);

				MP3Info info = new MP3Info();

				info.Length = tagFile.Properties.Duration;
				info.Bitrate = tagFile.Properties.AudioBitrate;
				info.Samplerate = tagFile.Properties.AudioSampleRate;

				if (info.Length == null)
					info.Length = TimeSpan.FromSeconds(0);

				info.Artist = tagFile.Tag.FirstPerformer;
				info.Title = tagFile.Tag.Title;
				info.Year = (int)tagFile.Tag.Year;
				info.Comment = tagFile.Tag.Comment;
				info.Album = tagFile.Tag.Album;
				info.Tracknumber = (int)tagFile.Tag.Track;
				info.Genre = tagFile.Tag.FirstGenre;
				info.AlbumArtist = tagFile.Tag.FirstAlbumArtist;

				if (info.Artist == null)
					info.Artist = "";
				if (info.Title == null)
					info.Title = "";
				if (info.Comment == null)
					info.Comment = "";
				if (info.Album == null)
					info.Album = "";
				if (info.Genre == null)
					info.Genre = "";
				if (info.AlbumArtist == null)
					info.AlbumArtist = "";

				return info;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool setTag(MP3Info info)
		{
			string filename = currentFile;

			TagLib.File tagFile = TagLib.File.Create(filename);

			if (info.Artist != null)
				tagFile.Tag.Performers = new string[1] { info.Artist };

			if (info.Title != null)
				tagFile.Tag.Title = info.Title;

			if (info.Year != null)
				tagFile.Tag.Year = (uint)info.Year;

			if (info.Comment != null)
				tagFile.Tag.Comment = info.Comment;

			if (info.Album != null)
				tagFile.Tag.Album = info.Album;

			if (info.Tracknumber != null)
				tagFile.Tag.Track = (uint)info.Tracknumber;

			if (info.Genre != null)
				tagFile.Tag.Genres = new string[1] { info.Genre };

			if (info.AlbumArtist != null)
				tagFile.Tag.AlbumArtists = new string[1] { info.AlbumArtist };

			var pos = getPos();
			stop();
			tagFile.Save();
			loadFile(currentFile);
			play(pos);

			return true;
		}
	}
}
