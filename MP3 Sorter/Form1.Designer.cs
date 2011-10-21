namespace Mp3Sorter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextboxFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.DirGrid = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FileGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckboxAutoplay = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBoxTrackNumber = new System.Windows.Forms.CheckBox();
			this.checkBoxComment = new System.Windows.Forms.CheckBox();
			this.checkBoxYear = new System.Windows.Forms.CheckBox();
			this.checkBoxGenre = new System.Windows.Forms.CheckBox();
			this.checkBoxAlbum = new System.Windows.Forms.CheckBox();
			this.checkBoxTitle = new System.Windows.Forms.CheckBox();
			this.checkBoxAlbumArtist = new System.Windows.Forms.CheckBox();
			this.checkBoxArtist = new System.Windows.Forms.CheckBox();
			this.button7 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.textBoxTrackNumber = new System.Windows.Forms.TextBox();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			this.textBoxGenre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAlbum = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxAlbumArtist = new System.Windows.Forms.TextBox();
			this.textBoxArtist = new System.Windows.Forms.TextBox();
			this.labelBitrate = new System.Windows.Forms.Label();
			this.labelSamplerate = new System.Windows.Forms.Label();
			this.labelDuration = new System.Windows.Forms.Label();
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DirGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FileGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.SuspendLayout();
			// 
			// TextboxFile
			// 
			this.TextboxFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TextboxFile.Location = new System.Drawing.Point(12, 40);
			this.TextboxFile.Name = "TextboxFile";
			this.TextboxFile.ReadOnly = true;
			this.TextboxFile.Size = new System.Drawing.Size(442, 20);
			this.TextboxFile.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current Song";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "25%";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(59, 79);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(41, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "50%";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(106, 79);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(41, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "75%";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(214, 79);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(55, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Stop";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(275, 79);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(99, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "Open Directory";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 211);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.DirGrid);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.FileGrid);
			this.splitContainer1.Size = new System.Drawing.Size(1003, 371);
			this.splitContainer1.SplitterDistance = 171;
			this.splitContainer1.TabIndex = 11;
			// 
			// DirGrid
			// 
			this.DirGrid.AllowUserToAddRows = false;
			this.DirGrid.AllowUserToDeleteRows = false;
			this.DirGrid.AllowUserToResizeColumns = false;
			this.DirGrid.AllowUserToResizeRows = false;
			this.DirGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DirGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DirGrid.CausesValidation = false;
			this.DirGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.DirGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DirGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DirGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.dataGridViewTextBoxColumn1});
			this.DirGrid.Location = new System.Drawing.Point(2, 3);
			this.DirGrid.MultiSelect = false;
			this.DirGrid.Name = "DirGrid";
			this.DirGrid.ReadOnly = true;
			this.DirGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DirGrid.RowHeadersVisible = false;
			this.DirGrid.RowHeadersWidth = 80;
			this.DirGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DirGrid.Size = new System.Drawing.Size(998, 165);
			this.DirGrid.TabIndex = 9;
			this.DirGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirGrid_CellClick);
			this.DirGrid.Resize += new System.EventHandler(this.DirGrid_Resize);
			// 
			// Number
			// 
			this.Number.HeaderText = "Number";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Number.Width = 50;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Directory Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 920;
			// 
			// FileGrid
			// 
			this.FileGrid.AllowUserToAddRows = false;
			this.FileGrid.AllowUserToDeleteRows = false;
			this.FileGrid.AllowUserToResizeColumns = false;
			this.FileGrid.AllowUserToResizeRows = false;
			this.FileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FileGrid.CausesValidation = false;
			this.FileGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.FileGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.FileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
			this.FileGrid.Location = new System.Drawing.Point(0, 3);
			this.FileGrid.MultiSelect = false;
			this.FileGrid.Name = "FileGrid";
			this.FileGrid.ReadOnly = true;
			this.FileGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.FileGrid.RowHeadersVisible = false;
			this.FileGrid.RowHeadersWidth = 80;
			this.FileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.FileGrid.Size = new System.Drawing.Size(1000, 193);
			this.FileGrid.TabIndex = 11;
			this.FileGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileGrid_CellClick);
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Filename";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 970;
			// 
			// CheckboxAutoplay
			// 
			this.CheckboxAutoplay.AutoSize = true;
			this.CheckboxAutoplay.Checked = true;
			this.CheckboxAutoplay.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckboxAutoplay.Location = new System.Drawing.Point(387, 83);
			this.CheckboxAutoplay.Name = "CheckboxAutoplay";
			this.CheckboxAutoplay.Size = new System.Drawing.Size(67, 17);
			this.CheckboxAutoplay.TabIndex = 12;
			this.CheckboxAutoplay.Text = "Autoplay";
			this.CheckboxAutoplay.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 149);
			this.trackBar1.Maximum = 1000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(345, 45);
			this.trackBar1.SmallChange = 100;
			this.trackBar1.TabIndex = 14;
			this.trackBar1.TickFrequency = 100;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
			this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(153, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Pause";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.checkBoxTrackNumber);
			this.panel1.Controls.Add(this.checkBoxComment);
			this.panel1.Controls.Add(this.checkBoxYear);
			this.panel1.Controls.Add(this.checkBoxGenre);
			this.panel1.Controls.Add(this.checkBoxAlbum);
			this.panel1.Controls.Add(this.checkBoxTitle);
			this.panel1.Controls.Add(this.checkBoxAlbumArtist);
			this.panel1.Controls.Add(this.checkBoxArtist);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxComment);
			this.panel1.Controls.Add(this.textBoxTrackNumber);
			this.panel1.Controls.Add(this.textBoxYear);
			this.panel1.Controls.Add(this.textBoxGenre);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxAlbum);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxTitle);
			this.panel1.Controls.Add(this.textBoxAlbumArtist);
			this.panel1.Controls.Add(this.textBoxArtist);
			this.panel1.Location = new System.Drawing.Point(460, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(552, 188);
			this.panel1.TabIndex = 33;
			// 
			// checkBoxTrackNumber
			// 
			this.checkBoxTrackNumber.AutoSize = true;
			this.checkBoxTrackNumber.Location = new System.Drawing.Point(368, 71);
			this.checkBoxTrackNumber.Name = "checkBoxTrackNumber";
			this.checkBoxTrackNumber.Size = new System.Drawing.Size(15, 14);
			this.checkBoxTrackNumber.TabIndex = 57;
			this.checkBoxTrackNumber.UseVisualStyleBackColor = true;
			// 
			// checkBoxComment
			// 
			this.checkBoxComment.AutoSize = true;
			this.checkBoxComment.Location = new System.Drawing.Point(268, 113);
			this.checkBoxComment.Name = "checkBoxComment";
			this.checkBoxComment.Size = new System.Drawing.Size(15, 14);
			this.checkBoxComment.TabIndex = 56;
			this.checkBoxComment.UseVisualStyleBackColor = true;
			// 
			// checkBoxYear
			// 
			this.checkBoxYear.AutoSize = true;
			this.checkBoxYear.Location = new System.Drawing.Point(268, 71);
			this.checkBoxYear.Name = "checkBoxYear";
			this.checkBoxYear.Size = new System.Drawing.Size(15, 14);
			this.checkBoxYear.TabIndex = 55;
			this.checkBoxYear.UseVisualStyleBackColor = true;
			// 
			// checkBoxGenre
			// 
			this.checkBoxGenre.AutoSize = true;
			this.checkBoxGenre.Location = new System.Drawing.Point(268, 29);
			this.checkBoxGenre.Name = "checkBoxGenre";
			this.checkBoxGenre.Size = new System.Drawing.Size(15, 14);
			this.checkBoxGenre.TabIndex = 54;
			this.checkBoxGenre.UseVisualStyleBackColor = true;
			// 
			// checkBoxAlbum
			// 
			this.checkBoxAlbum.AutoSize = true;
			this.checkBoxAlbum.Location = new System.Drawing.Point(8, 155);
			this.checkBoxAlbum.Name = "checkBoxAlbum";
			this.checkBoxAlbum.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAlbum.TabIndex = 53;
			this.checkBoxAlbum.UseVisualStyleBackColor = true;
			// 
			// checkBoxTitle
			// 
			this.checkBoxTitle.AutoSize = true;
			this.checkBoxTitle.Location = new System.Drawing.Point(8, 113);
			this.checkBoxTitle.Name = "checkBoxTitle";
			this.checkBoxTitle.Size = new System.Drawing.Size(15, 14);
			this.checkBoxTitle.TabIndex = 52;
			this.checkBoxTitle.UseVisualStyleBackColor = true;
			// 
			// checkBoxAlbumArtist
			// 
			this.checkBoxAlbumArtist.AutoSize = true;
			this.checkBoxAlbumArtist.Location = new System.Drawing.Point(8, 71);
			this.checkBoxAlbumArtist.Name = "checkBoxAlbumArtist";
			this.checkBoxAlbumArtist.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAlbumArtist.TabIndex = 51;
			this.checkBoxAlbumArtist.UseVisualStyleBackColor = true;
			// 
			// checkBoxArtist
			// 
			this.checkBoxArtist.AutoSize = true;
			this.checkBoxArtist.Location = new System.Drawing.Point(8, 29);
			this.checkBoxArtist.Name = "checkBoxArtist";
			this.checkBoxArtist.Size = new System.Drawing.Size(15, 14);
			this.checkBoxArtist.TabIndex = 50;
			this.checkBoxArtist.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(460, 25);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 49;
			this.button7.Text = "Save";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(286, 94);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "Comment";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(386, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "Track #";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(286, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 46;
			this.label7.Text = "Year";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(286, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Genre";
			// 
			// textBoxComment
			// 
			this.textBoxComment.Location = new System.Drawing.Point(289, 110);
			this.textBoxComment.Multiline = true;
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(246, 62);
			this.textBoxComment.TabIndex = 44;
			this.textBoxComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComment_KeyPress);
			// 
			// textBoxTrackNumber
			// 
			this.textBoxTrackNumber.Location = new System.Drawing.Point(389, 68);
			this.textBoxTrackNumber.Name = "textBoxTrackNumber";
			this.textBoxTrackNumber.Size = new System.Drawing.Size(49, 20);
			this.textBoxTrackNumber.TabIndex = 43;
			this.textBoxTrackNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTrackNumber_KeyPress);
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(289, 68);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.Size = new System.Drawing.Size(63, 20);
			this.textBoxYear.TabIndex = 42;
			this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
			// 
			// textBoxGenre
			// 
			this.textBoxGenre.Location = new System.Drawing.Point(289, 26);
			this.textBoxGenre.Name = "textBoxGenre";
			this.textBoxGenre.Size = new System.Drawing.Size(149, 20);
			this.textBoxGenre.TabIndex = 41;
			this.textBoxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGenre_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "Album Artist";
			// 
			// textBoxAlbum
			// 
			this.textBoxAlbum.Location = new System.Drawing.Point(29, 152);
			this.textBoxAlbum.Name = "textBoxAlbum";
			this.textBoxAlbum.Size = new System.Drawing.Size(221, 20);
			this.textBoxAlbum.TabIndex = 39;
			this.textBoxAlbum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlbum_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "Album";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "Artist";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(29, 110);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(221, 20);
			this.textBoxTitle.TabIndex = 35;
			this.textBoxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitle_KeyPress);
			// 
			// textBoxAlbumArtist
			// 
			this.textBoxAlbumArtist.Location = new System.Drawing.Point(29, 68);
			this.textBoxAlbumArtist.Name = "textBoxAlbumArtist";
			this.textBoxAlbumArtist.Size = new System.Drawing.Size(221, 20);
			this.textBoxAlbumArtist.TabIndex = 34;
			this.textBoxAlbumArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlbumArtist_KeyPress);
			// 
			// textBoxArtist
			// 
			this.textBoxArtist.Location = new System.Drawing.Point(29, 26);
			this.textBoxArtist.Name = "textBoxArtist";
			this.textBoxArtist.Size = new System.Drawing.Size(221, 20);
			this.textBoxArtist.TabIndex = 33;
			this.textBoxArtist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArtist_KeyPress);
			// 
			// labelBitrate
			// 
			this.labelBitrate.AutoSize = true;
			this.labelBitrate.Location = new System.Drawing.Point(11, 123);
			this.labelBitrate.Name = "labelBitrate";
			this.labelBitrate.Size = new System.Drawing.Size(48, 13);
			this.labelBitrate.TabIndex = 38;
			this.labelBitrate.Text = "Bit Rate:";
			// 
			// labelSamplerate
			// 
			this.labelSamplerate.AutoSize = true;
			this.labelSamplerate.Location = new System.Drawing.Point(125, 123);
			this.labelSamplerate.Name = "labelSamplerate";
			this.labelSamplerate.Size = new System.Drawing.Size(71, 13);
			this.labelSamplerate.TabIndex = 39;
			this.labelSamplerate.Text = "Sample Rate:";
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(257, 123);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(50, 13);
			this.labelDuration.TabIndex = 40;
			this.labelDuration.Text = "Duration:";
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.Location = new System.Drawing.Point(363, 149);
			this.trackBarVolume.Maximum = 1000;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(72, 45);
			this.trackBarVolume.SmallChange = 100;
			this.trackBarVolume.TabIndex = 41;
			this.trackBarVolume.TickFrequency = 250;
			this.trackBarVolume.Value = 1000;
			this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
			this.trackBarVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarVolume_MouseDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(370, 123);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 42;
			this.label10.Text = "Volume";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(425, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 43;
			this.label11.Text = "Help";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 594);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.trackBarVolume);
			this.Controls.Add(this.labelDuration);
			this.Controls.Add(this.labelSamplerate);
			this.Controls.Add(this.labelBitrate);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.CheckboxAutoplay);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextboxFile);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1043, 632);
			this.Name = "Form1";
			this.Text = "Mp3 Sorter";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DirGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FileGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextboxFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView DirGrid;
		private System.Windows.Forms.DataGridView FileGrid;
		private System.Windows.Forms.CheckBox CheckboxAutoplay;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.TextBox textBoxTrackNumber;
		private System.Windows.Forms.TextBox textBoxYear;
		private System.Windows.Forms.TextBox textBoxGenre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxAlbum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxAlbumArtist;
		private System.Windows.Forms.TextBox textBoxArtist;
		private System.Windows.Forms.Label labelBitrate;
		private System.Windows.Forms.Label labelSamplerate;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.TrackBar trackBarVolume;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBoxTrackNumber;
		private System.Windows.Forms.CheckBox checkBoxComment;
		private System.Windows.Forms.CheckBox checkBoxYear;
		private System.Windows.Forms.CheckBox checkBoxGenre;
		private System.Windows.Forms.CheckBox checkBoxAlbum;
		private System.Windows.Forms.CheckBox checkBoxTitle;
		private System.Windows.Forms.CheckBox checkBoxAlbumArtist;
		private System.Windows.Forms.CheckBox checkBoxArtist;
	}
}

