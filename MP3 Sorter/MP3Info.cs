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
		public int? Year;
		public int? Tracknumber;

		public string Comment;
	}
}
