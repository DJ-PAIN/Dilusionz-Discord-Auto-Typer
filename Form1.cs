using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Dilusionz_Discord_Auto_Typer.Properties;
// Archived by Vista Group 
namespace Dilusionz_Discord_Auto_Typer
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000003 RID: 3
		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr point);

		// Token: 0x06000004 RID: 4
		[DllImport("User32.dll")]
		private static extern int SwitchToThisWindow(IntPtr point, bool a);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000006 RID: 6 RVA: 0x00002610 File Offset: 0x00000810
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 786)
			{
				int num = (int)m.LParam >> 16 & 65535;
				int num2 = (int)m.LParam & 65535;
				int num3 = m.WParam.ToInt32();
				if (num3 == this.startKeyID)
				{
					if (!this.timerExists)
					{
						if (this.incrementAdd.Text != "" && this.incrementStart.Text != "")
						{
							if (this.incrementStart.Text.IsNumeric() && this.incrementAdd.Text.IsNumeric())
							{
								this.incAdd = Convert.ToDouble(this.incrementAdd.Text);
								this.incCurrent = Convert.ToDouble(this.incrementStart.Text);
							}
							else
							{
								MessageBox.Show("You've put data into the increment fields, but they are not valid! Incrementing will not work correctly.", "Error: Invalid Input");
							}
						}
						if (this.messageBox.Text.Length <= 0)
						{
							MessageBox.Show("Enter something to type!", "Error: Invalid Input");
							this.reset();
							return;
						}
						this.PreTypeData();
						return;
					}
				}
				else if (num3 == this.stopKeyID)
				{
					this.reset();
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002074 File Offset: 0x00000274
		private void initForTimers()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002754 File Offset: 0x00000954
		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoopInp.Text = Settings.Default.timesToLoop.ToString();
			this.intervalInput.Text = Settings.Default.interval.ToString();
			this.RandomBox.Checked = Settings.Default.randomInterval;
			this.delayBox.Text = Settings.Default.lineDelay.ToString();
			this.RandDelayBox.Checked = Settings.Default.randomDelay;
			this.incrementStart.Text = Settings.Default.incrementStartingValue.ToString();
			this.incrementAdd.Text = Settings.Default.incrementValue.ToString();
			this.randomSentence.Checked = Settings.Default.randomEnabled;
			this.timedEnabled.Checked = Settings.Default.timedStartEnabled;
			this.timedStartDate.Text = Settings.Default.timedStartDate;
			this.timedStartTime.Text = Settings.Default.timedStartTime;
			this.timedStopEnabled.Checked = Settings.Default.timedStopEnabled;
			this.timedStopDate.Text = Settings.Default.timedStopDate;
			this.timedStopTime.Text = Settings.Default.timedStopTime;
			this.startHotkey.Text = Settings.Default.startHotkeyHashcode.ToString();
			this.stopHotkey.Text = Settings.Default.stopHotkeyHashcode.ToString();
			this.oneMsgBox.Checked = Settings.Default.sendAsOneMessageEnabled;
			this.waitFirstBox.Checked = Settings.Default.waitFirstEnabled;
			this.RandomMin.Text = Settings.Default.randomIntervalMin.ToString();
			this.RandomMax.Text = Settings.Default.randomIntervalMax.ToString();
			this.RandDelayMin.Text = Settings.Default.randomDelayMin.ToString();
			this.RandDelayMax.Text = Settings.Default.RandomDelayMax.ToString();
			this.timeDisplayLabel.Text = "";
			this.intervalTimer = new Form1.AccurateTimer(this, new Action(this.initForTimers), 10);
			this.delayTimer = new Form1.AccurateTimer(this, new Action(this.initForTimers), 10);
			this.intervalTimer.Stop();
			this.delayTimer.Stop();
			if (!this.RandomBox.Checked)
			{
				this.RandomMin.Hide();
				this.RandomMax.Hide();
			}
			else
			{
				this.intervalInput.Hide();
			}
			if (!this.RandDelayBox.Checked)
			{
				this.RandDelayMin.Hide();
				this.RandDelayMax.Hide();
			}
			else
			{
				this.delayBox.Hide();
			}
			Form1.RegisterHotKey(base.Handle, this.startKeyID, 0, Settings.Default.startHotkeyHashcode.GetHashCode());
			Form1.RegisterHotKey(base.Handle, this.stopKeyID, 0, Settings.Default.stopHotkeyHashcode.GetHashCode());
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\AutoTyper-Save.txt"))
			{
				return;
			}
			try
			{
				string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\AutoTyper-Save.txt");
				this.messageBox.Lines = lines;
			}
			catch
			{
				MessageBox.Show("Error loading from file, run program as admin or move the program to a directory it can access!", "Error: Invalid Permissions");
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002074 File Offset: 0x00000274
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002074 File Offset: 0x00000274
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002076 File Offset: 0x00000276
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002074 File Offset: 0x00000274
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002B04 File Offset: 0x00000D04
		private void timerStart_Click(object sender, EventArgs e)
		{
			if (!this.timerExists)
			{
				if (this.incrementAdd.Text != "" && this.incrementStart.Text != "")
				{
					if (this.incrementStart.Text.IsNumeric() && this.incrementAdd.Text.IsNumeric())
					{
						this.incAdd = Convert.ToDouble(this.incrementAdd.Text);
						this.incCurrent = Convert.ToDouble(this.incrementStart.Text);
					}
					else
					{
						MessageBox.Show("You've put data into the increment fields, but they are not valid! Incrementing will not work correctly.", "Error: Invalid Input");
					}
				}
				if (this.messageBox.Text.Length <= 0)
				{
					MessageBox.Show("Enter something to type!", "Error: Invalid Input");
					this.reset();
					return;
				}
				this.PreTypeData();
				base.WindowState = FormWindowState.Minimized;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002BE4 File Offset: 0x00000DE4
		private void PreTypeData()
		{
			this.resetSignal = false;
			bool flag = false;
			if (this.RandomBox.Checked)
			{
				if (this.RandomMin.Text.IsNumeric() && this.RandomMax.Text.IsNumeric())
				{
					double num = Convert.ToDouble(this.RandomMin.Text);
					double num2 = Convert.ToDouble(this.RandomMax.Text);
					if (num >= num2)
					{
						MessageBox.Show("The Minimum interval must be smaller than the Maximum interval!", "Error: Invalid Input");
						flag = true;
						this.reset();
					}
					else
					{
						this.r = new Random();
						this.intervalTarget = this.r.NextDouble() * (num2 - num) + num;
					}
				}
				else
				{
					MessageBox.Show("You need to enter numbers in the random interval input boxes!", "Error: Invalid Input");
					flag = true;
					this.reset();
				}
			}
			else if (this.intervalInput.Text.IsNumeric())
			{
				this.intervalTarget = Convert.ToDouble(this.intervalInput.Text);
			}
			else
			{
				MessageBox.Show("Enter a number in the interval input box!", "Error: Invalid Input");
				flag = true;
				this.reset();
			}
			if (this.LoopInp.Text.IsNumeric())
			{
				if (!flag)
				{
					this.loopsToDo = Convert.ToInt32(this.LoopInp.Text);
					if ((this.waitFirstBox.Checked && this.loopsDone == 0) || this.loopsDone >= 1)
					{
						this.intervalTimer = new Form1.AccurateTimer(this, new Action(this.IntervalOnTick), 10);
						this.timerExists = true;
						return;
					}
					this.DelayCheck();
					return;
				}
			}
			else
			{
				MessageBox.Show("Enter a number in the loop amount box!", "Error: Invalid Input");
				this.reset();
			}
		}

		// Token: 0x06000011 RID: 17
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000012 RID: 18
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000013 RID: 19 RVA: 0x0000207F File Offset: 0x0000027F
		private void FormMoveable_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002D7C File Offset: 0x00000F7C
		private void IntervalOnTick()
		{
			this.intervalCounter += 0.01;
			this.timeDisplayLabel.Text = "Typing in: " + (this.intervalTarget - this.intervalCounter).ToString("#,##0.00");
			if (this.intervalCounter >= this.intervalTarget)
			{
				this.intervalTimer.Stop();
				this.intervalCounter = 0.0;
				this.timeDisplayLabel.Text = "";
				this.DelayCheck();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020A7 File Offset: 0x000002A7
		private void resetTextColour()
		{
			this.messageBox.SelectAll();
			this.messageBox.SelectionColor = Color.White;
			this.messageBox.DeselectAll();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E0C File Offset: 0x0000100C
		private void DelayCheck()
		{
			bool flag = false;
			for (int i = 0; i < this.messageBox.Lines.Count<string>(); i++)
			{
				if (this.resetSignal)
				{
					i = this.messageBox.Lines.Count<string>();
					break;
				}
				this.messageBox.Select(this.messageBox.GetFirstCharIndexFromLine(i), this.messageBox.Lines[i].Length);
				this.messageBox.SelectionColor = Color.Red;
				bool isLastLine = false;
				if (i == this.messageBox.Lines.Count<string>() - 1)
				{
					isLastLine = true;
				}
				if (this.isActive && !this.resetSignal)
				{
					MessageBox.Show("Cancelled, tab out from the auto typer before it attempts to type!", "ERROR: TABBED IN");
					this.reset();
					flag = true;
					break;
				}
				string e;
				if (this.randomSentence.Checked)
				{
					this.r = new Random();
					int index = this.r.Next(0, this.messageBox.Lines.Length);
					e = this.messageBox.Lines.ElementAt(index);
				}
				else
				{
					e = this.messageBox.Lines.ElementAt(i);
				}
				if (i > 0)
				{
					if (this.RandDelayBox.Checked)
					{
						if (this.RandDelayMin.Text.IsNumeric() && this.RandDelayMax.Text.IsNumeric())
						{
							double num = Convert.ToDouble(this.RandDelayMin.Text);
							double num2 = Convert.ToDouble(this.RandDelayMax.Text);
							this.r = new Random();
							this.delayTarget = this.r.NextDouble() * (num2 - num) + num;
						}
						else
						{
							MessageBox.Show("You need to enter numbers in the random delay input boxes!", "Error: Invalid Input");
							this.reset();
						}
					}
					else if (this.delayBox.Text.IsNumeric())
					{
						this.delayTarget = Convert.ToDouble(this.delayBox.Text);
					}
					else
					{
						MessageBox.Show("Enter a number in the delay input box! Set to 0 if you want no delay!", "Error: Invalid Input");
						this.reset();
					}
					if (this.delayTarget <= 0.0)
					{
						this.SimulateKeys(e, isLastLine);
					}
					else
					{
						this.delayTimer = new Form1.AccurateTimer(this, new Action(this.delayOnTick), 10);
						while (!this.delayDone)
						{
							Application.DoEvents();
						}
						this.delayDone = false;
						this.SimulateKeys(e, isLastLine);
					}
				}
				else
				{
					this.SimulateKeys(e, isLastLine);
				}
				if (this.randomSentence.Checked)
				{
					break;
				}
				this.resetTextColour();
			}
			if (!flag)
			{
				int num3 = this.loopsToDo;
				int num4 = this.loopsDone;
				if (!this.resetSignal)
				{
					this.reset();
					this.resetSignal = false;
					this.loopsToDo = num3;
					this.loopsDone = num4;
					this.timeDisplayLabel.Text = "Typing finished.";
					this.loopsDone++;
					this.loopLabel.Text = this.loopsDone.ToString() + " / " + this.loopsToDo.ToString();
					if (!this.resetSignal && (this.loopsDone < this.loopsToDo || this.loopsToDo == 0))
					{
						if (!this.timerExists)
						{
							if (this.messageBox.Text.Length <= 0)
							{
								MessageBox.Show("Enter something to type!", "Error: Invalid Input");
								this.reset();
								return;
							}
							this.PreTypeData();
							return;
						}
					}
					else
					{
						this.loopsDone = 0;
						this.loopsToDo = 0;
					}
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003170 File Offset: 0x00001370
		private void delayOnTick()
		{
			this.delayCounter += 0.01;
			this.timeDisplayLabel.Text = "Line delay: " + (this.delayTarget - this.delayCounter).ToString("#,##0.00");
			if (this.delayCounter >= this.delayTarget)
			{
				this.delayTimer.Stop();
				this.delayCounter = 0.0;
				this.timeDisplayLabel.Text = "";
				this.delayDone = true;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003204 File Offset: 0x00001404
		private void SimulateKeys(string e, bool isLastLine)
		{
			if (this.isActive)
			{
				MessageBox.Show("Cancelled, tab out from the auto typer before it attempts to type!", "ERROR: TABBED IN");
				this.reset();
				return;
			}
			int num = 0;
			while (num < e.Length && !this.resetSignal)
			{
				string text = e.Substring(num, 1);
				if (e.Length >= num + 5 && e.Substring(num, 5).ToLower() == "[inc]")
				{
					text = this.incCurrent.ToString();
					this.incCurrent += this.incAdd;
					num += 4;
				}
				if (text == "{" || text == "}" || text == "+" || text == ")" || text == "(" || text == "^" || text == "%" || text == "~" || text == "[" || text == "]")
				{
					text = "{" + text + "}";
				}
				if (e.Length >= num + 4 && e.Substring(num, 4).ToLower() == "{f9}")
				{
					text = "{F9}";
					num += 3;
				}
				if (e.Length >= num + 4 && e.Substring(num, 4).ToLower() == "{f8}")
				{
					text = "{F8}";
					num += 3;
				}
				SendKeys.SendWait(text);
				num++;
			}
			if (this.oneMsgBox.Checked && !isLastLine)
			{
				SendKeys.SendWait("+{ENTER}");
				return;
			}
			SendKeys.SendWait("{ENTER}\n");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020CF File Offset: 0x000002CF
		private void Form1_Activated(object sender, EventArgs e)
		{
			this.isActive = true;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000033C0 File Offset: 0x000015C0
		private void reset()
		{
			this.resetTextColour();
			Console.WriteLine("reset signal sent");
			this.resetSignal = true;
			this.timerExists = false;
			this.intervalTimer.Stop();
			this.delayTimer.Stop();
			this.intervalCounter = 0.0;
			this.delayCounter = 0.0;
			this.loopsDone = 0;
			this.loopsToDo = 0;
			this.timeDisplayLabel.Text = "";
			this.loopLabel.Text = "0 / 0";
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020D8 File Offset: 0x000002D8
		private void Form1_Deactivate_1(object sender, EventArgs e)
		{
			this.isActive = false;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002074 File Offset: 0x00000274
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003450 File Offset: 0x00001650
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.timesToLoop = int.Parse(this.LoopInp.Text);
			Settings.Default.interval = double.Parse(this.intervalInput.Text);
			Settings.Default.randomInterval = this.RandomBox.Checked;
			Settings.Default.lineDelay = double.Parse(this.delayBox.Text);
			Settings.Default.randomDelay = this.RandDelayBox.Checked;
			Settings.Default.incrementStartingValue = double.Parse(this.incrementStart.Text);
			Settings.Default.incrementValue = double.Parse(this.incrementAdd.Text);
			Settings.Default.randomEnabled = this.randomSentence.Checked;
			Settings.Default.timedStartEnabled = this.timedEnabled.Checked;
			Settings.Default.timedStartDate = this.timedStartDate.Text;
			Settings.Default.timedStartTime = this.timedStartTime.Text;
			Settings.Default.timedStopEnabled = this.timedStopEnabled.Checked;
			Settings.Default.timedStopDate = this.timedStopDate.Text;
			Settings.Default.timedStopTime = this.timedStopTime.Text;
			Settings.Default.sendAsOneMessageEnabled = this.oneMsgBox.Checked;
			Settings.Default.waitFirstEnabled = this.waitFirstBox.Checked;
			Settings.Default.randomIntervalMin = double.Parse(this.RandomMin.Text);
			Settings.Default.randomIntervalMax = double.Parse(this.RandomMax.Text);
			Settings.Default.randomDelayMin = double.Parse(this.RandDelayMin.Text);
			Settings.Default.RandomDelayMax = double.Parse(this.RandDelayMax.Text);
			Settings.Default.Save();
			this.reset();
			this.timerExists = false;
			Form1.UnregisterHotKey(base.Handle, this.startKeyID);
			Form1.UnregisterHotKey(base.Handle, this.stopKeyID);
			string[] lines = this.messageBox.Lines;
			try
			{
				File.WriteAllLines(Directory.GetCurrentDirectory() + "\\AutoTyper-Save.txt", lines);
			}
			catch
			{
				MessageBox.Show("Error saving to file, run program as admin or move the program to a directory it can access!", "Error: Invalid Permissions");
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020E1 File Offset: 0x000002E1
		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.reset();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020E9 File Offset: 0x000002E9
		private void helpButton_Click(object sender, EventArgs e)
		{
			new helpForm().Show();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020F5 File Offset: 0x000002F5
		private void startHotkey_Click(object sender, EventArgs e)
		{
			Console.WriteLine("startHotKey");
			this.choosingStopKey = false;
			this.choosingStartKey = true;
			this.startHotkey.ForeColor = SystemColors.Control;
			this.stopHotkey.ForeColor = SystemColors.ControlText;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000036B0 File Offset: 0x000018B0
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Console.WriteLine("Pressed: ");
			Keys stopHotkeyHashcode;
			if (this.choosingStartKey)
			{
				Console.WriteLine("choosingstart yes");
				Keys startHotkeyHashcode;
				if (Enum.TryParse<Keys>(e.KeyCode.ToString(), out startHotkeyHashcode))
				{
					Console.WriteLine("585");
					Form1.UnregisterHotKey(base.Handle, this.startKeyID);
					Form1.RegisterHotKey(base.Handle, this.startKeyID, 0, startHotkeyHashcode.GetHashCode());
					this.choosingStartKey = false;
					this.startHotkey.Text = e.KeyCode.ToString();
					this.startHotkey.ForeColor = SystemColors.ControlText;
					Settings.Default.startHotkeyHashcode = startHotkeyHashcode;
					Settings.Default.Save();
					return;
				}
			}
			else if (this.choosingStopKey && Enum.TryParse<Keys>(e.KeyCode.ToString(), out stopHotkeyHashcode))
			{
				Form1.UnregisterHotKey(base.Handle, this.stopKeyID);
				Form1.RegisterHotKey(base.Handle, this.stopKeyID, 0, stopHotkeyHashcode.GetHashCode());
				this.choosingStopKey = false;
				this.stopHotkey.Text = e.KeyCode.ToString();
				this.stopHotkey.ForeColor = SystemColors.ControlText;
				Settings.Default.stopHotkeyHashcode = stopHotkeyHashcode;
				Settings.Default.Save();
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000212F File Offset: 0x0000032F
		private void stopHotkey_Click(object sender, EventArgs e)
		{
			this.choosingStopKey = true;
			this.choosingStartKey = false;
			this.stopHotkey.ForeColor = SystemColors.Control;
			this.startHotkey.ForeColor = SystemColors.ControlText;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002074 File Offset: 0x00000274
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002074 File Offset: 0x00000274
		private void RandomBox_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002074 File Offset: 0x00000274
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000215F File Offset: 0x0000035F
		private void timedEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.timedEnabled.Checked)
			{
				this.timedStartTimer.Enabled = true;
				return;
			}
			if (!this.timedStopEnabled.Checked)
			{
				this.timedStartTimer.Enabled = false;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000382C File Offset: 0x00001A2C
		private void timedStartTimer_Tick(object sender, EventArgs e)
		{
			string a = string.Format("{0:HH:mm:ss}", DateTime.Now);
			string text = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
			if (text.ToString() == this.timedStartDate.Text && a == this.timedStartTime.Text)
			{
				this.PreTypeData();
			}
			if (text.ToString() == this.timedStopDate.Text && a == this.timedStopTime.Text)
			{
				this.reset();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002194 File Offset: 0x00000394
		private void timedStopEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (this.timedStopEnabled.Checked)
			{
				this.timedStartTimer.Enabled = true;
				return;
			}
			if (!this.timedEnabled.Checked)
			{
				this.timedStartTimer.Enabled = false;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000038C8 File Offset: 0x00001AC8
		private void RandomBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RandomBox.Checked)
			{
				this.RandomMin.Show();
				this.RandomMax.Show();
				this.intervalInput.Hide();
				return;
			}
			this.RandomMin.Hide();
			this.RandomMax.Hide();
			this.intervalInput.Show();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003928 File Offset: 0x00001B28
		private void RandDelayBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RandDelayBox.Checked)
			{
				this.RandDelayMin.Show();
				this.RandDelayMax.Show();
				this.delayBox.Hide();
				return;
			}
			this.RandDelayMin.Hide();
			this.RandDelayMax.Hide();
			this.delayBox.Show();
		}

		// Token: 0x04000001 RID: 1
		private int loopsDone;

		// Token: 0x04000002 RID: 2
		private int loopsToDo = 1;

		// Token: 0x04000003 RID: 3
		private bool delayDone;

		// Token: 0x04000004 RID: 4
		private bool isActive;

		// Token: 0x04000005 RID: 5
		private Random r;

		// Token: 0x04000006 RID: 6
		private Form1.AccurateTimer intervalTimer;

		// Token: 0x04000007 RID: 7
		private Form1.AccurateTimer delayTimer;

		// Token: 0x04000008 RID: 8
		private bool timerExists;

		// Token: 0x04000009 RID: 9
		private double intervalCounter;

		// Token: 0x0400000A RID: 10
		private double delayCounter;

		// Token: 0x0400000B RID: 11
		private double intervalTarget;

		// Token: 0x0400000C RID: 12
		private double delayTarget;

		// Token: 0x0400000D RID: 13
		private double incAdd;

		// Token: 0x0400000E RID: 14
		private double incCurrent;

		// Token: 0x0400000F RID: 15
		private bool choosingStartKey;

		// Token: 0x04000010 RID: 16
		private bool choosingStopKey;

		// Token: 0x04000011 RID: 17
		private int startKeyID;

		// Token: 0x04000012 RID: 18
		private int stopKeyID = 1;

		// Token: 0x04000013 RID: 19
		private bool resetSignal;

		// Token: 0x04000014 RID: 20
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000015 RID: 21
		public const int HT_CAPTION = 2;

		// Token: 0x02000003 RID: 3
		private enum KeyModifier
		{
			// Token: 0x04000053 RID: 83
			None,
			// Token: 0x04000054 RID: 84
			Alt,
			// Token: 0x04000055 RID: 85
			Control,
			// Token: 0x04000056 RID: 86
			Shift = 4,
			// Token: 0x04000057 RID: 87
			WinKey = 8
		}

		// Token: 0x02000004 RID: 4
		private class AccurateTimer
		{
			// Token: 0x0600002D RID: 45
			[DllImport("winmm.dll")]
			private static extern int timeBeginPeriod(int msec);

			// Token: 0x0600002E RID: 46
			[DllImport("winmm.dll")]
			private static extern int timeEndPeriod(int msec);

			// Token: 0x0600002F RID: 47
			[DllImport("winmm.dll")]
			private static extern int timeSetEvent(int delay, int resolution, Form1.AccurateTimer.TimerEventDel handler, IntPtr user, int eventType);

			// Token: 0x06000030 RID: 48
			[DllImport("winmm.dll")]
			private static extern int timeKillEvent(int id);

			// Token: 0x06000031 RID: 49 RVA: 0x00006C58 File Offset: 0x00004E58
			public AccurateTimer(Form form, Action action, int delay)
			{
				this.mAction = action;
				this.mForm = form;
				Form1.AccurateTimer.timeBeginPeriod(1);
				this.mHandler = new Form1.AccurateTimer.TimerEventDel(this.TimerCallback);
				this.mTimerId = Form1.AccurateTimer.timeSetEvent(delay, 0, this.mHandler, IntPtr.Zero, 1);
			}

			// Token: 0x06000032 RID: 50 RVA: 0x000021E8 File Offset: 0x000003E8
			public void Stop()
			{
				Form1.AccurateTimer.timeKillEvent(this.mTimerId);
				Form1.AccurateTimer.timeEndPeriod(1);
				Thread.Sleep(100);
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002204 File Offset: 0x00000404
			private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
			{
				if (this.mTimerId != 0)
				{
					this.mForm.BeginInvoke(this.mAction);
				}
			}

			// Token: 0x04000058 RID: 88
			private const int TIME_PERIODIC = 1;

			// Token: 0x04000059 RID: 89
			private const int EVENT_TYPE = 1;

			// Token: 0x0400005A RID: 90
			private Action mAction;

			// Token: 0x0400005B RID: 91
			private Form mForm;

			// Token: 0x0400005C RID: 92
			private int mTimerId;

			// Token: 0x0400005D RID: 93
			private Form1.AccurateTimer.TimerEventDel mHandler;

			// Token: 0x02000005 RID: 5
			// (Invoke) Token: 0x06000035 RID: 53
			private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
		}
	}
}
