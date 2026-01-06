internal class StyleValueCollection // TypeDefIndex: 6803
{
	// Fields
	internal List<StyleValue> m_Values; // 0x10

	// Methods

	// RVA: 0x2F06370 Offset: 0x2F04D70 VA: 0x182F06370
	public StyleLength GetStyleLength(StylePropertyId id) { }

	// RVA: 0x2F06280 Offset: 0x2F04C80 VA: 0x182F06280
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	// RVA: 0x2F062F0 Offset: 0x2F04CF0 VA: 0x182F062F0
	public StyleInt GetStyleInt(StylePropertyId id) { }

	// RVA: 0x2F065F0 Offset: 0x2F04FF0 VA: 0x182F065F0
	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

	// RVA: 0x2F06420 Offset: 0x2F04E20 VA: 0x182F06420
	public void SetStyleValue(StyleValue value) { }

	// RVA: 0x2F06740 Offset: 0x2F05140 VA: 0x182F06740
	public void .ctor() { }
}
