public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 19355
{
	// Fields
	private string name; // 0x10
	private bool isNameSetExplicitly; // 0x18
	private int order; // 0x1C
	private bool isRequired; // 0x20
	private bool emitDefaultValue; // 0x21

	// Properties
	public string Name { get; set; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; set; }

	// Methods

	// RVA: 0x21A8D60 Offset: 0x21A7760 VA: 0x1821A8D60
	public void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x21A8D80 Offset: 0x21A7780 VA: 0x1821A8D80
	public void set_Name(string value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_Order() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsRequired() { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_EmitDefaultValue() { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void set_EmitDefaultValue(bool value) { }
}
