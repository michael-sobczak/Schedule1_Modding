public class AppPortsData // TypeDefIndex: 16902
{
	// Fields
	[CompilerGenerated]
	private int <Port>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProtocolStr>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <ToCheck>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <TlsUpgrade>k__BackingField; // 0x21
	[CompilerGenerated]
	private string <PortName>k__BackingField; // 0x28

	// Properties
	[JsonProperty("port")]
	public int Port { get; set; }
	[JsonProperty("protocol")]
	public string ProtocolStr { get; set; }
	[JsonProperty("to_check")]
	public bool ToCheck { get; set; }
	[JsonProperty("tls_upgrade")]
	public bool TlsUpgrade { get; set; }
	[JsonProperty("name")]
	public string PortName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Port() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_Port(int value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_ProtocolStr() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ProtocolStr(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_ToCheck() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_ToCheck(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_TlsUpgrade() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void set_TlsUpgrade(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_PortName() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_PortName(string value) { }

	// RVA: 0xCD6C00 Offset: 0xCD5600 VA: 0x180CD6C00
	public void .ctor() { }
}
