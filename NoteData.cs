using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesSticky
{
	public class NoteData
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public bool TopMost { get; set; }
		public int BackColor { get; set; }
		public double Opacity { get; set; }
		public string FilePath { get; set; }
	}
}
