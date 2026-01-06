internal class StyleComplexSelector : ISerializationCallbackReceiver // TypeDefIndex: 6886
{
	// Fields
	public Hashes ancestorHashes; // 0x10
	[SerializeField]
	private int m_Specificity; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleRule <rule>k__BackingField; // 0x28
	private bool m_isSimple; // 0x30
	[SerializeField]
	private StyleSelector[] m_Selectors; // 0x38
	[SerializeField]
	internal int ruleIndex; // 0x40
	internal StyleComplexSelector nextInTable; // 0x48
	internal int orderInStyleSheet; // 0x50
	private static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates; // 0x0
	private static List<StyleSelectorPart> m_HashList; // 0x8

	// Properties
	public int specificity { get; }
	public StyleRule rule { get; set; }
	public bool isSimple { get; }
	public StyleSelector[] selectors { get; set; }

	// Methods

	// RVA: 0x1263FA0 Offset: 0x12629A0 VA: 0x181263FA0
	public int get_specificity() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public StyleRule get_rule() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_rule(StyleRule value) { }

	// RVA: 0x2CD40F0 Offset: 0x2CD2AF0 VA: 0x182CD40F0
	public bool get_isSimple() { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public StyleSelector[] get_selectors() { }

	// RVA: 0x2F00CC0 Offset: 0x2EFF6C0 VA: 0x182F00CC0
	internal void set_selectors(StyleSelector[] value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2F00A20 Offset: 0x2EFF420 VA: 0x182F00A20 Slot: 6
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x2EFFD80 Offset: 0x2EFE780 VA: 0x182EFFD80
	internal void CachePseudoStateMasks() { }

	// RVA: 0x2F00AA0 Offset: 0x2EFF4A0 VA: 0x182F00AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F00A50 Offset: 0x2EFF450 VA: 0x182F00A50
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	// RVA: 0x2F00450 Offset: 0x2EFEE50 VA: 0x182F00450
	internal void CalculateHashes() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2F00C30 Offset: 0x2EFF630 VA: 0x182F00C30
	private static void .cctor() { }
}
