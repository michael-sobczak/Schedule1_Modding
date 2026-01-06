internal abstract class BsonToken // TypeDefIndex: 11436
{
	// Fields
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <CalculatedSize>k__BackingField; // 0x18

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { get; set; }
	public int CalculatedSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public BsonToken get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Parent(BsonToken value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_CalculatedSize() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_CalculatedSize(int value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
