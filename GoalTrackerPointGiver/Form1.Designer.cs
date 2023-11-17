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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalTrackerPointGiver));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.YearCalendar = new System.Windows.Forms.MonthCalendar();
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
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.MarkBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GoalSeeChck = new System.Windows.Forms.CheckBox();
			this.GoalClearBtn = new System.Windows.Forms.Button();
			this.GoalSetBtn = new System.Windows.Forms.Button();
			this.DaysLabel = new System.Windows.Forms.Label();
			this.dateItem1 = new Pabo.Calendar.DateItem();
			this.MoodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.MoodContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MoodContextDrop = new System.Windows.Forms.ToolStripComboBox();
			this.DesireChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.DesireContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DesireContextDrop = new System.Windows.Forms.ToolStripComboBox();
			this.NotesTxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mainMenuStrip.SuspendLayout();
			this.calendarDropContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.YearUpD)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoodChart)).BeginInit();
			this.MoodContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DesireChart)).BeginInit();
			this.DesireContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// YearCalendar
			// 
			this.YearCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
			this.YearCalendar.Location = new System.Drawing.Point(16, 29);
			this.YearCalendar.Margin = new System.Windows.Forms.Padding(8);
			this.YearCalendar.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
			this.YearCalendar.MaxSelectionCount = 367;
			this.YearCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
			this.YearCalendar.Name = "YearCalendar";
			this.YearCalendar.TabIndex = 0;
			this.YearCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YearCalendar_MouseDown);
			this.YearCalendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YearCalendar_MouseUp);
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
			this.EscBtn.Location = new System.Drawing.Point(899, 468);
			this.EscBtn.Name = "EscBtn";
			this.EscBtn.Size = new System.Drawing.Size(37, 21);
			this.EscBtn.TabIndex = 9;
			this.EscBtn.Text = "Esc";
			this.EscBtn.UseVisualStyleBackColor = true;
			this.EscBtn.Click += new System.EventHandler(this.EscBtn_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Goal Tracker Point Giver";
			this.notifyIcon1.Visible = true;
			// 
			// MarkBtn
			// 
			this.MarkBtn.Location = new System.Drawing.Point(946, 128);
			this.MarkBtn.Name = "MarkBtn";
			this.MarkBtn.Size = new System.Drawing.Size(88, 23);
			this.MarkBtn.TabIndex = 10;
			this.MarkBtn.Text = "Mark";
			this.MarkBtn.UseVisualStyleBackColor = true;
			this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.GoalSeeChck);
			this.groupBox1.Controls.Add(this.GoalClearBtn);
			this.groupBox1.Controls.Add(this.GoalSetBtn);
			this.groupBox1.Location = new System.Drawing.Point(946, 157);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(88, 99);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Goal";
			// 
			// GoalSeeChck
			// 
			this.GoalSeeChck.AutoSize = true;
			this.GoalSeeChck.Location = new System.Drawing.Point(6, 48);
			this.GoalSeeChck.Name = "GoalSeeChck";
			this.GoalSeeChck.Size = new System.Drawing.Size(45, 17);
			this.GoalSeeChck.TabIndex = 14;
			this.GoalSeeChck.Text = "See";
			this.GoalSeeChck.UseVisualStyleBackColor = true;
			this.GoalSeeChck.CheckedChanged += new System.EventHandler(this.GoalSeeChck_CheckedChanged);
			this.GoalSeeChck.EnabledChanged += new System.EventHandler(this.GoalSeeChck_EnabledChanged);
			// 
			// GoalClearBtn
			// 
			this.GoalClearBtn.Location = new System.Drawing.Point(6, 71);
			this.GoalClearBtn.Name = "GoalClearBtn";
			this.GoalClearBtn.Size = new System.Drawing.Size(76, 23);
			this.GoalClearBtn.TabIndex = 15;
			this.GoalClearBtn.Text = "Clear";
			this.GoalClearBtn.UseVisualStyleBackColor = true;
			this.GoalClearBtn.Click += new System.EventHandler(this.GoalClearBtn_Click);
			// 
			// GoalSetBtn
			// 
			this.GoalSetBtn.Location = new System.Drawing.Point(6, 19);
			this.GoalSetBtn.Name = "GoalSetBtn";
			this.GoalSetBtn.Size = new System.Drawing.Size(76, 23);
			this.GoalSetBtn.TabIndex = 0;
			this.GoalSetBtn.Text = "Set";
			this.GoalSetBtn.UseVisualStyleBackColor = true;
			this.GoalSetBtn.Click += new System.EventHandler(this.GoalSetBtn_Click);
			// 
			// DaysLabel
			// 
			this.DaysLabel.AutoSize = true;
			this.DaysLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.DaysLabel.Location = new System.Drawing.Point(943, 110);
			this.DaysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DaysLabel.Name = "DaysLabel";
			this.DaysLabel.Size = new System.Drawing.Size(32, 15);
			this.DaysLabel.TabIndex = 14;
			this.DaysLabel.Text = "Days";
			// 
			// dateItem1
			// 
			this.dateItem1.BackColor1 = System.Drawing.Color.White;
			this.dateItem1.BackColor2 = System.Drawing.Color.Transparent;
			this.dateItem1.BackgroundImage = null;
			this.dateItem1.BoldedDate = true;
			this.dateItem1.Date = new System.DateTime(2023, 11, 14, 0, 0, 0, 0);
			this.dateItem1.DateColor = System.Drawing.Color.Black;
			this.dateItem1.Enabled = true;
			this.dateItem1.GradientMode = Pabo.Calendar.mcGradientMode.None;
			this.dateItem1.Image = null;
			this.dateItem1.ImageListIndex = -1;
			this.dateItem1.Pattern = Pabo.Calendar.mcDayInfoRecurrence.None;
			this.dateItem1.Range = new System.DateTime(2023, 11, 14, 0, 0, 0, 0);
			this.dateItem1.Tag = null;
			this.dateItem1.Text = "";
			this.dateItem1.TextColor = System.Drawing.Color.Empty;
			this.dateItem1.Weekend = false;
			// 
			// MoodChart
			// 
			chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea3.Name = "ChartArea1";
			this.MoodChart.ChartAreas.Add(chartArea3);
			this.MoodChart.ContextMenuStrip = this.MoodContextMenu;
			this.MoodChart.Location = new System.Drawing.Point(946, 277);
			this.MoodChart.Name = "MoodChart";
			series3.BorderWidth = 0;
			series3.ChartArea = "ChartArea1";
			series3.LabelBorderWidth = 0;
			series3.MarkerBorderWidth = 0;
			series3.MarkerSize = 0;
			series3.Name = "Series1";
			this.MoodChart.Series.Add(series3);
			this.MoodChart.Size = new System.Drawing.Size(88, 40);
			this.MoodChart.TabIndex = 15;
			this.MoodChart.Text = "chart1";
			this.MoodChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MoodChart_MouseDoubleClick);
			// 
			// MoodContextMenu
			// 
			this.MoodContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoodContextDrop});
			this.MoodContextMenu.Name = "MoodContextMenu";
			this.MoodContextMenu.Size = new System.Drawing.Size(461, 31);
			this.MoodContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.MoodContextMenu_Opening);
			// 
			// MoodContextDrop
			// 
			this.MoodContextDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MoodContextDrop.Items.AddRange(new object[] {
            "10 - verging apotheosis",
            "09 - master and commander",
            "08 - onboard I\'m the captain so climb abord",
            "07 - it\'s a nice day outside",
            "06 - I\'m awake, so there\'s that",
            "05 - no awareness of problems or joys, existing in the moment",
            "04 - everyone should piss off",
            "03 - full of hate for the person you are and represent",
            "02 - verging suicide, leave the rest to their retarded joys",
            "01 - end existence, end the universe, end it all, initiate the next Big Bang",
            "Clear"});
			this.MoodContextDrop.Name = "MoodContextDrop";
			this.MoodContextDrop.Size = new System.Drawing.Size(400, 23);
			this.MoodContextDrop.SelectedIndexChanged += new System.EventHandler(this.MoodContextDrop_SelectedIndexChanged);
			// 
			// DesireChart
			// 
			chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.Name = "ChartArea1";
			this.DesireChart.ChartAreas.Add(chartArea1);
			this.DesireChart.ContextMenuStrip = this.DesireContextMenu;
			this.DesireChart.Location = new System.Drawing.Point(946, 338);
			this.DesireChart.Name = "DesireChart";
			series1.BorderWidth = 0;
			series1.ChartArea = "ChartArea1";
			series1.LabelBorderWidth = 0;
			series1.MarkerBorderWidth = 0;
			series1.Name = "Series1";
			this.DesireChart.Series.Add(series1);
			this.DesireChart.Size = new System.Drawing.Size(88, 40);
			this.DesireChart.TabIndex = 16;
			this.DesireChart.Text = "chart2";
			this.DesireChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DesireChart_MouseDoubleClick);
			// 
			// DesireContextMenu
			// 
			this.DesireContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.DesireContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DesireContextDrop});
			this.DesireContextMenu.Name = "CalendarContextMenu";
			this.DesireContextMenu.Size = new System.Drawing.Size(211, 31);
			this.DesireContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DesireContextMenu_Opening);
			// 
			// DesireContextDrop
			// 
			this.DesireContextDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DesireContextDrop.Items.AddRange(new object[] {
            "5 - verging uncontrollable",
            "4 - extreme",
            "3 - average and ready",
            "2 - could be asked to",
            "1 - flat line nothing",
            "0 - repulsion",
            "Clear"});
			this.DesireContextDrop.Name = "DesireContextDrop";
			this.DesireContextDrop.Size = new System.Drawing.Size(150, 23);
			this.DesireContextDrop.SelectedIndexChanged += new System.EventHandler(this.DesireContextDrop_SelectedIndexChanged);
			// 
			// NotesTxtBox
			// 
			this.NotesTxtBox.Location = new System.Drawing.Point(946, 399);
			this.NotesTxtBox.Multiline = true;
			this.NotesTxtBox.Name = "NotesTxtBox";
			this.NotesTxtBox.Size = new System.Drawing.Size(91, 90);
			this.NotesTxtBox.TabIndex = 17;
			this.NotesTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesTxtBox_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.label2.Location = new System.Drawing.Point(946, 259);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 15);
			this.label2.TabIndex = 18;
			this.label2.Text = "Mood:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.label4.Location = new System.Drawing.Point(946, 320);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 15);
			this.label4.TabIndex = 19;
			this.label4.Text = "Desire:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
			this.label5.Location = new System.Drawing.Point(946, 381);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "Notes:";
			// 
			// GoalTrackerPointGiver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.EscBtn;
			this.ClientSize = new System.Drawing.Size(1042, 492);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NotesTxtBox);
			this.Controls.Add(this.DesireChart);
			this.Controls.Add(this.MoodChart);
			this.Controls.Add(this.DaysLabel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MarkBtn);
			this.Controls.Add(this.YearUpD);
			this.Controls.Add(this.TrackerDrop);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.YearCalendar);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.EscBtn);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.Name = "GoalTrackerPointGiver";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Goal Tracker Point Giver - I\'ll give you points!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoalTrackerPointGiver_FormClosing);
			this.Load += new System.EventHandler(this.GoalTrackerPointGiver_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.calendarDropContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.YearUpD)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoodChart)).EndInit();
			this.MoodContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DesireChart)).EndInit();
			this.DesireContextMenu.ResumeLayout(false);
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
		private NumericUpDown YearUpD;
		private ContextMenuStrip calendarDropContextMenu;
		private ToolStripMenuItem renameCalendarMenu;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripTextBox renameCalendarTextBox;
		private ToolStripMenuItem addCalendarMenu;
		private ToolStripTextBox addCalendarTextBox;
		private ToolStripMenuItem removeCalendarMenuBtn;
		private ToolTip toolTip1;
		private Button EscBtn;
		private NotifyIcon notifyIcon1;
		private Button MarkBtn;
		private GroupBox groupBox1;
		private Button GoalClearBtn;
		private Button GoalSetBtn;
		private CheckBox GoalSeeChck;
		private Label DaysLabel;
		private Pabo.Calendar.DateItem dateItem1;
		private System.Windows.Forms.DataVisualization.Charting.Chart MoodChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart DesireChart;
		private TextBox NotesTxtBox;
		private Label label2;
		private Label label4;
		private ContextMenuStrip DesireContextMenu;
		private ContextMenuStrip MoodContextMenu;
		private ToolStripComboBox MoodContextDrop;
		private ToolStripComboBox DesireContextDrop;
		private Label label5;
	}
}

