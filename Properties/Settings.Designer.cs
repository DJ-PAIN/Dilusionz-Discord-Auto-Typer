using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
// Archived by Vista Group 
namespace Dilusionz_Discord_Auto_Typer.Properties
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000022CF File Offset: 0x000004CF
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000022D6 File Offset: 0x000004D6
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000022E8 File Offset: 0x000004E8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int timesToLoop
		{
			get
			{
				return (int)this["timesToLoop"];
			}
			set
			{
				this["timesToLoop"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000022FB File Offset: 0x000004FB
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000230D File Offset: 0x0000050D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double interval
		{
			get
			{
				return (double)this["interval"];
			}
			set
			{
				this["interval"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002320 File Offset: 0x00000520
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002332 File Offset: 0x00000532
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double lineDelay
		{
			get
			{
				return (double)this["lineDelay"];
			}
			set
			{
				this["lineDelay"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002345 File Offset: 0x00000545
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002357 File Offset: 0x00000557
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double incrementStartingValue
		{
			get
			{
				return (double)this["incrementStartingValue"];
			}
			set
			{
				this["incrementStartingValue"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000236A File Offset: 0x0000056A
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000237C File Offset: 0x0000057C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double incrementValue
		{
			get
			{
				return (double)this["incrementValue"];
			}
			set
			{
				this["incrementValue"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000238F File Offset: 0x0000058F
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000023A1 File Offset: 0x000005A1
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool randomEnabled
		{
			get
			{
				return (bool)this["randomEnabled"];
			}
			set
			{
				this["randomEnabled"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000023C6 File Offset: 0x000005C6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool randomInterval
		{
			get
			{
				return (bool)this["randomInterval"];
			}
			set
			{
				this["randomInterval"] = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000023D9 File Offset: 0x000005D9
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000023EB File Offset: 0x000005EB
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool randomDelay
		{
			get
			{
				return (bool)this["randomDelay"];
			}
			set
			{
				this["randomDelay"] = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000023FE File Offset: 0x000005FE
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002410 File Offset: 0x00000610
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool timedStartEnabled
		{
			get
			{
				return (bool)this["timedStartEnabled"];
			}
			set
			{
				this["timedStartEnabled"] = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002423 File Offset: 0x00000623
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002435 File Offset: 0x00000635
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool timedStopEnabled
		{
			get
			{
				return (bool)this["timedStopEnabled"];
			}
			set
			{
				this["timedStopEnabled"] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000245A File Offset: 0x0000065A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("24/01/2021")]
		public string timedStartDate
		{
			get
			{
				return (string)this["timedStartDate"];
			}
			set
			{
				this["timedStartDate"] = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002468 File Offset: 0x00000668
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000247A File Offset: 0x0000067A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("00:00:00")]
		public string timedStartTime
		{
			get
			{
				return (string)this["timedStartTime"];
			}
			set
			{
				this["timedStartTime"] = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002488 File Offset: 0x00000688
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000249A File Offset: 0x0000069A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("24/01/2021")]
		public string timedStopDate
		{
			get
			{
				return (string)this["timedStopDate"];
			}
			set
			{
				this["timedStopDate"] = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000024BA File Offset: 0x000006BA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("00:00:00")]
		public string timedStopTime
		{
			get
			{
				return (string)this["timedStopTime"];
			}
			set
			{
				this["timedStopTime"] = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000024C8 File Offset: 0x000006C8
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000024DA File Offset: 0x000006DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("F8")]
		public Keys startHotkeyHashcode
		{
			get
			{
				return (Keys)this["startHotkeyHashcode"];
			}
			set
			{
				this["startHotkeyHashcode"] = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000024ED File Offset: 0x000006ED
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000024FF File Offset: 0x000006FF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("F9")]
		public Keys stopHotkeyHashcode
		{
			get
			{
				return (Keys)this["stopHotkeyHashcode"];
			}
			set
			{
				this["stopHotkeyHashcode"] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002512 File Offset: 0x00000712
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002524 File Offset: 0x00000724
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool sendAsOneMessageEnabled
		{
			get
			{
				return (bool)this["sendAsOneMessageEnabled"];
			}
			set
			{
				this["sendAsOneMessageEnabled"] = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002537 File Offset: 0x00000737
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002549 File Offset: 0x00000749
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool waitFirstEnabled
		{
			get
			{
				return (bool)this["waitFirstEnabled"];
			}
			set
			{
				this["waitFirstEnabled"] = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000255C File Offset: 0x0000075C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000256E File Offset: 0x0000076E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double randomIntervalMin
		{
			get
			{
				return (double)this["randomIntervalMin"];
			}
			set
			{
				this["randomIntervalMin"] = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002581 File Offset: 0x00000781
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002593 File Offset: 0x00000793
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double randomIntervalMax
		{
			get
			{
				return (double)this["randomIntervalMax"];
			}
			set
			{
				this["randomIntervalMax"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000025A6 File Offset: 0x000007A6
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000025B8 File Offset: 0x000007B8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double randomDelayMin
		{
			get
			{
				return (double)this["randomDelayMin"];
			}
			set
			{
				this["randomDelayMin"] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000025CB File Offset: 0x000007CB
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000025DD File Offset: 0x000007DD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double RandomDelayMax
		{
			get
			{
				return (double)this["RandomDelayMax"];
			}
			set
			{
				this["RandomDelayMax"] = value;
			}
		}

		// Token: 0x0400006D RID: 109
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
