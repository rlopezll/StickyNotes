using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace NotesSticky
{
	public partial class StickyForm : Form
	{
		static bool bIgnoreCloseNote = false;
		static bool bIsSaved = false;

		public int ValidTop;
		public int ValidLeft;

		public StickyForm()
		{
			InitializeComponent();
			richTextBox1.ContextMenuStrip = contextMenuStrip1;
			this.LocationChanged += StickyForm_LocationChanged;
		}
		private void StickyForm_LocationChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				ValidTop = this.Top;
				ValidLeft = this.Left;
			}
		}

		private void ReadNotes()
		{
			bool bFirstNote = true;
			if (File.Exists("notes.json"))
			{
				string text = File.ReadAllText("notes.json");
				if (text.Length == 0)
					return;

				var data = JsonSerializer.Deserialize<List<NoteData>>(text);
				var screen = Screen.PrimaryScreen;
				var centerX = screen.Bounds.Left + screen.Bounds.Width / 2;
				var centerY = screen.Bounds.Top + screen.Bounds.Height / 2;

				foreach (var d in data)
				{
					var nota = this;
					if (!bFirstNote)
						nota = new StickyForm();

					nota.Tag = d.Id;
					nota.Text = d.Title;
					nota.Top = d.Top;
					nota.Left = d.Left;
					if(nota.Top < 0)
					{
						nota.Top = centerY;
					}
					if (nota.Left < 0)
					{
						nota.Left = centerX;
					}
					nota.ValidTop = nota.Top;
					nota.ValidLeft = nota.Left;
					nota.TopMost = d.TopMost;
					nota.StartPosition = FormStartPosition.Manual;
					if (File.Exists(d.FilePath))
						nota.richTextBox1.Rtf = File.ReadAllText(d.FilePath);

					if (!bFirstNote)
					{
						nota.ShowInTaskbar = false;
						nota.Show();
					}

					nota.BackColor = Color.FromArgb(d.BackColor);
					nota.richTextBox1.BackColor = Color.FromArgb(d.BackColor);

					bFirstNote = false;
				}
			}
		}

		private void SaveNotes()
		{
			List<NoteData> notas = new List<NoteData>();

			foreach (var nota in Application.OpenForms.OfType<StickyForm>())
			{
				var data = nota.GetNoteData();
				Directory.CreateDirectory("notes");
				File.WriteAllText(data.FilePath, nota.richTextBox1.Rtf); // suponiendo propiedad pública
				notas.Add(data);
			}

			File.WriteAllText("notes.json", JsonSerializer.Serialize(notas, new JsonSerializerOptions { WriteIndented = true }));

		}

		private void StickyForm_Load(object sender, EventArgs e)
		{
			ValidTop = Top;
			ValidLeft = Left;
			if (Application.OpenForms.Count == 1)
			{
				ReadNotes();

				Form mainForm = Application.OpenForms[0];
				mainForm.Resize += (s, e) =>
				{
					if (mainForm.WindowState == FormWindowState.Minimized)
					{
						foreach (var f in Application.OpenForms.OfType<StickyForm>())
						{
							if(f != mainForm)
							{
								//f.WindowState = FormWindowState.Minimized;
								f.Hide();
							}
						}
					}
					else if (mainForm.WindowState == FormWindowState.Normal)
					{
						foreach (var f in Application.OpenForms.OfType<StickyForm>())
						{
							if (f != mainForm)
							{
								f.Show();
								//f.WindowState = FormWindowState.Normal;
							}
						}
					}
				};
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (!bIsSaved && !bIgnoreCloseNote)
			{
				bIsSaved = true;
				SaveNotes();
				List<StickyForm> PendingRemove = new List<StickyForm>();
				foreach (var nota in Application.OpenForms.OfType<StickyForm>())
				{
					if (nota != this)
					{
						PendingRemove.Add(nota);
					}
				}

				for (var i = 0; i < PendingRemove.Count; i++)
				{
					PendingRemove[i].Close();
				}
			}
			bIgnoreCloseNote = false;
			base.OnFormClosing(e);
		}


		private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
		}

		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 255, 255, 192);
		}

		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 230, 230, 250);
		}

		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 204, 229, 255);
		}

		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 204, 255, 204);
		}

		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 255, 200, 200);
		}

		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.BackColor = this.BackColor = Color.FromArgb(255, 255, 224, 178);
		}

		private void nameNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string input = Microsoft.VisualBasic.Interaction.InputBox(
			"Name of note:",
			"Name of note",
			this.Text);

			if (!string.IsNullOrWhiteSpace(input))
			{
				this.Text = input;
			}
		}

		private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var nota = new StickyForm();
			nota.ShowInTaskbar = false;
			Form mainForm = Application.OpenForms[0];
			nota.Show();
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
		}

		private void cursiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
		}

		private void regularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
		}

		private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
			richTextBox1.SelectionColor = Color.DarkRed;
		}

		private void unSelectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Black;
		}

		public NoteData GetNoteData()
		{
			string Id = this.Tag?.ToString() ?? Guid.NewGuid().ToString();
			return new NoteData
			{
				Id = Id,
				Title = this.Text,
				Top = this.ValidTop,
				Left = this.ValidLeft,
				TopMost = this.TopMost,
				BackColor = this.BackColor.ToArgb(),
				FilePath = Path.Combine("notes", $"{Id}.rtf")
			};
		}

		private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bIgnoreCloseNote = true;
			Close();
		}
	}
}
