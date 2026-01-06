public struct InputDeviceDescription : IEquatable<InputDeviceDescription> // TypeDefIndex: 7762
{
	// Fields
	[SerializeField]
	private string m_InterfaceName; // 0x0
	[SerializeField]
	private string m_DeviceClass; // 0x8
	[SerializeField]
	private string m_Manufacturer; // 0x10
	[SerializeField]
	private string m_Product; // 0x18
	[SerializeField]
	private string m_Serial; // 0x20
	[SerializeField]
	private string m_Version; // 0x28
	[SerializeField]
	private string m_Capabilities; // 0x30

	// Properties
	public string interfaceName { get; set; }
	public string deviceClass { get; set; }
	public string manufacturer { get; set; }
	public string product { get; set; }
	public string serial { get; set; }
	public string version { get; set; }
	public string capabilities { get; set; }
	public bool empty { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_interfaceName() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_interfaceName(string value) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public string get_deviceClass() { }

	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_deviceClass(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_manufacturer() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_manufacturer(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_product() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_product(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_serial() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_serial(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_version() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_version(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_capabilities() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_capabilities(string value) { }

	// RVA: 0x2782BB0 Offset: 0x27815B0 VA: 0x182782BB0
	public bool get_empty() { }

	// RVA: 0x2782920 Offset: 0x2781320 VA: 0x182782920 Slot: 3
	public override string ToString() { }

	// RVA: 0x2782450 Offset: 0x2780E50 VA: 0x182782450 Slot: 4
	public bool Equals(InputDeviceDescription other) { }

	// RVA: 0x27823A0 Offset: 0x2780DA0 VA: 0x1827823A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x27826A0 Offset: 0x27810A0 VA: 0x1827826A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2782C30 Offset: 0x2781630 VA: 0x182782C30
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x2782C70 Offset: 0x2781670 VA: 0x182782C70
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	// RVA: 0x2782810 Offset: 0x2781210 VA: 0x182782810
	public string ToJson() { }

	// RVA: 0x2782550 Offset: 0x2780F50 VA: 0x182782550
	public static InputDeviceDescription FromJson(string json) { }

	// RVA: 0x2782250 Offset: 0x2780C50 VA: 0x182782250
	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonParser.JsonString propertyValue, string deviceDescriptor) { }
}
