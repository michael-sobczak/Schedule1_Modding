public class CategoryAttribute : Attribute // TypeDefIndex: 9776
{
	// Fields
	private static CategoryAttribute defAttr; // 0x0
	private bool localized; // 0x10
	private string categoryValue; // 0x18

	// Properties
	public static CategoryAttribute Default { get; }
	public string Category { get; }

	// Methods

	// RVA: 0x265BB00 Offset: 0x265A500 VA: 0x18265BB00
	public static CategoryAttribute get_Default() { }

	// RVA: 0x265BA40 Offset: 0x265A440 VA: 0x18265BA40
	public void .ctor() { }

	// RVA: 0x10F4340 Offset: 0x10F2D40 VA: 0x1810F4340
	public void .ctor(string category) { }

	// RVA: 0x265BAA0 Offset: 0x265A4A0 VA: 0x18265BAA0
	public string get_Category() { }

	// RVA: 0x265B2D0 Offset: 0x2659CD0 VA: 0x18265B2D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x265B430 Offset: 0x2659E30 VA: 0x18265B430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x265B4A0 Offset: 0x2659EA0 VA: 0x18265B4A0 Slot: 7
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x265B8C0 Offset: 0x265A2C0 VA: 0x18265B8C0 Slot: 6
	public override bool IsDefaultAttribute() { }
}
