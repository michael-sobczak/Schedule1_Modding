internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData> // TypeDefIndex: 6797
{
	// Fields
	public Color color; // 0x0
	public Length fontSize; // 0x10
	public Length letterSpacing; // 0x18
	public TextShadow textShadow; // 0x20
	public Font unityFont; // 0x40
	public FontDefinition unityFontDefinition; // 0x48
	public FontStyle unityFontStyleAndWeight; // 0x58
	public Length unityParagraphSpacing; // 0x5C
	public TextAnchor unityTextAlign; // 0x64
	public Color unityTextOutlineColor; // 0x68
	public float unityTextOutlineWidth; // 0x78
	public Visibility visibility; // 0x7C
	public WhiteSpace whiteSpace; // 0x80
	public Length wordSpacing; // 0x84

	// Methods

	// RVA: 0x2EE91D0 Offset: 0x2EE7BD0 VA: 0x182EE91D0 Slot: 4
	public InheritedData Copy() { }

	// RVA: 0x2EE9140 Offset: 0x2EE7B40 VA: 0x182EE9140 Slot: 5
	public void CopyFrom(ref InheritedData other) { }

	// RVA: 0x2EE9570 Offset: 0x2EE7F70 VA: 0x182EE9570
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

	// RVA: 0x2EE9220 Offset: 0x2EE7C20 VA: 0x182EE9220 Slot: 6
	public bool Equals(InheritedData other) { }

	// RVA: 0x2EE92F0 Offset: 0x2EE7CF0 VA: 0x182EE92F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EE93F0 Offset: 0x2EE7DF0 VA: 0x182EE93F0 Slot: 2
	public override int GetHashCode() { }
}
