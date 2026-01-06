internal class StyleVariableContext // TypeDefIndex: 6904
{
	// Fields
	public static readonly StyleVariableContext none; // 0x0
	private int m_VariableHash; // 0x10
	private List<StyleVariable> m_Variables; // 0x18
	private List<int> m_SortedHash; // 0x20
	private List<int> m_UnsortedHash; // 0x28

	// Methods

	// RVA: 0x2F071F0 Offset: 0x2F05BF0 VA: 0x182F071F0
	public void Add(StyleVariable sv) { }

	// RVA: 0x2F070E0 Offset: 0x2F05AE0 VA: 0x182F070E0
	public void AddInitialRange(StyleVariableContext other) { }

	// RVA: 0x2F074E0 Offset: 0x2F05EE0 VA: 0x182F074E0
	public void Clear() { }

	// RVA: 0x2F07930 Offset: 0x2F06330 VA: 0x182F07930
	public void .ctor() { }

	// RVA: 0x2F07800 Offset: 0x2F06200 VA: 0x182F07800
	public void .ctor(StyleVariableContext other) { }

	// RVA: 0x2F07590 Offset: 0x2F05F90 VA: 0x182F07590
	public bool TryFindVariable(string name, out StyleVariable v) { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public int GetVariableHash() { }

	// RVA: 0x2F076B0 Offset: 0x2F060B0 VA: 0x182F076B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2F076A0 Offset: 0x2F060A0 VA: 0x182F076A0
	internal static int <Add>g__ComputeOrderSensitiveHash|7_0(int index, ref StyleVariableContext.<>c__DisplayClass7_0 ) { }
}
