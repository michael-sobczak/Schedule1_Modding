internal class StyleSelector // TypeDefIndex: 6890
{
	// Fields
	[SerializeField]
	private StyleSelectorPart[] m_Parts; // 0x10
	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship; // 0x18
	internal int pseudoStateMask; // 0x1C
	internal int negatedPseudoStateMask; // 0x20

	// Properties
	public StyleSelectorPart[] parts { get; set; }
	public StyleSelectorRelationship previousRelationship { get; set; }

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public StyleSelectorPart[] get_parts() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_parts(StyleSelectorPart[] value) { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	public StyleSelectorRelationship get_previousRelationship() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	// RVA: 0x2F03EE0 Offset: 0x2F028E0 VA: 0x182F03EE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F04040 Offset: 0x2F02A40 VA: 0x182F04040
	public void .ctor() { }
}
