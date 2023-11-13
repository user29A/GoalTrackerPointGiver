using System.Drawing;
using System.Windows.Forms;
using System;

namespace GoalTrackerPointGiver
{
	partial class GoalTrackerPointGiver
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
			this.components = new System.ComponentModel.Container();
			this.YearCalendar = new System.Windows.Forms.MonthCalendar();
			this.CalendarContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CalendarContextDatesBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextMarkDatesBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextClearDatesBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextGoalBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextGoalSetBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextGoalSeeBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextGoalClearBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextNotesBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.calendarContextNotesTxt = new System.Windows.Forms.ToolStripTextBox();
			this.CalendarContextMoodBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextMoodDrop = new System.Windows.Forms.ToolStripComboBox();
			this.CalendarContextDesireBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CalendarContextDesireDrop = new System.Windows.Forms.ToolStripComboBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.userMainMenuTab = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TrackerDrop = new System.Windows.Forms.ComboBox();
			this.calendarDropContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameCalendarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.renameCalendarTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.addCalendarMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.addCalendarTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.removeCalendarMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.YearUpD = new System.Windows.Forms.NumericUpDown();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.EscBtn = new System.Windows.Forms.Button();
			this.CalendarContextMenu.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.calendarDropContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.YearUpD)).BeginInit();
			this.SuspendLayout();
			// 
			// YearCalendar
			// 
			this.YearCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
			this.YearCalendar.ContextMenuStrip = this.CalendarContextMenu;
			this.YearCalendar.Location = new System.Drawing.Point(16, 29);
			this.YearCalendar.Margin = new System.Windows.Forms.Padding(8);
			this.YearCalendar.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
			this.YearCalendar.MaxSelectionCount = 367;
			this.YearCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.YearCalendar.Name = "YearCalendar";
			this.YearCalendar.TabIndex = 0;
			// 
			// CalendarContextMenu
			// 
			this.CalendarContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.CalendarContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalendarContextDatesBtn});
			this.CalendarContextMenu.Name = "CalendarContextMenu";
			this.CalendarContextMenu.Size = new System.Drawing.Size(181, 48);
			this.CalendarContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CalendarContextMenu_Opening);
			// 
			// CalendarContextDatesBtn
			// 
			this.CalendarContextDatesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalendarContextMarkDatesBtn,
            this.CalendarContextClearDatesBtn,
            this.CalendarContextGoalBtn,
            this.CalendarContextNotesBtn,
            this.CalendarContextMoodBtn,
            this.CalendarContextDesireBtn});
			this.CalendarContextDatesBtn.Name = "CalendarContextDatesBtn";
			this.CalendarContextDatesBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextDatesBtn.Text = "Dates";
			// 
			// CalendarContextMarkDatesBtn
			// 
			this.CalendarContextMarkDatesBtn.Name = "CalendarContextMarkDatesBtn";
			this.CalendarContextMarkDatesBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextMarkDatesBtn.Text = "Mark";
			this.CalendarContextMarkDatesBtn.Click += new System.EventHandler(this.CalendarContextMarkDatesBtn_Click);
			// 
			// CalendarContextClearDatesBtn
			// 
			this.CalendarContextClearDatesBtn.Name = "CalendarContextClearDatesBtn";
			this.CalendarContextClearDatesBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextClearDatesBtn.Text = "Clear";
			this.CalendarContextClearDatesBtn.Click += new System.EventHandler(this.CalendarContextClearDatesBtn_Click);
			// 
			// CalendarContextGoalBtn
			// 
			this.CalendarContextGoalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalendarContextGoalSetBtn,
            this.CalendarContextGoalSeeBtn,
            this.CalendarContextGoalClearBtn});
			this.CalendarContextGoalBtn.Name = "CalendarContextGoalBtn";
			this.CalendarContextGoalBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextGoalBtn.Text = "Goal";
			this.CalendarContextGoalBtn.DropDownOpening += new System.EventHandler(this.CalendarContextGoalBtn_DropDownOpening);
			// 
			// CalendarContextGoalSetBtn
			// 
			this.CalendarContextGoalSetBtn.Name = "CalendarContextGoalSetBtn";
			this.CalendarContextGoalSetBtn.Size = new System.Drawing.Size(145, 22);
			this.CalendarContextGoalSetBtn.Text = "Set Selected";
			this.CalendarContextGoalSetBtn.Click += new System.EventHandler(this.CalendarContextGoalSetBtn_Click);
			// 
			// CalendarContextGoalSeeBtn
			// 
			this.CalendarContextGoalSeeBtn.Name = "CalendarContextGoalSeeBtn";
			this.CalendarContextGoalSeeBtn.Size = new System.Drawing.Size(145, 22);
			this.CalendarContextGoalSeeBtn.Text = "See Existing";
			this.CalendarContextGoalSeeBtn.Click += new System.EventHandler(this.CalendarContextGoalSeeBtn_Click);
			// 
			// CalendarContextGoalClearBtn
			// 
			this.CalendarContextGoalClearBtn.Name = "CalendarContextGoalClearBtn";
			this.CalendarContextGoalClearBtn.Size = new System.Drawing.Size(145, 22);
			this.CalendarContextGoalClearBtn.Text = "Clear Existing";
			this.CalendarContextGoalClearBtn.Click += new System.EventHandler(this.CalendarContextGoalClearBtn_Click);
			// 
			// CalendarContextNotesBtn
			// 
			this.CalendarContextNotesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarContextNotesTxt});
			this.CalendarContextNotesBtn.Name = "CalendarContextNotesBtn";
			this.CalendarContextNotesBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextNotesBtn.Text = "Notes";
			this.CalendarContextNotesBtn.DropDownOpening += new System.EventHandler(this.CalendarContextNotesBtn_DropDownOpening);
			this.CalendarContextNotesBtn.Click += new System.EventHandler(this.CalendarContextNotesBtn_Click);
			// 
			// calendarContextNotesTxt
			// 
			this.calendarContextNotesTxt.Name = "calendarContextNotesTxt";
			this.calendarContextNotesTxt.Size = new System.Drawing.Size(150, 23);
			this.calendarContextNotesTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalendarContextNotesTxt_KeyDown);
			// 
			// CalendarContextMoodBtn
			// 
			this.CalendarContextMoodBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalendarContextMoodDrop});
			this.CalendarContextMoodBtn.Name = "CalendarContextMoodBtn";
			this.CalendarContextMoodBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextMoodBtn.Text = "Mood";
			this.CalendarContextMoodBtn.DropDownOpening += new System.EventHandler(this.CalendarContextMoodBtn_DropDownOpening);
			// 
			// CalendarContextMoodDrop
			// 
			this.CalendarContextMoodDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CalendarContextMoodDrop.Items.AddRange(new object[] {
            "10 - verging apotheosis",
            "09 - master and commander",
            "08 - onboard I\'m the captain so climb abord",
            "07 - it\'s a nice day outside",
            "06 - I\'m awake, so there\'s that",
            "05 - no awareness of problems or joys, existing in the moment",
            "04 - everyone should piss off",
            "03 - full of hate for the person you are and represent",
            "02 - verging suicide, leave the rest to their retarded joys",
            "01 - end existence, end the universe, end it all, initiate the next Big Bang"});
			this.CalendarContextMoodDrop.Name = "CalendarContextMoodDrop";
			this.CalendarContextMoodDrop.Size = new System.Drawing.Size(400, 23);
			this.CalendarContextMoodDrop.SelectedIndexChanged += new System.EventHandler(this.CalendarContextMoodDrop_SelectedIndexChanged);
			// 
			// CalendarContextDesireBtn
			// 
			this.CalendarContextDesireBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalendarContextDesireDrop});
			this.CalendarContextDesireBtn.Name = "CalendarContextDesireBtn";
			this.CalendarContextDesireBtn.Size = new System.Drawing.Size(180, 22);
			this.CalendarContextDesireBtn.Text = "Desire";
			this.CalendarContextDesireBtn.DropDownOpening += new System.EventHandler(this.CalendarContextDesireBtn_DropDownOpening);
			// 
			// CalendarContextDesireDrop
			// 
			this.CalendarContextDesireDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CalendarContextDesireDrop.Items.AddRange(new object[] {
            "5 - verging uncontrollable",
            "4 - extreme",
            "3 - average and ready",
            "2 - could be asked to",
            "1 - flat line nothing",
            "0 - repulsion"});
			this.CalendarContextDesireDrop.Name = "CalendarContextDesireDrop";
			this.CalendarContextDesireDrop.Size = new System.Drawing.Size(150, 23);
			this.CalendarContextDesireDrop.SelectedIndexChanged += new System.EventHandler(this.CalendarContextDesireDrop_SelectedIndexChanged);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMainMenuTab});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.mainMenuStrip.Size = new System.Drawing.Size(1042, 24);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// userMainMenuTab
			// 
			this.userMainMenuTab.Name = "userMainMenuTab";
			this.userMainMenuTab.Size = new System.Drawing.Size(50, 20);
			this.userMainMenuTab.Text = "Menu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.label1.Location = new System.Drawing.Point(943, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Year:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.label3.Location = new System.Drawing.Point(943, 70);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tracker:";
			// 
			// TrackerDrop
			// 
			this.TrackerDrop.ContextMenuStrip = this.calendarDropContextMenu;
			this.TrackerDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TrackerDrop.FormattingEnabled = true;
			this.TrackerDrop.Location = new System.Drawing.Point(946, 87);
			this.TrackerDrop.Margin = new System.Windows.Forms.Padding(2);
			this.TrackerDrop.MaxLength = 7;
			this.TrackerDrop.Name = "TrackerDrop";
			this.TrackerDrop.Size = new System.Drawing.Size(88, 21);
			this.TrackerDrop.TabIndex = 7;
			this.TrackerDrop.SelectedIndexChanged += new System.EventHandler(this.TrackerDrop_SelectedIndexChanged);
			// 
			// calendarDropContextMenu
			// 
			this.calendarDropContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.calendarDropContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameCalendarMenu,
            this.addCalendarMenu,
            this.removeCalendarMenuBtn});
			this.calendarDropContextMenu.Name = "CalendarDropContextMenu";
			this.calendarDropContextMenu.Size = new System.Drawing.Size(118, 70);
			// 
			// renameCalendarMenu
			// 
			this.renameCalendarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.renameCalendarTextBox});
			this.renameCalendarMenu.Name = "renameCalendarMenu";
			this.renameCalendarMenu.Size = new System.Drawing.Size(117, 22);
			this.renameCalendarMenu.Text = "Rename";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
			// 
			// renameCalendarTextBox
			// 
			this.renameCalendarTextBox.MaxLength = 7;
			this.renameCalendarTextBox.Name = "renameCalendarTextBox";
			this.renameCalendarTextBox.Size = new System.Drawing.Size(175, 23);
			this.renameCalendarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RenameCalendarTextBox_KeyDown);
			// 
			// addCalendarMenu
			// 
			this.addCalendarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCalendarTextBox});
			this.addCalendarMenu.Name = "addCalendarMenu";
			this.addCalendarMenu.Size = new System.Drawing.Size(117, 22);
			this.addCalendarMenu.Text = "Add";
			// 
			// addCalendarTextBox
			// 
			this.addCalendarTextBox.MaxLength = 7;
			this.addCalendarTextBox.Name = "addCalendarTextBox";
			this.addCalendarTextBox.Size = new System.Drawing.Size(175, 23);
			this.addCalendarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCalendarTextBox_KeyDown);
			// 
			// removeCalendarMenuBtn
			// 
			this.removeCalendarMenuBtn.Name = "removeCalendarMenuBtn";
			this.removeCalendarMenuBtn.Size = new System.Drawing.Size(117, 22);
			this.removeCalendarMenuBtn.Text = "Remove";
			this.removeCalendarMenuBtn.Click += new System.EventHandler(this.RemoveCalendarMenuBtn_Click);
			// 
			// YearUpD
			// 
			this.YearUpD.Location = new System.Drawing.Point(946, 48);
			this.YearUpD.Margin = new System.Windows.Forms.Padding(2);
			this.YearUpD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.YearUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.YearUpD.Name = "YearUpD";
			this.YearUpD.Size = new System.Drawing.Size(51, 20);
			this.YearUpD.TabIndex = 8;
			this.YearUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.YearUpD.ValueChanged += new System.EventHandler(this.YearUpD_ValueChanged);
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 100;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 100;
			this.toolTip1.ReshowDelay = 20;
			// 
			// EscBtn
			// 
			this.EscBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EscBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.EscBtn.Location = new System.Drawing.Point(993, 459);
			this.EscBtn.Name = "EscBtn";
			this.EscBtn.Size = new System.Drawing.Size(37, 21);
			this.EscBtn.TabIndex = 9;
			this.EscBtn.Text = "Esc";
			this.EscBtn.UseVisualStyleBackColor = true;
			this.EscBtn.Click += new System.EventHandler(this.EscBtn_Click);
			// 
			// GoalTrackerPointGiver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.EscBtn;
			this.ClientSize = new System.Drawing.Size(1042, 492);
			this.Controls.Add(this.EscBtn);
			this.Controls.Add(this.YearUpD);
			this.Controls.Add(this.TrackerDrop);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.YearCalendar);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "GoalTrackerPointGiver";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Goal Tracker Point Giver - I\'ll give you points!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoalTrackerPointGiver_FormClosing);
			this.Load += new System.EventHandler(this.GoalTrackerPointGiver_Load);
			this.CalendarContextMenu.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.calendarDropContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.YearUpD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MonthCalendar YearCalendar;
		private MenuStrip mainMenuStrip;
		private ToolStripMenuItem userMainMenuTab;
		private Label label1;
		private Label label3;
		private ComboBox TrackerDrop;
		private ContextMenuStrip CalendarContextMenu;
		private ToolStripMenuItem CalendarContextDatesBtn;
		private ToolStripMenuItem CalendarContextMarkDatesBtn;
		private ToolStripMenuItem CalendarContextClearDatesBtn;
		private NumericUpDown YearUpD;
		private ContextMenuStrip calendarDropContextMenu;
		private ToolStripMenuItem renameCalendarMenu;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripTextBox renameCalendarTextBox;
		private ToolStripMenuItem addCalendarMenu;
		private ToolStripTextBox addCalendarTextBox;
		private ToolStripMenuItem removeCalendarMenuBtn;
		private ToolStripMenuItem CalendarContextNotesBtn;
		private ToolStripTextBox calendarContextNotesTxt;
		private ToolTip toolTip1;
		private ToolStripMenuItem CalendarContextMoodBtn;
		private Button EscBtn;
		private ToolStripComboBox CalendarContextMoodDrop;
		private ToolStripMenuItem CalendarContextDesireBtn;
		private ToolStripComboBox CalendarContextDesireDrop;
		private ToolStripMenuItem CalendarContextGoalBtn;
		private ToolStripMenuItem CalendarContextGoalSetBtn;
		private ToolStripMenuItem CalendarContextGoalSeeBtn;
		private ToolStripMenuItem CalendarContextGoalClearBtn;
	}
}

