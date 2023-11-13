using JPFITS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GoalTrackerPointGiver
{
	public partial class GoalTrackerPointGiver : Form
	{
		public GoalTrackerPointGiver()
		{
			InitializeComponent();
		}

		readonly private string CALENDARSPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AstroWerks", "GoalTrackerPointGiver", "calendars");
		bool DISABLEREACTIONS = true;
		FITSBinTable CALENDAR;

		private void GoalTrackerPointGiver_Load(object sender, EventArgs e)
		{
			if (!Directory.Exists(CALENDARSPATH))
				Directory.CreateDirectory(CALENDARSPATH);

			int calendarindex;
			string[] cals = Directory.GetFiles(CALENDARSPATH);
			if (cals.Length > 0)
			{
				YearUpD.Value = Convert.ToDecimal(REG.GetReg("GoalTrackerPointGiver", "yearUpD"));
				calendarindex = Convert.ToInt32(REG.GetReg("GoalTrackerPointGiver", "calendarDrop"));

				CALENDAR = new FITSBinTable(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), "CALENDAR");

				TrackerDrop.Items.AddRange(CALENDAR.TableDataLabelTTYPEs);
				TrackerDrop.Items.Remove("NOTES");
				TrackerDrop.Items.Remove("MOOD");
				TrackerDrop.Items.Remove("DESIRE");
			}
			else
			{
				TrackerDrop.Items.Add("default");
				calendarindex = 0;
				YearUpD.Value = DateTime.Now.Year;
				CALENDAR = new FITSBinTable("CALENDAR");
			}

			DISABLEREACTIONS = false;
			TrackerDrop.SelectedIndex = calendarindex;

			this.Left = (int)REG.GetReg("GoalTrackerPointGiver", "startx");
			this.Top = (int)REG.GetReg("GoalTrackerPointGiver", "starty");
		}

		private void CalendarContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (YearCalendar.SelectionRange.Start.Month == YearCalendar.SelectionRange.End.Month && YearCalendar.SelectionRange.Start.Day == YearCalendar.SelectionRange.End.Day)
				CalendarContextDatesBtn.Text = YearCalendar.SelectionRange.Start.Month + "-" + YearCalendar.SelectionRange.Start.Day;
			else
				CalendarContextDatesBtn.Text = YearCalendar.SelectionRange.Start.Month + "-" + YearCalendar.SelectionRange.Start.Day + " to " + YearCalendar.SelectionRange.End.Month + "-" + YearCalendar.SelectionRange.End.Day;

			//check if selection range already contains any bolded dates, and if it does, give option to clear those
			//yearCalendar.SelectionRange
		}

		private void UpdateCalendarMarkedDates()
		{
			bool[] marked = new bool[365];
			if (DateTime.IsLeapYear((int)YearUpD.Value))
				marked = new bool[366];
			for (int i = 0; i < YearCalendar.BoldedDates.Length; i++)
				marked[YearCalendar.BoldedDates[i].DayOfYear - 1] = true;
			CALENDAR.AddTTYPEEntry(TrackerDrop.SelectedItem.ToString(), true, "", marked);
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
		}

		private void CalendarContextMarkDatesBtn_Click(object sender, EventArgs e)
		{
			int Ndays = YearCalendar.SelectionRange.End.DayOfYear - YearCalendar.SelectionRange.Start.DayOfYear + 1;
			int currentmonth = YearCalendar.SelectionRange.Start.Month;
			int currentstartday = YearCalendar.SelectionRange.Start.Day;
			int accumulateddays = 1;

			for (int i = 0; i < Ndays; i++)
				if (i == 0)
					YearCalendar.AddBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, YearCalendar.SelectionRange.Start.Month, YearCalendar.SelectionRange.Start.Day));
				else if ((currentstartday + accumulateddays) <= DateTime.DaysInMonth(YearCalendar.SelectionRange.Start.Year, currentmonth))
					YearCalendar.AddBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, currentmonth, currentstartday + accumulateddays++));
				else
				{
					currentmonth++;
					currentstartday = 1;
					accumulateddays = 1;
					YearCalendar.AddBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, currentmonth, currentstartday));
				}

			YearCalendar.UpdateBoldedDates();

			UpdateCalendarMarkedDates();
		}

		private void CalendarContextClearDatesBtn_Click(object sender, EventArgs e)
		{
			int Ndays = YearCalendar.SelectionRange.End.DayOfYear - YearCalendar.SelectionRange.Start.DayOfYear + 1;
			int currentmonth = YearCalendar.SelectionRange.Start.Month;
			int currentstartday = YearCalendar.SelectionRange.Start.Day;
			int accumulateddays = 1;

			for (int i = 0; i < Ndays; i++)
				if (i == 0)
					YearCalendar.RemoveBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, YearCalendar.SelectionRange.Start.Month, YearCalendar.SelectionRange.Start.Day));
				else if ((currentstartday + accumulateddays) <= DateTime.DaysInMonth(YearCalendar.SelectionRange.Start.Year, currentmonth))
					YearCalendar.RemoveBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, currentmonth, currentstartday + accumulateddays++));
				else
				{
					currentmonth++;
					currentstartday = 1;
					accumulateddays = 1;
					YearCalendar.RemoveBoldedDate(new DateTime(YearCalendar.SelectionRange.Start.Year, currentmonth, currentstartday));
				}

			YearCalendar.UpdateBoldedDates();

			UpdateCalendarMarkedDates();
		}		

		private void CalendarContextNotesTxt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;

				string[] notes = new string[365];
				if (CALENDAR.TTYPEEntryExists("NOTES"))
					notes = CALENDAR.GetTTYPEEntry("NOTES", out _, out _) as string[];
                else
					if (DateTime.IsLeapYear((int)YearUpD.Value))
						notes = new string[366];

				notes[YearCalendar.SelectionStart.DayOfYear] = Convert.ToBase64String(Encoding.UTF8.GetBytes(calendarContextNotesTxt.Text));
				calendarContextNotesTxt.Text = "";

				for (int i = 0; i < notes.Length; i++)
					if (String.IsNullOrEmpty(notes[i]))
						notes[i] = " ";

				CALENDAR.AddTTYPEEntry("NOTES", true, "", notes, FITSBinTable.EntryArrayFormat.IsHeapVariableLengthRows);
				CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
			}
		}

		private void CalendarContextNotesBtn_Click(object sender, EventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("NOTES"))
				return;

			string[] notes = CALENDAR.GetTTYPEEntry("NOTES", out _, out _) as string[];

			if (!String.IsNullOrWhiteSpace(notes[YearCalendar.SelectionStart.DayOfYear]))
				MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(notes[YearCalendar.SelectionStart.DayOfYear])));
		}

		private void CalendarContextNotesBtn_DropDownOpening(object sender, EventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("NOTES"))
				return;

			string[] notes = CALENDAR.GetTTYPEEntry("NOTES", out _, out _) as string[];

			if (!String.IsNullOrWhiteSpace(notes[YearCalendar.SelectionStart.DayOfYear]))
				calendarContextNotesTxt.Text = Encoding.UTF8.GetString(Convert.FromBase64String(notes[YearCalendar.SelectionStart.DayOfYear]));
			else
				calendarContextNotesTxt.Text = "";
		}

		private void CalendarContextMoodDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			byte[] mood = new byte[365];
			if (CALENDAR.TTYPEEntryExists("MOOD"))
				mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as byte[];
			else
				if (DateTime.IsLeapYear((int)YearUpD.Value))
					mood = new byte[366];

			mood[YearCalendar.SelectionStart.DayOfYear] = (byte)(CalendarContextMoodDrop.SelectedIndex + 1);

			CALENDAR.AddTTYPEEntry("MOOD", true, "", mood);
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
		}

		private void CalendarContextMoodBtn_DropDownOpening(object sender, EventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("MOOD"))
				return;

			byte[] mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as byte[];

			if (mood[YearCalendar.SelectionStart.DayOfYear] != 0)
				CalendarContextMoodDrop.SelectedIndex = mood[YearCalendar.SelectionStart.DayOfYear] - 1;
			else
				CalendarContextMoodDrop.SelectedIndex = -1;
		}

		private void CalendarContextDesireDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			byte[] desire = new byte[365];
			if (CALENDAR.TTYPEEntryExists("DESIRE"))
				desire = CALENDAR.GetTTYPEEntry("DESIRE", out _, out _) as byte[];
			else
				if (DateTime.IsLeapYear((int)YearUpD.Value))
					desire = new byte[366];

			desire[YearCalendar.SelectionStart.DayOfYear] = (byte)(CalendarContextDesireDrop.SelectedIndex + 1);

			CALENDAR.AddTTYPEEntry("DESIRE", true, "", desire);
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
		}

		private void CalendarContextDesireBtn_DropDownOpening(object sender, EventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("DESIRE"))
				return;

			byte[] desire = CALENDAR.GetTTYPEEntry("DESIRE", out _, out _) as byte[];

			if (desire[YearCalendar.SelectionStart.DayOfYear] != 0)
				CalendarContextDesireDrop.SelectedIndex = desire[YearCalendar.SelectionStart.DayOfYear] - 1;
			else
				CalendarContextDesireDrop.SelectedIndex = -1;
		}

		private void CalendarContextGoalSetBtn_Click(object sender, EventArgs e)
		{
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S");
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E");

			CALENDAR.AddExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S", YearCalendar.SelectionRange.Start.DayOfYear.ToString(), "goal start day");
			CALENDAR.AddExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E", YearCalendar.SelectionRange.End.DayOfYear.ToString(), "goal end day");
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
		}

		private void CalendarContextGoalSeeBtn_Click(object sender, EventArgs e)
		{
			int strt = Convert.ToInt32(CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "S"));
			int end = Convert.ToInt32(CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "E"));

			DateTime st = (new DateTime((int)YearUpD.Value, 1, 1)).AddDays(strt - 1);
			DateTime en = (new DateTime((int)YearUpD.Value, 1, 1)).AddDays(end - 1);

			YearCalendar.SetSelectionRange(st, en);
		}

		private void CalendarContextGoalClearBtn_Click(object sender, EventArgs e)
		{
			YearCalendar.SelectionStart = DateTime.Today;
			YearCalendar.SelectionEnd = DateTime.Today;

			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S");
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E");
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);			
		}

		private void CalendarContextGoalBtn_DropDownOpening(object sender, EventArgs e)
		{
			if (CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "S") == "")
			{
				CalendarContextGoalSeeBtn.Enabled = false;
				CalendarContextGoalClearBtn.Enabled = false;
			}
			else
			{
				CalendarContextGoalSeeBtn.Enabled = true;
				CalendarContextGoalClearBtn.Enabled = true;
			}
		}

		private void GoalTrackerPointGiver_FormClosing(object sender, FormClosingEventArgs e)
		{
			REG.SetReg("GoalTrackerPointGiver", "calendarDrop", TrackerDrop.SelectedIndex);
			REG.SetReg("GoalTrackerPointGiver", "yearUpD", YearUpD.Value);
			REG.SetReg("GoalTrackerPointGiver", "startx", this.Location.X);
			REG.SetReg("GoalTrackerPointGiver", "starty", this.Location.Y);
		}

		private void TrackerDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			YearCalendar.RemoveAllBoldedDates();
			YearCalendar.UpdateBoldedDates();
			YearCalendar.SelectionStart = DateTime.Today;
			YearCalendar.SelectionEnd = DateTime.Today;

			if (!File.Exists(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString())))
				return;

			bool[] marked = (bool[])CALENDAR.GetTTYPEEntry(TrackerDrop.SelectedItem.ToString(), out _, out _);

			for (int i = 0; i < marked.Length; i++)
				if (marked[i])
					YearCalendar.AddBoldedDate((new DateTime((int)YearUpD.Value, 1, 1)).AddDays(i));

			YearCalendar.UpdateBoldedDates();
		}

		private void YearUpD_ValueChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			if (!File.Exists(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString())))
				if (MessageBox.Show("No calendar exists for this year. Would you like to create a calendar for " + YearUpD.Value.ToString() + "?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					YearUpD.Value = DateTime.Now.Year;
					return;
				}
				else
				{
					DialogResult res = MessageBox.Show("Copy existing trackers to new year " + YearUpD.Value.ToString() + "?", "", MessageBoxButtons.YesNoCancel);
					if (res == DialogResult.Cancel)
					{
						YearUpD.Value = DateTime.Now.Year;
						return;
					}
					else if (res == DialogResult.No)
					{
						TrackerDrop.Items.Clear();
						TrackerDrop.Items.Add("default");
						CALENDAR = new FITSBinTable("CALENDAR");
						TrackerDrop.SelectedIndex = 0;
					}
					else//Yes
					{
						string[] tracks = CALENDAR.TableDataLabelTTYPEs;

					}
				}
			
			//year calendar exists
			
		}

		private void RenameCalendarTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;

				if (renameCalendarTextBox.Text.Length == 0)
					return;

				CALENDAR.RemoveTTYPEEntry(TrackerDrop.SelectedItem.ToString());

				bool[] marked = new bool[365];
				if (DateTime.IsLeapYear((int)YearUpD.Value))
					marked = new bool[366];

				for (int i = 0; i < YearCalendar.BoldedDates.Length; i++)
					marked[YearCalendar.BoldedDates[i].DayOfYear - 1] = true;

				CALENDAR.AddTTYPEEntry(renameCalendarTextBox.Text, true, "", marked);
				CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);

				TrackerDrop.Items.RemoveAt(TrackerDrop.SelectedIndex);
				TrackerDrop.Items.Add(renameCalendarTextBox.Text);
				renameCalendarTextBox.Text = "";
				TrackerDrop.SelectedIndex = TrackerDrop.Items.Count - 1;
			}
		}

		private void AddCalendarTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;

				if (addCalendarTextBox.Text.Length == 0)
					return;

				bool[] marked = new bool[365];
				if (DateTime.IsLeapYear((int)YearUpD.Value))
					marked = new bool[366];

				CALENDAR.AddTTYPEEntry(addCalendarTextBox.Text, true, "", marked);
				CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
				TrackerDrop.Items.Add(addCalendarTextBox.Text);
				addCalendarTextBox.Text = "";
				DISABLEREACTIONS = true;
				TrackerDrop.SelectedIndex = TrackerDrop.Items.Count - 1;

				YearCalendar.RemoveAllBoldedDates();
				YearCalendar.UpdateBoldedDates();

				DISABLEREACTIONS = false;
				UpdateCalendarMarkedDates();
			}
		}

		private void RemoveCalendarMenuBtn_Click(object sender, EventArgs e)
		{
			if (TrackerDrop.Items.Count == 1)
				return;

			CALENDAR.RemoveTTYPEEntry(TrackerDrop.SelectedItem.ToString());

			int index = TrackerDrop.SelectedIndex;
			TrackerDrop.Items.RemoveAt(TrackerDrop.SelectedIndex);
			TrackerDrop.SelectedIndex = index - 1;
		}

		private void EscBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
				
	}
}

