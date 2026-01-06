public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 17761
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x2191A70 Offset: 0x2190470 VA: 0x182191A70
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x2191B00 Offset: 0x2190500 VA: 0x182191B00
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGenerated]
	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0xCCDAF0 Offset: 0xCCC4F0 VA: 0x180CCDAF0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x21913A0 Offset: 0x218FDA0 VA: 0x1821913A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2191500 Offset: 0x218FF00 VA: 0x182191500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21916A0 Offset: 0x21900A0 VA: 0x1821916A0
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x2191590 Offset: 0x218FF90 VA: 0x182191590 Slot: 3
	public override string ToString() { }
}
