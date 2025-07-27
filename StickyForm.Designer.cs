namespace NotesSticky
{
    partial class StickyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyForm));
			contextMenuStrip1 = new ContextMenuStrip(components);
			newNoteToolStripMenuItem = new ToolStripMenuItem();
			nameNoteToolStripMenuItem = new ToolStripMenuItem();
			colorsToolStripMenuItem = new ToolStripMenuItem();
			yellowToolStripMenuItem = new ToolStripMenuItem();
			pinkToolStripMenuItem = new ToolStripMenuItem();
			blueToolStripMenuItem = new ToolStripMenuItem();
			greenToolStripMenuItem = new ToolStripMenuItem();
			redToolStripMenuItem = new ToolStripMenuItem();
			orangeToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripSeparator();
			styleToolStripMenuItem = new ToolStripMenuItem();
			regularToolStripMenuItem = new ToolStripMenuItem();
			boldToolStripMenuItem = new ToolStripMenuItem();
			cursiveToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			selectedToolStripMenuItem = new ToolStripMenuItem();
			unSelectedToolStripMenuItem = new ToolStripMenuItem();
			alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
			removeNoteToolStripMenuItem = new ToolStripMenuItem();
			richTextBox1 = new RichTextBox();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newNoteToolStripMenuItem, nameNoteToolStripMenuItem, colorsToolStripMenuItem, toolStripMenuItem2, styleToolStripMenuItem, alwaysOnTopToolStripMenuItem, removeNoteToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(152, 142);
			// 
			// newNoteToolStripMenuItem
			// 
			newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
			newNoteToolStripMenuItem.Size = new Size(151, 22);
			newNoteToolStripMenuItem.Text = "New Note";
			newNoteToolStripMenuItem.Click += newNoteToolStripMenuItem_Click;
			// 
			// nameNoteToolStripMenuItem
			// 
			nameNoteToolStripMenuItem.Name = "nameNoteToolStripMenuItem";
			nameNoteToolStripMenuItem.Size = new Size(151, 22);
			nameNoteToolStripMenuItem.Text = "Name Note";
			nameNoteToolStripMenuItem.Click += nameNoteToolStripMenuItem_Click;
			// 
			// colorsToolStripMenuItem
			// 
			colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yellowToolStripMenuItem, pinkToolStripMenuItem, blueToolStripMenuItem, greenToolStripMenuItem, redToolStripMenuItem, orangeToolStripMenuItem });
			colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			colorsToolStripMenuItem.Size = new Size(151, 22);
			colorsToolStripMenuItem.Text = "Note Color";
			// 
			// yellowToolStripMenuItem
			// 
			yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
			yellowToolStripMenuItem.Size = new Size(113, 22);
			yellowToolStripMenuItem.Text = "Yellow";
			yellowToolStripMenuItem.Click += yellowToolStripMenuItem_Click;
			// 
			// pinkToolStripMenuItem
			// 
			pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
			pinkToolStripMenuItem.Size = new Size(113, 22);
			pinkToolStripMenuItem.Text = "Red";
			pinkToolStripMenuItem.Click += pinkToolStripMenuItem_Click;
			// 
			// blueToolStripMenuItem
			// 
			blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			blueToolStripMenuItem.Size = new Size(113, 22);
			blueToolStripMenuItem.Text = "Blue";
			blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
			// 
			// greenToolStripMenuItem
			// 
			greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			greenToolStripMenuItem.Size = new Size(113, 22);
			greenToolStripMenuItem.Text = "Green";
			greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
			// 
			// redToolStripMenuItem
			// 
			redToolStripMenuItem.Name = "redToolStripMenuItem";
			redToolStripMenuItem.Size = new Size(113, 22);
			redToolStripMenuItem.Text = "Violet";
			redToolStripMenuItem.Click += redToolStripMenuItem_Click;
			// 
			// orangeToolStripMenuItem
			// 
			orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
			orangeToolStripMenuItem.Size = new Size(113, 22);
			orangeToolStripMenuItem.Text = "Orange";
			orangeToolStripMenuItem.Click += orangeToolStripMenuItem_Click;
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(148, 6);
			// 
			// styleToolStripMenuItem
			// 
			styleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regularToolStripMenuItem, boldToolStripMenuItem, cursiveToolStripMenuItem, toolStripMenuItem1, selectedToolStripMenuItem, unSelectedToolStripMenuItem });
			styleToolStripMenuItem.Name = "styleToolStripMenuItem";
			styleToolStripMenuItem.Size = new Size(151, 22);
			styleToolStripMenuItem.Text = "Text Style";
			// 
			// regularToolStripMenuItem
			// 
			regularToolStripMenuItem.Name = "regularToolStripMenuItem";
			regularToolStripMenuItem.Size = new Size(133, 22);
			regularToolStripMenuItem.Text = "Regular";
			regularToolStripMenuItem.Click += regularToolStripMenuItem_Click;
			// 
			// boldToolStripMenuItem
			// 
			boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			boldToolStripMenuItem.Size = new Size(133, 22);
			boldToolStripMenuItem.Text = "Bold";
			boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
			// 
			// cursiveToolStripMenuItem
			// 
			cursiveToolStripMenuItem.Name = "cursiveToolStripMenuItem";
			cursiveToolStripMenuItem.Size = new Size(133, 22);
			cursiveToolStripMenuItem.Text = "Italic";
			cursiveToolStripMenuItem.Click += cursiveToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(130, 6);
			// 
			// selectedToolStripMenuItem
			// 
			selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
			selectedToolStripMenuItem.Size = new Size(133, 22);
			selectedToolStripMenuItem.Text = "Selected";
			selectedToolStripMenuItem.Click += selectedToolStripMenuItem_Click;
			// 
			// unSelectedToolStripMenuItem
			// 
			unSelectedToolStripMenuItem.Name = "unSelectedToolStripMenuItem";
			unSelectedToolStripMenuItem.Size = new Size(133, 22);
			unSelectedToolStripMenuItem.Text = "UnSelected";
			unSelectedToolStripMenuItem.Click += unSelectedToolStripMenuItem_Click;
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			alwaysOnTopToolStripMenuItem.Checked = true;
			alwaysOnTopToolStripMenuItem.CheckOnClick = true;
			alwaysOnTopToolStripMenuItem.CheckState = CheckState.Checked;
			alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			alwaysOnTopToolStripMenuItem.Size = new Size(151, 22);
			alwaysOnTopToolStripMenuItem.Text = "Always on Top";
			alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
			// 
			// removeNoteToolStripMenuItem
			// 
			removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
			removeNoteToolStripMenuItem.Size = new Size(151, 22);
			removeNoteToolStripMenuItem.Text = "Remove Note";
			removeNoteToolStripMenuItem.Click += removeNoteToolStripMenuItem_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = Color.FromArgb(255, 255, 192);
			richTextBox1.BorderStyle = BorderStyle.None;
			richTextBox1.Font = new Font("Segoe UI", 12F);
			richTextBox1.Location = new Point(12, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(285, 289);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "";
			// 
			// StickyForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 192);
			ClientSize = new Size(309, 313);
			Controls.Add(richTextBox1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "StickyForm";
			Text = "Note";
			TopMost = true;
			Load += StickyForm_Load;
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private ToolStripMenuItem colorsToolStripMenuItem;
		private ToolStripMenuItem yellowToolStripMenuItem;
		private ToolStripMenuItem redToolStripMenuItem;
		private ToolStripMenuItem blueToolStripMenuItem;
		private ToolStripMenuItem greenToolStripMenuItem;
		private ToolStripMenuItem pinkToolStripMenuItem;
		private ToolStripMenuItem orangeToolStripMenuItem;
		private ToolStripMenuItem nameNoteToolStripMenuItem;
		private ToolStripMenuItem newNoteToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private RichTextBox richTextBox1;
		private ToolStripMenuItem styleToolStripMenuItem;
		private ToolStripMenuItem boldToolStripMenuItem;
		private ToolStripMenuItem cursiveToolStripMenuItem;
		private ToolStripMenuItem selectedToolStripMenuItem;
		private ToolStripMenuItem regularToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem unSelectedToolStripMenuItem;
		private ToolStripMenuItem removeNoteToolStripMenuItem;
	}
}
