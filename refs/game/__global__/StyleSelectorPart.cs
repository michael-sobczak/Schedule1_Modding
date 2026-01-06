internal struct StyleSelectorPart // TypeDefIndex: 6891
{
	// Fields
	[SerializeField]
	private string m_Value; // 0x0
	[SerializeField]
	private StyleSelectorType m_Type; // 0x8
	internal object tempData; // 0x10

	// Properties
	public string value { get; }
	public StyleSelectorType type { get; set; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public string get_value() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public StyleSelectorType get_type() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	internal void set_type(StyleSelectorType value) { }

	// RVA: 0x2F03DA0 Offset: 0x2F027A0 VA: 0x182F03DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F03C90 Offset: 0x2F02690 VA: 0x182F03C90
	public static StyleSelectorPart CreateClass(string className) { }

	// RVA: 0x2F03CF0 Offset: 0x2F026F0 VA: 0x182F03CF0
	public static StyleSelectorPart CreateId(string Id) { }

	// RVA: 0x2F03D50 Offset: 0x2F02750 VA: 0x182F03D50
	public static StyleSelectorPart CreatePredicate(object predicate) { }
}
