namespace GoalTrackerPointGiver
{
	partial class NoteDateViewer
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
			this.NotesTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// NotesTextBox
			// 
			this.NotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NotesTextBox.Location = new System.Drawing.Point(0, 0);
			this.NotesTextBox.Multiline = true;
			this.NotesTextBox.Name = "NotesTextBox";
			this.NotesTextBox.ReadOnly = true;
			this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.NotesTextBox.Size = new System.Drawing.Size(579, 436);
			this.NotesTextBox.TabIndex = 0;
			// 
			// NoteDateViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 436);
			this.Controls.Add(this.NotesTextBox);
			this.Name = "NoteDateViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NoteDateViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox NotesTextBox;
	}
}