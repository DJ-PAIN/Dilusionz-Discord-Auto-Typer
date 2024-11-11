using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
// Archived by Vista Group 
namespace Dilusionz_Discord_Auto_Typer
{
	// Token: 0x02000007 RID: 7
	public partial class helpForm : Form
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002220 File Offset: 0x00000420
		public helpForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000222E File Offset: 0x0000042E
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://discord.gg/xXNbPcSEsq");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002074 File Offset: 0x00000274
		private void helpForm_Load(object sender, EventArgs e)
		{
		}
	}
}
