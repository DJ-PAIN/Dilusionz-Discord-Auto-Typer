namespace Dilusionz_Discord_Auto_Typer
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000021C9 File Offset: 0x000003C9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
// Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group // Archived by Vista Group 
		// Token: 0x0600002C RID: 44 RVA: 0x00003988 File Offset: 0x00001B88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Dilusionz_Discord_Auto_Typer.Form1));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.oneMsgBox = new global::System.Windows.Forms.CheckBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.LoopInp = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.intervalInput = new global::System.Windows.Forms.TextBox();
			this.RandomBox = new global::System.Windows.Forms.CheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.delayBox = new global::System.Windows.Forms.TextBox();
			this.RandDelayBox = new global::System.Windows.Forms.CheckBox();
			this.messageBox = new global::System.Windows.Forms.RichTextBox();
			this.timerStart = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.timeDisplayLabel = new global::System.Windows.Forms.Label();
			this.RandDelayMin = new global::System.Windows.Forms.TextBox();
			this.RandDelayMax = new global::System.Windows.Forms.TextBox();
			this.RandomMin = new global::System.Windows.Forms.TextBox();
			this.RandomMax = new global::System.Windows.Forms.TextBox();
			this.helpButton = new global::System.Windows.Forms.Button();
			this.label13 = new global::System.Windows.Forms.Label();
			this.incrementStart = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.incrementAdd = new global::System.Windows.Forms.TextBox();
			this.startHotkey = new global::System.Windows.Forms.Button();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.stopHotkey = new global::System.Windows.Forms.Button();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.loopLabel = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.label12 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.timedStartTime = new global::System.Windows.Forms.TextBox();
			this.timedEnabled = new global::System.Windows.Forms.CheckBox();
			this.timedStartTimer = new global::System.Windows.Forms.Timer(this.components);
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.timedStopTime = new global::System.Windows.Forms.TextBox();
			this.timedStopEnabled = new global::System.Windows.Forms.CheckBox();
			this.timedStartDate = new global::System.Windows.Forms.TextBox();
			this.timedStopDate = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.randomSentence = new global::System.Windows.Forms.CheckBox();
			this.waitFirstBox = new global::System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new global::System.Drawing.Point(-2, -1);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(583, 21);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMoveable_MouseDown);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Tai Le", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new global::System.Drawing.Point(2, 4);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(124, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "Auto Typer For Discord";
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.FromArgb(153, 170, 181);
			this.button2.Location = new global::System.Drawing.Point(548, 0);
			this.button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.button2.Size = new global::System.Drawing.Size(16, 20);
			this.button2.TabIndex = 2;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Firebrick;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(153, 170, 181);
			this.button1.Location = new global::System.Drawing.Point(564, 0);
			this.button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(17, 19);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.oneMsgBox.AutoSize = true;
			this.oneMsgBox.BackColor = global::System.Drawing.Color.Transparent;
			this.oneMsgBox.FlatAppearance.BorderSize = 0;
			this.oneMsgBox.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.oneMsgBox.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.oneMsgBox.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.oneMsgBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.oneMsgBox.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.oneMsgBox.Location = new global::System.Drawing.Point(9, 353);
			this.oneMsgBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.oneMsgBox.Name = "oneMsgBox";
			this.oneMsgBox.Size = new global::System.Drawing.Size(128, 17);
			this.oneMsgBox.TabIndex = 3;
			this.oneMsgBox.Text = "Send as one message";
			this.oneMsgBox.UseVisualStyleBackColor = false;
			this.panel4.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new global::System.Drawing.Point(9, 329);
			this.panel4.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(223, 20);
			this.panel4.TabIndex = 6;
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Tai Le", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new global::System.Drawing.Point(120, 3);
			this.label9.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(101, 14);
			this.label9.TabIndex = 4;
			this.label9.Text = "Archived by Vista.";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(8, 2);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(45, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Settings";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new global::System.Drawing.Point(263, 25);
			this.panel2.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(295, 31);
			this.panel2.TabIndex = 7;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(88, 9);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(132, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "C O N F I G U R A T I O N";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new global::System.Drawing.Point(268, 74);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(63, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Looping";
			this.toolTip1.SetToolTip(this.label4, "How many times you want the program to repeat the typing process");
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new global::System.Drawing.Point(264, 92);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(70, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Times to loop";
			this.LoopInp.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.LoopInp.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.LoopInp.ForeColor = global::System.Drawing.Color.White;
			this.LoopInp.Location = new global::System.Drawing.Point(265, 109);
			this.LoopInp.Margin = new global::System.Windows.Forms.Padding(2);
			this.LoopInp.Name = "LoopInp";
			this.LoopInp.Size = new global::System.Drawing.Size(68, 13);
			this.LoopInp.TabIndex = 8;
			this.LoopInp.Text = "1";
			this.LoopInp.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label6.Location = new global::System.Drawing.Point(271, 124);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(55, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "0 = infinite";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new global::System.Drawing.Point(269, 137);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(59, 18);
			this.label7.TabIndex = 10;
			this.label7.Text = "Interval";
			this.toolTip1.SetToolTip(this.label7, "How long the program waits before typing");
			this.intervalInput.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.intervalInput.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.intervalInput.ForeColor = global::System.Drawing.Color.White;
			this.intervalInput.Location = new global::System.Drawing.Point(263, 163);
			this.intervalInput.Margin = new global::System.Windows.Forms.Padding(2);
			this.intervalInput.Name = "intervalInput";
			this.intervalInput.Size = new global::System.Drawing.Size(68, 13);
			this.intervalInput.TabIndex = 11;
			this.intervalInput.Text = "0";
			this.RandomBox.AutoSize = true;
			this.RandomBox.BackColor = global::System.Drawing.Color.Transparent;
			this.RandomBox.FlatAppearance.BorderSize = 0;
			this.RandomBox.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.RandomBox.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.RandomBox.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.RandomBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RandomBox.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.RandomBox.Location = new global::System.Drawing.Point(248, 180);
			this.RandomBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandomBox.Name = "RandomBox";
			this.RandomBox.Size = new global::System.Drawing.Size(106, 17);
			this.RandomBox.TabIndex = 12;
			this.RandomBox.Text = "Random interval?";
			this.RandomBox.UseVisualStyleBackColor = false;
			this.RandomBox.CheckedChanged += new global::System.EventHandler(this.RandomBox_CheckedChanged);
			this.RandomBox.Paint += new global::System.Windows.Forms.PaintEventHandler(this.RandomBox_Paint);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new global::System.Drawing.Point(261, 196);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(77, 18);
			this.label8.TabIndex = 13;
			this.label8.Text = "Line Delay";
			this.toolTip1.SetToolTip(this.label8, "How long the program waits inbetween typing each line");
			this.delayBox.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.delayBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.delayBox.ForeColor = global::System.Drawing.Color.White;
			this.delayBox.Location = new global::System.Drawing.Point(263, 219);
			this.delayBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.delayBox.Name = "delayBox";
			this.delayBox.Size = new global::System.Drawing.Size(68, 13);
			this.delayBox.TabIndex = 14;
			this.delayBox.Text = "0";
			this.RandDelayBox.AutoSize = true;
			this.RandDelayBox.BackColor = global::System.Drawing.Color.Transparent;
			this.RandDelayBox.FlatAppearance.BorderSize = 0;
			this.RandDelayBox.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.RandDelayBox.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.RandDelayBox.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.RandDelayBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RandDelayBox.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.RandDelayBox.Location = new global::System.Drawing.Point(250, 236);
			this.RandDelayBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandDelayBox.Name = "RandDelayBox";
			this.RandDelayBox.Size = new global::System.Drawing.Size(99, 17);
			this.RandDelayBox.TabIndex = 15;
			this.RandDelayBox.Text = "Random Delay?";
			this.RandDelayBox.UseVisualStyleBackColor = false;
			this.RandDelayBox.CheckedChanged += new global::System.EventHandler(this.RandDelayBox_CheckedChanged);
			this.messageBox.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.messageBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.messageBox.ForeColor = global::System.Drawing.SystemColors.Info;
			this.messageBox.Location = new global::System.Drawing.Point(9, 59);
			this.messageBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.messageBox.Name = "messageBox";
			this.messageBox.Size = new global::System.Drawing.Size(223, 200);
			this.messageBox.TabIndex = 16;
			this.messageBox.Text = "";
			this.timerStart.BackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.timerStart.FlatAppearance.BorderSize = 0;
			this.timerStart.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(134, 137, 212);
			this.timerStart.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.timerStart.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.timerStart.Location = new global::System.Drawing.Point(9, 25);
			this.timerStart.Margin = new global::System.Windows.Forms.Padding(2);
			this.timerStart.Name = "timerStart";
			this.timerStart.Size = new global::System.Drawing.Size(56, 29);
			this.timerStart.TabIndex = 17;
			this.timerStart.Text = "Start";
			this.timerStart.UseVisualStyleBackColor = false;
			this.timerStart.Click += new global::System.EventHandler(this.timerStart_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(134, 137, 212);
			this.button4.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new global::System.Drawing.Point(70, 25);
			this.button4.Margin = new global::System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(56, 29);
			this.button4.TabIndex = 18;
			this.button4.Text = "Stop";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.cancelButton_Click);
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel3.Controls.Add(this.timeDisplayLabel);
			this.panel3.Location = new global::System.Drawing.Point(137, 25);
			this.panel3.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(95, 29);
			this.panel3.TabIndex = 7;
			this.timeDisplayLabel.AutoSize = true;
			this.timeDisplayLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.timeDisplayLabel.ForeColor = global::System.Drawing.Color.White;
			this.timeDisplayLabel.Location = new global::System.Drawing.Point(2, 8);
			this.timeDisplayLabel.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.timeDisplayLabel.Name = "timeDisplayLabel";
			this.timeDisplayLabel.Size = new global::System.Drawing.Size(53, 13);
			this.timeDisplayLabel.TabIndex = 0;
			this.timeDisplayLabel.Text = "Typing in:";
			this.RandDelayMin.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.RandDelayMin.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RandDelayMin.ForeColor = global::System.Drawing.Color.White;
			this.RandDelayMin.Location = new global::System.Drawing.Point(263, 219);
			this.RandDelayMin.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandDelayMin.Name = "RandDelayMin";
			this.RandDelayMin.Size = new global::System.Drawing.Size(21, 13);
			this.RandDelayMin.TabIndex = 19;
			this.RandDelayMin.Text = "0";
			this.RandDelayMax.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.RandDelayMax.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RandDelayMax.ForeColor = global::System.Drawing.Color.White;
			this.RandDelayMax.Location = new global::System.Drawing.Point(310, 219);
			this.RandDelayMax.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandDelayMax.Name = "RandDelayMax";
			this.RandDelayMax.Size = new global::System.Drawing.Size(21, 13);
			this.RandDelayMax.TabIndex = 19;
			this.RandDelayMax.Text = "0";
			this.RandomMin.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.RandomMin.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RandomMin.ForeColor = global::System.Drawing.Color.White;
			this.RandomMin.Location = new global::System.Drawing.Point(263, 163);
			this.RandomMin.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandomMin.Name = "RandomMin";
			this.RandomMin.Size = new global::System.Drawing.Size(21, 13);
			this.RandomMin.TabIndex = 19;
			this.RandomMin.Text = "0";
			this.RandomMax.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.RandomMax.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RandomMax.ForeColor = global::System.Drawing.Color.White;
			this.RandomMax.Location = new global::System.Drawing.Point(310, 163);
			this.RandomMax.Margin = new global::System.Windows.Forms.Padding(2);
			this.RandomMax.Name = "RandomMax";
			this.RandomMax.Size = new global::System.Drawing.Size(21, 13);
			this.RandomMax.TabIndex = 19;
			this.RandomMax.Text = "0";
			this.helpButton.BackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.helpButton.FlatAppearance.BorderSize = 0;
			this.helpButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(134, 137, 212);
			this.helpButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.helpButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.helpButton.Location = new global::System.Drawing.Point(263, 264);
			this.helpButton.Margin = new global::System.Windows.Forms.Padding(2);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new global::System.Drawing.Size(79, 29);
			this.helpButton.TabIndex = 17;
			this.helpButton.Text = "Help and Info";
			this.helpButton.UseVisualStyleBackColor = false;
			this.helpButton.Click += new global::System.EventHandler(this.helpButton_Click);
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.label13.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label13.Location = new global::System.Drawing.Point(363, 74);
			this.label13.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(75, 18);
			this.label13.TabIndex = 4;
			this.label13.Text = "Increment";
			this.toolTip1.SetToolTip(this.label13, "Leave blank if you're unaware of how to use it");
			this.incrementStart.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.incrementStart.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.incrementStart.ForeColor = global::System.Drawing.Color.White;
			this.incrementStart.Location = new global::System.Drawing.Point(366, 112);
			this.incrementStart.Margin = new global::System.Windows.Forms.Padding(2);
			this.incrementStart.Name = "incrementStart";
			this.incrementStart.Size = new global::System.Drawing.Size(68, 13);
			this.incrementStart.TabIndex = 8;
			this.label14.AutoSize = true;
			this.label14.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label14.Location = new global::System.Drawing.Point(363, 97);
			this.label14.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(73, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Starting Value";
			this.label15.AutoSize = true;
			this.label15.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label15.Location = new global::System.Drawing.Point(372, 127);
			this.label15.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(54, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "Increment";
			this.incrementAdd.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.incrementAdd.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.incrementAdd.ForeColor = global::System.Drawing.Color.White;
			this.incrementAdd.Location = new global::System.Drawing.Point(366, 142);
			this.incrementAdd.Margin = new global::System.Windows.Forms.Padding(2);
			this.incrementAdd.Name = "incrementAdd";
			this.incrementAdd.Size = new global::System.Drawing.Size(68, 13);
			this.incrementAdd.TabIndex = 8;
			this.startHotkey.BackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.startHotkey.FlatAppearance.BorderSize = 0;
			this.startHotkey.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(134, 137, 212);
			this.startHotkey.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.startHotkey.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.startHotkey.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.startHotkey.Location = new global::System.Drawing.Point(283, 318);
			this.startHotkey.Margin = new global::System.Windows.Forms.Padding(2);
			this.startHotkey.Name = "startHotkey";
			this.startHotkey.Size = new global::System.Drawing.Size(34, 20);
			this.startHotkey.TabIndex = 18;
			this.startHotkey.Text = "F8";
			this.startHotkey.UseVisualStyleBackColor = false;
			this.startHotkey.Click += new global::System.EventHandler(this.startHotkey_Click);
			this.startHotkey.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.label10.AutoSize = true;
			this.label10.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new global::System.Drawing.Point(269, 300);
			this.label10.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(66, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Start Hotkey";
			this.label11.AutoSize = true;
			this.label11.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new global::System.Drawing.Point(361, 300);
			this.label11.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(66, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Stop Hotkey";
			this.stopHotkey.BackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.stopHotkey.FlatAppearance.BorderSize = 0;
			this.stopHotkey.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(134, 137, 212);
			this.stopHotkey.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.stopHotkey.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.stopHotkey.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.stopHotkey.Location = new global::System.Drawing.Point(376, 318);
			this.stopHotkey.Margin = new global::System.Windows.Forms.Padding(2);
			this.stopHotkey.Name = "stopHotkey";
			this.stopHotkey.Size = new global::System.Drawing.Size(34, 20);
			this.stopHotkey.TabIndex = 18;
			this.stopHotkey.Text = "F9";
			this.stopHotkey.UseVisualStyleBackColor = false;
			this.stopHotkey.Click += new global::System.EventHandler(this.stopHotkey_Click);
			this.stopHotkey.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel5.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.panel5.Controls.Add(this.loopLabel);
			this.panel5.Controls.Add(this.label16);
			this.panel5.Location = new global::System.Drawing.Point(9, 264);
			this.panel5.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(95, 29);
			this.panel5.TabIndex = 8;
			this.loopLabel.AutoSize = true;
			this.loopLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.loopLabel.ForeColor = global::System.Drawing.Color.White;
			this.loopLabel.Location = new global::System.Drawing.Point(31, 9);
			this.loopLabel.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.loopLabel.Name = "loopLabel";
			this.loopLabel.Size = new global::System.Drawing.Size(30, 13);
			this.loopLabel.TabIndex = 1;
			this.loopLabel.Text = "0 / 0";
			this.loopLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label16.AutoSize = true;
			this.label16.BackColor = global::System.Drawing.Color.Transparent;
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(2, 8);
			this.label16.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(37, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Loop: ";
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.label12.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label12.Location = new global::System.Drawing.Point(462, 74);
			this.label12.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(86, 18);
			this.label12.TabIndex = 4;
			this.label12.Text = "Timed Start";
			this.label12.Click += new global::System.EventHandler(this.label12_Click);
			this.label18.AutoSize = true;
			this.label18.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label18.Location = new global::System.Drawing.Point(455, 147);
			this.label18.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(93, 13);
			this.label18.TabIndex = 4;
			this.label18.Text = "Time (HH:MM:SS)";
			this.timedStartTime.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.timedStartTime.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.timedStartTime.ForeColor = global::System.Drawing.Color.White;
			this.timedStartTime.Location = new global::System.Drawing.Point(468, 166);
			this.timedStartTime.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedStartTime.Name = "timedStartTime";
			this.timedStartTime.Size = new global::System.Drawing.Size(68, 13);
			this.timedStartTime.TabIndex = 8;
			this.timedStartTime.Text = "00:00:00";
			this.timedStartTime.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.timedEnabled.AutoSize = true;
			this.timedEnabled.BackColor = global::System.Drawing.Color.Transparent;
			this.timedEnabled.FlatAppearance.BorderSize = 0;
			this.timedEnabled.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.timedEnabled.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.timedEnabled.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.timedEnabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.timedEnabled.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.timedEnabled.Location = new global::System.Drawing.Point(470, 94);
			this.timedEnabled.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedEnabled.Name = "timedEnabled";
			this.timedEnabled.Size = new global::System.Drawing.Size(62, 17);
			this.timedEnabled.TabIndex = 12;
			this.timedEnabled.Text = "Enabled";
			this.timedEnabled.UseVisualStyleBackColor = false;
			this.timedEnabled.CheckedChanged += new global::System.EventHandler(this.timedEnabled_CheckedChanged);
			this.timedEnabled.Paint += new global::System.Windows.Forms.PaintEventHandler(this.RandomBox_Paint);
			this.timedStartTimer.Enabled = true;
			this.timedStartTimer.Interval = 1000;
			this.timedStartTimer.Tick += new global::System.EventHandler(this.timedStartTimer_Tick);
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label19.Location = new global::System.Drawing.Point(462, 196);
			this.label19.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(85, 18);
			this.label19.TabIndex = 4;
			this.label19.Text = "Timed Stop";
			this.label19.Click += new global::System.EventHandler(this.label12_Click);
			this.label20.AutoSize = true;
			this.label20.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label20.Location = new global::System.Drawing.Point(447, 232);
			this.label20.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(111, 13);
			this.label20.TabIndex = 4;
			this.label20.Text = "Date (DD/MM/YYYY)";
			this.label21.AutoSize = true;
			this.label21.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label21.Location = new global::System.Drawing.Point(455, 267);
			this.label21.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(93, 13);
			this.label21.TabIndex = 4;
			this.label21.Text = "Time (HH:MM:SS)";
			this.timedStopTime.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.timedStopTime.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.timedStopTime.ForeColor = global::System.Drawing.Color.White;
			this.timedStopTime.Location = new global::System.Drawing.Point(468, 286);
			this.timedStopTime.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedStopTime.Name = "timedStopTime";
			this.timedStopTime.Size = new global::System.Drawing.Size(68, 13);
			this.timedStopTime.TabIndex = 8;
			this.timedStopTime.Text = "00:00:00";
			this.timedStopTime.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.timedStopEnabled.AutoSize = true;
			this.timedStopEnabled.BackColor = global::System.Drawing.Color.Transparent;
			this.timedStopEnabled.FlatAppearance.BorderSize = 0;
			this.timedStopEnabled.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.timedStopEnabled.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.timedStopEnabled.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.timedStopEnabled.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.timedStopEnabled.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.timedStopEnabled.Location = new global::System.Drawing.Point(470, 216);
			this.timedStopEnabled.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedStopEnabled.Name = "timedStopEnabled";
			this.timedStopEnabled.Size = new global::System.Drawing.Size(62, 17);
			this.timedStopEnabled.TabIndex = 12;
			this.timedStopEnabled.Text = "Enabled";
			this.timedStopEnabled.UseVisualStyleBackColor = false;
			this.timedStopEnabled.CheckedChanged += new global::System.EventHandler(this.timedStopEnabled_CheckedChanged);
			this.timedStopEnabled.Paint += new global::System.Windows.Forms.PaintEventHandler(this.RandomBox_Paint);
			this.timedStartDate.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.timedStartDate.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.timedStartDate.ForeColor = global::System.Drawing.Color.White;
			this.timedStartDate.Location = new global::System.Drawing.Point(468, 127);
			this.timedStartDate.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedStartDate.Name = "timedStartDate";
			this.timedStartDate.Size = new global::System.Drawing.Size(68, 13);
			this.timedStartDate.TabIndex = 8;
			this.timedStartDate.Text = "24/01/2021";
			this.timedStartDate.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.timedStopDate.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.timedStopDate.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.timedStopDate.ForeColor = global::System.Drawing.Color.White;
			this.timedStopDate.Location = new global::System.Drawing.Point(468, 247);
			this.timedStopDate.Margin = new global::System.Windows.Forms.Padding(2);
			this.timedStopDate.Name = "timedStopDate";
			this.timedStopDate.Size = new global::System.Drawing.Size(68, 13);
			this.timedStopDate.TabIndex = 8;
			this.timedStopDate.Text = "25/01/2021";
			this.timedStopDate.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label17.AutoSize = true;
			this.label17.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label17.Location = new global::System.Drawing.Point(447, 112);
			this.label17.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(111, 13);
			this.label17.TabIndex = 4;
			this.label17.Text = "Date (DD/MM/YYYY)";
			this.label22.AutoSize = true;
			this.label22.BackColor = global::System.Drawing.Color.Transparent;
			this.label22.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 10.2f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label22.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label22.Location = new global::System.Drawing.Point(370, 161);
			this.label22.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(64, 18);
			this.label22.TabIndex = 4;
			this.label22.Text = "Random";
			this.randomSentence.AutoSize = true;
			this.randomSentence.BackColor = global::System.Drawing.Color.Transparent;
			this.randomSentence.FlatAppearance.BorderSize = 0;
			this.randomSentence.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.randomSentence.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.randomSentence.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.randomSentence.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.randomSentence.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.randomSentence.Location = new global::System.Drawing.Point(372, 180);
			this.randomSentence.Margin = new global::System.Windows.Forms.Padding(2);
			this.randomSentence.Name = "randomSentence";
			this.randomSentence.Size = new global::System.Drawing.Size(62, 17);
			this.randomSentence.TabIndex = 15;
			this.randomSentence.Text = "Enabled";
			this.randomSentence.UseVisualStyleBackColor = false;
			this.randomSentence.CheckedChanged += new global::System.EventHandler(this.RandDelayBox_CheckedChanged);
			this.waitFirstBox.AutoSize = true;
			this.waitFirstBox.BackColor = global::System.Drawing.Color.Transparent;
			this.waitFirstBox.FlatAppearance.BorderSize = 0;
			this.waitFirstBox.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Green;
			this.waitFirstBox.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.waitFirstBox.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Blue;
			this.waitFirstBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.waitFirstBox.ForeColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.waitFirstBox.Location = new global::System.Drawing.Point(168, 353);
			this.waitFirstBox.Margin = new global::System.Windows.Forms.Padding(2);
			this.waitFirstBox.Name = "waitFirstBox";
			this.waitFirstBox.Size = new global::System.Drawing.Size(64, 17);
			this.waitFirstBox.TabIndex = 15;
			this.waitFirstBox.Text = "Wait first";
			this.toolTip1.SetToolTip(this.waitFirstBox, "Should the auto typer wait before typing the first line?");
			this.waitFirstBox.UseVisualStyleBackColor = false;
			this.waitFirstBox.CheckedChanged += new global::System.EventHandler(this.RandDelayBox_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(580, 380);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.RandDelayMax);
			base.Controls.Add(this.RandomMax);
			base.Controls.Add(this.RandomMin);
			base.Controls.Add(this.RandDelayMin);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.stopHotkey);
			base.Controls.Add(this.startHotkey);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.helpButton);
			base.Controls.Add(this.timerStart);
			base.Controls.Add(this.messageBox);
			base.Controls.Add(this.randomSentence);
			base.Controls.Add(this.waitFirstBox);
			base.Controls.Add(this.RandDelayBox);
			base.Controls.Add(this.delayBox);
			base.Controls.Add(this.timedStopEnabled);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.timedEnabled);
			base.Controls.Add(this.RandomBox);
			base.Controls.Add(this.intervalInput);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.incrementAdd);
			base.Controls.Add(this.timedStopTime);
			base.Controls.Add(this.incrementStart);
			base.Controls.Add(this.timedStopDate);
			base.Controls.Add(this.timedStartDate);
			base.Controls.Add(this.timedStartTime);
			base.Controls.Add(this.LoopInp);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.oneMsgBox);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form1";
			this.Text = "Auto Typer For Discord";
			base.Activated += new global::System.EventHandler(this.Form1_Activated);
			base.Deactivate += new global::System.EventHandler(this.Form1_Deactivate_1);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.CheckBox oneMsgBox;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TextBox LoopInp;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TextBox intervalInput;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.CheckBox RandomBox;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TextBox delayBox;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.CheckBox RandDelayBox;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.RichTextBox messageBox;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button timerStart;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label timeDisplayLabel;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.TextBox RandDelayMin;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.TextBox RandDelayMax;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.TextBox RandomMin;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.TextBox RandomMax;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button helpButton;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.TextBox incrementStart;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.TextBox incrementAdd;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button startHotkey;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button stopHotkey;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label loopLabel;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.TextBox timedStartTime;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.CheckBox timedEnabled;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Timer timedStartTimer;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TextBox timedStopTime;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.CheckBox timedStopEnabled;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.TextBox timedStartDate;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.TextBox timedStopDate;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.CheckBox randomSentence;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.CheckBox waitFirstBox;
	}
}
