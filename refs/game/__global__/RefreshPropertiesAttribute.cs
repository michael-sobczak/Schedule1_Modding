public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 9818
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x2689590 Offset: 0x2687F90 VA: 0x182689590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2689620 Offset: 0x2688020 VA: 0x182689620 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2689690 Offset: 0x2688090 VA: 0x182689690
	private static void .cctor() { }
}
