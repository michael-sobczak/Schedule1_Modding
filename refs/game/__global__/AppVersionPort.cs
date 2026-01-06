public class AppVersionPort // TypeDefIndex: 16779
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Port>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Protocol>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <ToCheck>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <TlsUpgrade>k__BackingField; // 0x22
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28

	// Properties
	[JsonProperty(PropertyName = "port")]
	[DataMember(Name = "port", EmitDefaultValue = False)]
	public Nullable<int> Port { get; set; }
	[JsonProperty(PropertyName = "protocol")]
	[DataMember(Name = "protocol", EmitDefaultValue = False)]
	public string Protocol { get; set; }
	[JsonProperty(PropertyName = "to_check")]
	[DataMember(Name = "to_check", EmitDefaultValue = False)]
	public Nullable<bool> ToCheck { get; set; }
	[DataMember(Name = "tls_upgrade", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tls_upgrade")]
	public Nullable<bool> TlsUpgrade { get; set; }
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_Port() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_Port(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Protocol() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Protocol(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_ToCheck() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_ToCheck(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC5420 Offset: 0xCC3E20 VA: 0x180CC5420
	public Nullable<bool> get_TlsUpgrade() { }

	[CompilerGenerated]
	// RVA: 0xCC5430 Offset: 0xCC3E30 VA: 0x180CC5430
	public void set_TlsUpgrade(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Name(string value) { }

	// RVA: 0xCC5150 Offset: 0xCC3B50 VA: 0x180CC5150 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC5100 Offset: 0xCC3B00 VA: 0x180CC5100
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
