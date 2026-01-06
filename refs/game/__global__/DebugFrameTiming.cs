public class DebugFrameTiming // TypeDefIndex: 13626
{
	// Fields
	private const string k_FpsFormatString = "{0:F1}";
	private const string k_MsFormatString = "{0:F2}ms";
	private const float k_RefreshRate = 0.2;
	internal FrameTimeSampleHistory m_FrameHistory; // 0x10
	internal BottleneckHistory m_BottleneckHistory; // 0x18
	[CompilerGenerated]
	private int <bottleneckHistorySize>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <sampleHistorySize>k__BackingField; // 0x24
	private FrameTiming[] m_Timing; // 0x28
	private FrameTimeSample m_Sample; // 0x30

	// Properties
	public int bottleneckHistorySize { get; set; }
	public int sampleHistorySize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_bottleneckHistorySize() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_bottleneckHistorySize(int value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_sampleHistorySize() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_sampleHistorySize(int value) { }

	// RVA: 0x29EAE30 Offset: 0x29E9830 VA: 0x1829EAE30
	public void .ctor() { }

	// RVA: 0x29EAC00 Offset: 0x29E9600 VA: 0x1829EAC00
	public void UpdateFrameTiming() { }

	// RVA: 0x29E88A0 Offset: 0x29E72A0 VA: 0x1829E88A0
	public void RegisterDebugUI(List<DebugUI.Widget> list) { }

	// RVA: 0x29EA380 Offset: 0x29E8D80 VA: 0x1829EA380
	internal void Reset() { }

	[CompilerGenerated]
	// RVA: 0x29EA3C0 Offset: 0x29E8DC0 VA: 0x1829EA3C0
	private object <RegisterDebugUI>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0x29EA7E0 Offset: 0x29E91E0 VA: 0x1829EA7E0
	private object <RegisterDebugUI>b__17_1() { }

	[CompilerGenerated]
	// RVA: 0x29EA900 Offset: 0x29E9300 VA: 0x1829EA900
	private object <RegisterDebugUI>b__17_2() { }

	[CompilerGenerated]
	// RVA: 0x29EA960 Offset: 0x29E9360 VA: 0x1829EA960
	private object <RegisterDebugUI>b__17_3() { }

	[CompilerGenerated]
	// RVA: 0x29EA9C0 Offset: 0x29E93C0 VA: 0x1829EA9C0
	private object <RegisterDebugUI>b__17_4() { }

	[CompilerGenerated]
	// RVA: 0x29EAA20 Offset: 0x29E9420 VA: 0x1829EAA20
	private object <RegisterDebugUI>b__17_5() { }

	[CompilerGenerated]
	// RVA: 0x29EAA80 Offset: 0x29E9480 VA: 0x1829EAA80
	private object <RegisterDebugUI>b__17_6() { }

	[CompilerGenerated]
	// RVA: 0x29EAAE0 Offset: 0x29E94E0 VA: 0x1829EAAE0
	private object <RegisterDebugUI>b__17_7() { }

	[CompilerGenerated]
	// RVA: 0x29EAB40 Offset: 0x29E9540 VA: 0x1829EAB40
	private object <RegisterDebugUI>b__17_8() { }

	[CompilerGenerated]
	// RVA: 0x29EABA0 Offset: 0x29E95A0 VA: 0x1829EABA0
	private object <RegisterDebugUI>b__17_9() { }

	[CompilerGenerated]
	// RVA: 0x29EA420 Offset: 0x29E8E20 VA: 0x1829EA420
	private object <RegisterDebugUI>b__17_10() { }

	[CompilerGenerated]
	// RVA: 0x29EA480 Offset: 0x29E8E80 VA: 0x1829EA480
	private object <RegisterDebugUI>b__17_11() { }

	[CompilerGenerated]
	// RVA: 0x29EA4E0 Offset: 0x29E8EE0 VA: 0x1829EA4E0
	private object <RegisterDebugUI>b__17_12() { }

	[CompilerGenerated]
	// RVA: 0x29EA540 Offset: 0x29E8F40 VA: 0x1829EA540
	private object <RegisterDebugUI>b__17_13() { }

	[CompilerGenerated]
	// RVA: 0x29EA5A0 Offset: 0x29E8FA0 VA: 0x1829EA5A0
	private object <RegisterDebugUI>b__17_14() { }

	[CompilerGenerated]
	// RVA: 0x29EA600 Offset: 0x29E9000 VA: 0x1829EA600
	private object <RegisterDebugUI>b__17_15() { }

	[CompilerGenerated]
	// RVA: 0x29EA660 Offset: 0x29E9060 VA: 0x1829EA660
	private object <RegisterDebugUI>b__17_16() { }

	[CompilerGenerated]
	// RVA: 0x29EA6C0 Offset: 0x29E90C0 VA: 0x1829EA6C0
	private object <RegisterDebugUI>b__17_17() { }

	[CompilerGenerated]
	// RVA: 0x29EA720 Offset: 0x29E9120 VA: 0x1829EA720
	private object <RegisterDebugUI>b__17_18() { }

	[CompilerGenerated]
	// RVA: 0x29EA780 Offset: 0x29E9180 VA: 0x1829EA780
	private object <RegisterDebugUI>b__17_19() { }

	[CompilerGenerated]
	// RVA: 0x29EA840 Offset: 0x29E9240 VA: 0x1829EA840
	private object <RegisterDebugUI>b__17_20() { }

	[CompilerGenerated]
	// RVA: 0x29EA8A0 Offset: 0x29E92A0 VA: 0x1829EA8A0
	private object <RegisterDebugUI>b__17_21() { }
}
