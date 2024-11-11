namespace Dilusionz_Discord_Auto_Typer
{
	// Token: 0x02000007 RID: 7
	public partial class helpForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000223B File Offset: 0x0000043B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006CC4 File Offset: 0x00004EC4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Dilusionz_Discord_Auto_Typer.helpForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(752, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "If you need more help using this program, go to our discord and ask for support or watch the videos pinned in the #general channel";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(84, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Basic Info:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(12, 85);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(362, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Interval: How long the program will wait before / inbetween typing.";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(12, 108);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(435, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Line Delay: The amount of time the program will wait before typing the next line";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(12, 131);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(496, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Loop Amount: The amount of times the program will type out the given text before stopping";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(12, 317);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(211, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Increment Info (OPTIONAL):";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(12, 343);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 15);
			this.label7.TabIndex = 0;
			this.label7.Text = "[inc]";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(47, 343);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(691, 15);
			this.label8.TabIndex = 0;
			this.label8.Text = "- This will create an incrementing value (first number is the starting number, second number is how much it will add each loop)";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(12, 368);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(657, 15);
			this.label9.TabIndex = 0;
			this.label9.Text = "^ This is added due to alot of requests, if you want to count, you can use this instead of typing 1,2,3,4,5,6 etc on each line.";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new global::System.Drawing.Point(342, 31);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(66, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Discord Link";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(12, 428);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(682, 15);
			this.label10.TabIndex = 0;
			this.label10.Text = "If you have trouble understanding any of these, ask for support in the discord linked at the top of this form.";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(12, 155);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(460, 15);
			this.label11.TabIndex = 0;
			this.label11.Text = "Random: The program will write out one of the sentences you have given at random";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "helpForm";
			this.Text = "helpForm";
			base.Load += new global::System.EventHandler(this.helpForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label label11;
	}
}
