internal class BsonRegex : BsonToken // TypeDefIndex: 11444
{
	// Fields
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; // 0x20
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; // 0x28

	// Properties
	public BsonString Pattern { get; set; }
	public BsonString Options { get; set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public BsonString get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Pattern(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public BsonString get_Options() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Options(BsonString value) { }

	// RVA: 0x1DEF7E0 Offset: 0x1DEE1E0 VA: 0x181DEF7E0
	public void .ctor(string pattern, string options) { }

	// RVA: 0x1DEF8C0 Offset: 0x1DEE2C0 VA: 0x181DEF8C0 Slot: 4
	public override BsonType get_Type() { }
}
