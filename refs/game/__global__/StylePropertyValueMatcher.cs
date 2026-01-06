internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 7185
{
	// Fields
	private List<StylePropertyValue> m_Values; // 0x20

	// Properties
	private StylePropertyValue current { get; }
	public override int valueCount { get; }
	public override bool isCurrentVariable { get; }
	public override bool isCurrentComma { get; }

	// Methods

	// RVA: 0x2E4E730 Offset: 0x2E4D130 VA: 0x182E4E730
	private StylePropertyValue get_current() { }

	// RVA: 0x2E4E880 Offset: 0x2E4D280 VA: 0x182E4E880 Slot: 15
	public override int get_valueCount() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 16
	public override bool get_isCurrentVariable() { }

	// RVA: 0x2E4E7D0 Offset: 0x2E4D1D0 VA: 0x182E4E7D0 Slot: 17
	public override bool get_isCurrentComma() { }

	// RVA: 0x2E4E3C0 Offset: 0x2E4CDC0 VA: 0x182E4E3C0
	public MatchResult Match(Expression exp, List<StylePropertyValue> values) { }

	// RVA: 0x2E4DE50 Offset: 0x2E4C850 VA: 0x182E4DE50 Slot: 4
	protected override bool MatchKeyword(string keyword) { }

	// RVA: 0x2E4DDB0 Offset: 0x2E4C7B0 VA: 0x182E4DDB0 Slot: 5
	protected override bool MatchNumber() { }

	// RVA: 0x2E4DDB0 Offset: 0x2E4C7B0 VA: 0x182E4DDB0 Slot: 6
	protected override bool MatchInteger() { }

	// RVA: 0x2E4DF60 Offset: 0x2E4C960 VA: 0x182E4DF60 Slot: 7
	protected override bool MatchLength() { }

	// RVA: 0x2E4E070 Offset: 0x2E4CA70 VA: 0x182E4E070 Slot: 8
	protected override bool MatchPercentage() { }

	// RVA: 0x2E4DAD0 Offset: 0x2E4C4D0 VA: 0x182E4DAD0 Slot: 9
	protected override bool MatchColor() { }

	// RVA: 0x2E4E180 Offset: 0x2E4CB80 VA: 0x182E4E180 Slot: 10
	protected override bool MatchResource() { }

	// RVA: 0x2E4E310 Offset: 0x2E4CD10 VA: 0x182E4E310 Slot: 11
	protected override bool MatchUrl() { }

	// RVA: 0x2E4E220 Offset: 0x2E4CC20 VA: 0x182E4E220 Slot: 12
	protected override bool MatchTime() { }

	// RVA: 0x2E4DC70 Offset: 0x2E4C670 VA: 0x182E4DC70 Slot: 14
	protected override bool MatchCustomIdent() { }

	// RVA: 0x2E4D9C0 Offset: 0x2E4C3C0 VA: 0x182E4D9C0 Slot: 13
	protected override bool MatchAngle() { }

	// RVA: 0x2E4E680 Offset: 0x2E4D080 VA: 0x182E4E680
	public void .ctor() { }
}
