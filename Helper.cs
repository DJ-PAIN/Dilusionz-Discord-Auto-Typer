using System;
// Archived by Vista Group 
namespace Dilusionz_Discord_Auto_Typer
{
	// Token: 0x02000006 RID: 6
	public static class Helper
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00006CAC File Offset: 0x00004EAC
		public static bool IsNumeric(this string text)
		{
			double num;
			return double.TryParse(text, out num);
		}
	}
}
