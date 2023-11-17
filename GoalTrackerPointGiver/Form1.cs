using JPFITS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
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

				bool[] marked = new bool[365];
				if (DateTime.IsLeapYear((int)YearUpD.Value))
					marked = new bool[366];
				CALENDAR.AddTTYPEEntry("default", true, "", marked);

				sbyte[] mood = new sbyte[365];
				sbyte[] desire = new sbyte[365];
				string[] notes = new string[365];
				if (DateTime.IsLeapYear((int)YearUpD.Value))
				{
					mood = new sbyte[366];
					desire = new sbyte[366];
					notes = new string[366];
				}
					
				for (int i = 0; i < mood.Length; i++)
				{
					mood[i] = -1;
					desire[i] = -1;
					notes[i] = " ";
				}
				CALENDAR.AddTTYPEEntry("MOOD", true, "", mood);
				CALENDAR.AddTTYPEEntry("DESIRE", true, "", desire);
				CALENDAR.AddTTYPEEntry("NOTES", true, "", notes, FITSBinTable.EntryArrayFormat.IsHeapVariableLengthRows);
				CALENDAR.AddExtraHeaderKey("YEAR", YearUpD.Value.ToString(), "the year of the calendar extension");
			}

			DISABLEREACTIONS = false;
			TrackerDrop.SelectedIndex = calendarindex;

			try
			{
				this.Left = (int)REG.GetReg("GoalTrackerPointGiver", "startx");
				this.Top = (int)REG.GetReg("GoalTrackerPointGiver", "starty");
				GoalSeeChck.Checked = Convert.ToBoolean(REG.GetReg("GoalTrackerPointGiver", "GoalSeeChck"));
			}
			catch
			{

			}
		}

		private void GoalTrackerPointGiver_FormClosing(object sender, FormClosingEventArgs e)
		{
			REG.SetReg("GoalTrackerPointGiver", "calendarDrop", TrackerDrop.SelectedIndex);
			REG.SetReg("GoalTrackerPointGiver", "yearUpD", YearUpD.Value);
			REG.SetReg("GoalTrackerPointGiver", "startx", this.Location.X);
			REG.SetReg("GoalTrackerPointGiver", "starty", this.Location.Y);
			REG.SetReg("GoalTrackerPointGiver", "GoalSeeChck", GoalSeeChck.Checked);
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

		private void MarkBtn_Click(object sender, EventArgs e)
		{
			if (MarkBtn.Text == "Mark")
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

				MarkBtn.Text = "Clear";
			}
			else
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

				MarkBtn.Text = "Mark";
			}

			YearCalendar.UpdateBoldedDates();
			UpdateCalendarMarkedDates();
		}

		private void YearCalendar_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				bool[] marked = CALENDAR.GetTTYPEEntry(TrackerDrop.SelectedItem.ToString(), out _, out _) as bool[];
				int ndays = YearCalendar.SelectionEnd.DayOfYear - YearCalendar.SelectionStart.DayOfYear + 1;
				int selectedNmarked = 0;
				for (int i = 0; i < ndays; i++)
					if (marked[YearCalendar.SelectionStart.AddDays(i).DayOfYear - 1])
						selectedNmarked++;

				if (selectedNmarked < ndays)
					MarkBtn.Text = "Mark";
				else
					MarkBtn.Text = "Clear";

				if (YearCalendar.SelectionRange.Start.Month == YearCalendar.SelectionRange.End.Month && YearCalendar.SelectionRange.Start.Day == YearCalendar.SelectionRange.End.Day)
				{
					DaysLabel.Text = YearCalendar.SelectionRange.Start.Month + "-" + YearCalendar.SelectionRange.Start.Day;
					NotesTxtBox.Text = Encoding.UTF8.GetString(Convert.FromBase64String((CALENDAR.GetTTYPEEntry("NOTES", out _, out _) as string[])[YearCalendar.SelectionRange.Start.DayOfYear - 1]));
				}
				else
					DaysLabel.Text = YearCalendar.SelectionRange.Start.Month + "-" + YearCalendar.SelectionRange.Start.Day + " to " + YearCalendar.SelectionRange.End.Month + "-" + YearCalendar.SelectionRange.End.Day;

				sbyte[] mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as sbyte[];
				sbyte[] moodata = new sbyte[ndays];
				Array.Copy(mood, YearCalendar.SelectionStart.DayOfYear - 1, moodata, 0, moodata.Length);
				MoodChart.Series[0].Points.Clear();
				for (int i = 0; i < moodata.Length; i++)
					if (moodata[i] != -1)
						MoodChart.Series[0].Points.AddXY(YearCalendar.SelectionStart.AddDays(i).DayOfYear, 11 - moodata[i]);
				MoodChart.ChartAreas[0].AxisY.Maximum = 11;

				sbyte[] desire = CALENDAR.GetTTYPEEntry("DESIRE", out _, out _) as sbyte[];
				sbyte[] desiredata = new sbyte[ndays];
				Array.Copy(desire, YearCalendar.SelectionStart.DayOfYear - 1, desiredata, 0, desiredata.Length);
				DesireChart.Series[0].Points.Clear();
				for (int i = 0; i < desiredata.Length; i++)
					if (desiredata[i] != -1)
						DesireChart.Series[0].Points.AddXY(YearCalendar.SelectionStart.AddDays(i).DayOfYear, 6 - desiredata[i]);
				DesireChart.ChartAreas[0].AxisY.Maximum = 6;
			}
		}

		private void MoodChart_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//int year = Convert.ToInt32(CALENDAR.GetExtraHeaderKeyValue("YEAR"));
			//int ndays = YearCalendar.SelectionEnd.DayOfYear - YearCalendar.SelectionStart.DayOfYear + 1;
			//DateTime[] days = new DateTime[ndays];
			//sbyte[] mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as sbyte[];
			
			//DayPlot dp = new DayPlot();
			//dp.chart1.Series[0].Points.Clear();
			//dp.chart1.Series[0].XValueType = ChartValueType.Date;
			//dp.chart1.Series[0].YValueType = ChartValueType.Int32;
			//dp.chart1.ChartAreas[0].AxisY.Maximum = 11;

			//for (int i = 0; i < ndays; i++)
			//{
			//	dp.chart1.Series[0].Points.AddXY((new DateTime(year, 1, 1)).AddDays(YearCalendar.SelectionStart.DayOfYear + i - 1), 11 - mood[YearCalendar.SelectionStart.DayOfYear + i - 1]);
			//}

			////
			//dp.Show();

		}

		private void DesireChart_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void YearCalendar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				DISABLEREACTIONS = true;
				GoalSeeChck.Checked = false;
				DISABLEREACTIONS = false;
			}
		}

		private void NotesTxtBox_KeyDown(object sender, KeyEventArgs e)
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

				notes[YearCalendar.SelectionStart.DayOfYear - 1] = Convert.ToBase64String(Encoding.UTF8.GetBytes(NotesTxtBox.Text));
				NotesTxtBox.Text = "";

				for (int i = 0; i < notes.Length; i++)
					if (String.IsNullOrEmpty(notes[i]))
						notes[i] = " ";

				CALENDAR.AddTTYPEEntry("NOTES", true, "", notes, FITSBinTable.EntryArrayFormat.IsHeapVariableLengthRows);
				CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
			}
		}		

		private void MoodContextDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MoodContextDrop.SelectedIndex == -1)
				return;

			sbyte[] mood = new sbyte[365];
			if (DateTime.IsLeapYear((int)YearUpD.Value))
				mood = new sbyte[366];
			
			if (CALENDAR.TTYPEEntryExists("MOOD"))
				mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as sbyte[];
			else
				for (int i = 0; i < mood.Length; i++)
					mood[i] = -1;

			if (MoodContextDrop.SelectedItem.ToString() == "Clear")
				mood[YearCalendar.SelectionStart.DayOfYear - 1] = -1;
			else
				mood[YearCalendar.SelectionStart.DayOfYear - 1] = (sbyte)(MoodContextDrop.SelectedIndex);

			CALENDAR.AddTTYPEEntry("MOOD", true, "", mood);
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);

			MoodContextMenu.Close();
			YearCalendar_MouseUp(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
		}

		private void MoodContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("MOOD"))
				return;

			sbyte[] mood = CALENDAR.GetTTYPEEntry("MOOD", out _, out _) as sbyte[];

			MoodContextDrop.SelectedIndex = mood[YearCalendar.SelectionStart.DayOfYear - 1];
		}		

		private void DesireContextDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DesireContextDrop.SelectedIndex == -1)
				return;

			sbyte[] desire = new sbyte[365];
			if (DateTime.IsLeapYear((int)YearUpD.Value))
				desire = new sbyte[366];

			if (CALENDAR.TTYPEEntryExists("DESIRE"))
				desire = CALENDAR.GetTTYPEEntry("DESIRE", out _, out _) as sbyte[];
			else
				for (int i = 0; i < desire.Length; i++)
					desire[i] = -1;

			if (DesireContextDrop.SelectedItem.ToString() == "Clear")
				desire[YearCalendar.SelectionStart.DayOfYear - 1] = -1;
			else
				desire[YearCalendar.SelectionStart.DayOfYear - 1] = (sbyte)(DesireContextDrop.SelectedIndex);

			CALENDAR.AddTTYPEEntry("DESIRE", true, "", desire);
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);

			DesireContextMenu.Close();
			YearCalendar_MouseUp(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
		}

		private void DesireContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!CALENDAR.TTYPEEntryExists("DESIRE"))
				return;

			sbyte[] desire = CALENDAR.GetTTYPEEntry("DESIRE", out _, out _) as sbyte[];

			DesireContextDrop.SelectedIndex = desire[YearCalendar.SelectionStart.DayOfYear - 1];
		}

		private void GoalSetBtn_Click(object sender, EventArgs e)
		{
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S");
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E");

			CALENDAR.AddExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S", YearCalendar.SelectionRange.Start.DayOfYear.ToString(), "goal start day");
			CALENDAR.AddExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E", YearCalendar.SelectionRange.End.DayOfYear.ToString(), "goal end day");
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);

			GoalSeeChck.Checked = true;
			GoalSeeChck.Enabled = true;
			GoalClearBtn.Enabled = true;
		}

		private void GoalSeeChck_CheckedChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			if (!GoalSeeChck.Checked)
			{
				YearCalendar.SelectionStart = DateTime.Today;
				YearCalendar.SelectionEnd = DateTime.Today;
				return;
			}

			int strt = Convert.ToInt32(CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "S"));
			int end = Convert.ToInt32(CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "E"));

			DateTime st = (new DateTime((int)YearUpD.Value, 1, 1)).AddDays(strt - 1);
			DateTime en = (new DateTime((int)YearUpD.Value, 1, 1)).AddDays(end - 1);

			YearCalendar.SetSelectionRange(st, en);
		}

		private void GoalSeeChck_EnabledChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			if (GoalSeeChck.Enabled == false)
			{
				YearCalendar.SelectionStart = DateTime.Today;
				YearCalendar.SelectionEnd = DateTime.Today;
			}
		}

		private void GoalClearBtn_Click(object sender, EventArgs e)
		{
			YearCalendar.SelectionStart = DateTime.Today;
			YearCalendar.SelectionEnd = DateTime.Today;

			GoalSeeChck.Checked = false;
			GoalSeeChck.Enabled = false;
			GoalClearBtn.Enabled = false;

			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "S");
			CALENDAR.RemoveExtraHeaderKey(TrackerDrop.SelectedItem.ToString() + "E");
			CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
		}
		
		private void TrackerDrop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			YearCalendar.RemoveAllBoldedDates();
			YearCalendar.UpdateBoldedDates();
			//YearCalendar.SelectionStart = DateTime.Today;
			//YearCalendar.SelectionEnd = DateTime.Today;

			if (!File.Exists(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString())))
				return;

			bool[] marked = (bool[])CALENDAR.GetTTYPEEntry(TrackerDrop.SelectedItem.ToString(), out _, out _);

			for (int i = 0; i < marked.Length; i++)
				if (marked[i])
					YearCalendar.AddBoldedDate((new DateTime((int)YearUpD.Value, 1, 1)).AddDays(i));

			YearCalendar.UpdateBoldedDates();

			if (CALENDAR.GetExtraHeaderKeyValue(TrackerDrop.SelectedItem.ToString() + "S") == "")
			{
				GoalSeeChck.Enabled = false;
				GoalClearBtn.Enabled = false;
			}
			else
			{
				GoalSeeChck.Enabled = true;
				GoalClearBtn.Enabled = true;

				if (GoalSeeChck.Checked)
					GoalSeeChck_CheckedChanged(sender, new EventArgs());
			}
		}

		private void YearUpD_ValueChanged(object sender, EventArgs e)
		{
			if (DISABLEREACTIONS)
				return;

			if (!File.Exists(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString())))
				if (MessageBox.Show("No calendar exists for this year. Would you like to create a calendar for " + YearUpD.Value.ToString() + "?", YearUpD.Value.ToString(), MessageBoxButtons.YesNo) == DialogResult.No)
				{
					YearUpD.Value = DateTime.Now.Year;
					return;
				}
				else
				{
					DialogResult res = MessageBox.Show("Copy existing trackers to new year " + YearUpD.Value.ToString() + "?", YearUpD.Value.ToString(), MessageBoxButtons.YesNoCancel);
					if (res == DialogResult.Cancel)
					{
						YearUpD.Value = DateTime.Now.Year;
						return;
					}
					else
					{
						int selectedindex;
						CALENDAR = new FITSBinTable("CALENDAR");
						CALENDAR.AddExtraHeaderKey("YEAR", YearUpD.Value.ToString(), "the year of the calendar extension");

						if (res == DialogResult.No)
						{
							TrackerDrop.Items.Clear();
							TrackerDrop.Items.Add("default");

							bool[] marked = new bool[365];
							if (DateTime.IsLeapYear((int)YearUpD.Value))
								marked = new bool[366];

							CALENDAR.AddTTYPEEntry(TrackerDrop.Items[0].ToString(), true, "", marked);
							selectedindex = 0;
						}
						else
						{
							for (int i = 0; i < TrackerDrop.Items.Count; i++)
							{
								bool[] marked = new bool[365];
								if (DateTime.IsLeapYear((int)YearUpD.Value))
									marked = new bool[366];

								CALENDAR.AddTTYPEEntry(TrackerDrop.Items[i].ToString(), true, "", marked);
							}

							selectedindex = TrackerDrop.SelectedIndex;
						}

						CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
						TrackerDrop.SelectedIndex = selectedindex;
						return;
					}
				}

			//else
			//year calendar exists
			string currentrack = TrackerDrop.SelectedItem.ToString();
			CALENDAR = new FITSBinTable(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), "CALENDAR");
			TrackerDrop.Items.Clear();
			string[] tracks = CALENDAR.TableDataLabelTTYPEs;
			for (int i = 0; i < tracks.Length; i++)
				if (CALENDAR.GetTTYPETypeCode(tracks[i]) == TypeCode.Boolean)
					TrackerDrop.Items.Add(tracks[i]);
			
			if (TrackerDrop.Items.IndexOf(currentrack) == -1)
				TrackerDrop.SelectedIndex = 0;
			else
				TrackerDrop.SelectedIndex = TrackerDrop.Items.IndexOf(currentrack);
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
			if (MessageBox.Show("Are you sure you would like to exit?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				CALENDAR.Write(Path.Combine(CALENDARSPATH, YearUpD.Value.ToString()), true);
				this.Close();
			}
		}
		
	}
}

