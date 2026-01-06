internal class ConfigurationEntry // TypeDefIndex: 19212
{
	// Fields
	[JsonRequired]
	[SerializeField]
	private string m_Value; // 0x10
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; // 0x18

	// Properties
	[JsonIgnore]
	public string Value { get; }
	[JsonIgnore]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Value() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsReadOnly() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1A6E860 Offset: 0x1A6D260 VA: 0x181A6E860
	public void .ctor(string value, bool isReadOnly = False) { }

	// RVA: 0x2B96D30 Offset: 0x2B95730 VA: 0x182B96D30
	public bool TrySetValue(string value) { }

	// RVA: 0xC85EC0 Offset: 0xC848C0 VA: 0x180C85EC0
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x2B96D60 Offset: 0x2B95760 VA: 0x182B96D60
	public static ConfigurationEntry op_Implicit(string value) { }
}
