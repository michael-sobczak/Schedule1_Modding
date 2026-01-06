public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 3603
{
	// Fields
	private AttributeTargets _attributeTarget; // 0x10
	private bool _allowMultiple; // 0x14
	private bool _inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x1BBB980 Offset: 0x1BBA380 VA: 0x181BBB980
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_AllowMultiple() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x1BBB9B0 Offset: 0x1BBA3B0 VA: 0x181BBB9B0
	public bool get_Inherited() { }

	// RVA: 0x1BBB9C0 Offset: 0x1BBA3C0 VA: 0x181BBB9C0
	public void set_Inherited(bool value) { }

	// RVA: 0x1BBB900 Offset: 0x1BBA300 VA: 0x181BBB900
	private static void .cctor() { }
}
