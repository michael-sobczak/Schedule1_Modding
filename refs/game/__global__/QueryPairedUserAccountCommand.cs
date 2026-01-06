public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo // TypeDefIndex: 7625
{
	// Fields
	internal const int kMaxNameLength = 256;
	internal const int kMaxIdLength = 256;
	internal const int kSize = 1040;
	public InputDeviceCommand baseCommand; // 0x0
	public ulong handle; // 0x8
	[FixedBuffer(typeof(byte), 512)]
	internal QueryPairedUserAccountCommand.<nameBuffer>e__FixedBuffer nameBuffer; // 0x10
	[FixedBuffer(typeof(byte), 512)]
	internal QueryPairedUserAccountCommand.<idBuffer>e__FixedBuffer idBuffer; // 0x210

	// Properties
	public static FourCC Type { get; }
	public string id { get; set; }
	public string name { get; set; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2865810 Offset: 0x2864210 VA: 0x182865810
	public static FourCC get_Type() { }

	// RVA: 0x2865850 Offset: 0x2864250 VA: 0x182865850
	public string get_id() { }

	// RVA: 0x28658D0 Offset: 0x28642D0 VA: 0x1828658D0
	public void set_id(string value) { }

	// RVA: 0x2865870 Offset: 0x2864270 VA: 0x182865870
	public string get_name() { }

	// RVA: 0x28659F0 Offset: 0x28643F0 VA: 0x1828659F0
	public void set_name(string value) { }

	// RVA: 0x2865890 Offset: 0x2864290 VA: 0x182865890 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x28657A0 Offset: 0x28641A0 VA: 0x1828657A0
	public static QueryPairedUserAccountCommand Create() { }
}
