public class DescriptionAttribute : Attribute // TypeDefIndex: 9660
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DescriptionValue>k__BackingField; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x26469B0 Offset: 0x26453B0 VA: 0x1826469B0
	public void .ctor() { }

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string description) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 7
	public virtual string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected string get_DescriptionValue() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x2646780 Offset: 0x2645180 VA: 0x182646780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2646850 Offset: 0x2645250 VA: 0x182646850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2646890 Offset: 0x2645290 VA: 0x182646890 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2646900 Offset: 0x2645300 VA: 0x182646900
	private static void .cctor() { }
}
