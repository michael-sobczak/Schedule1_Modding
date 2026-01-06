internal struct YogaValue // TypeDefIndex: 6160
{
	// Fields
	private float value; // 0x0
	private YogaUnit unit; // 0x4

	// Properties
	public YogaUnit Unit { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public YogaUnit get_Unit() { }

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_Value() { }

	// RVA: 0x2DC0CF0 Offset: 0x2DBF6F0 VA: 0x182DC0CF0
	public static YogaValue Point(float value) { }

	// RVA: 0x2DC0C30 Offset: 0x2DBF630 VA: 0x182DC0C30
	public bool Equals(YogaValue other) { }

	// RVA: 0x2DC0B40 Offset: 0x2DBF540 VA: 0x182DC0B40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DC0C90 Offset: 0x2DBF690 VA: 0x182DC0C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DC0B20 Offset: 0x2DBF520 VA: 0x182DC0B20
	public static YogaValue Auto() { }

	// RVA: 0x2DC0CC0 Offset: 0x2DBF6C0 VA: 0x182DC0CC0
	public static YogaValue Percent(float value) { }

	// RVA: 0x2DC0CF0 Offset: 0x2DBF6F0 VA: 0x182DC0CF0
	public static YogaValue op_Implicit(float pointValue) { }
}
