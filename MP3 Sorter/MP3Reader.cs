using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Sorter
{
	public class MP3Info
	{
		public TimeSpan Length;
		public int Bitrate;
		public int Samplerate;
 
		public string Artist;
		public string AlbumArtist;
		public string Title;
		public string Album;

		public string Genre;
		public int Year;
		public int Tracknumber;

		public string Comment;
	}

	/*public class MP3Reader
	{
		public static MP3Info getTag(string filename)
		{
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

		public static bool setTag(string filename, MP3Info info)
		{
			TagLib.File tagFile = TagLib.File.Create(filename);

			tagFile.Tag.Performers = new string[1] {info.Artist};
			tagFile.Tag.Title = info.Title;
			tagFile.Tag.Year = (uint)info.Year;
			tagFile.Tag.Comment = info.Comment;
			tagFile.Tag.Album = info.Album;
			tagFile.Tag.Track = (uint)info.Tracknumber;
			tagFile.Tag.Genres = new string[1] {info.Genre};
			tagFile.Tag.AlbumArtists = new string[1] {info.AlbumArtist};
			
			if(filename)
			tagFile.Save();
			
			return true;
		}
	}*/
}
