public class PortMapping // TypeDefIndex: 16840
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <External>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <Internal>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Protocol>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<bool> <TlsUpgrade>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Link>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<int> <Proxy>k__BackingField; // 0x40

	// Properties
	[DataMember(Name = "external", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "external")]
	public Nullable<int> External { get; set; }
	[JsonProperty(PropertyName = "internal")]
	[DataMember(Name = "internal", EmitDefaultValue = False)]
	public Nullable<int> Internal { get; set; }
	[DataMember(Name = "protocol", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "protocol")]
	public string Protocol { get; set; }
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }
	[DataMember(Name = "tls_upgrade", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tls_upgrade")]
	public Nullable<bool> TlsUpgrade { get; set; }
	[DataMember(Name = "link", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "link")]
	public string Link { get; set; }
	[DataMember(Name = "proxy", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "proxy")]
	public Nullable<int> Proxy { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_External() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_External(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_Internal() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_Internal(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Protocol() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Protocol(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0xCD1860 Offset: 0xCD0260 VA: 0x180CD1860
	public Nullable<bool> get_TlsUpgrade() { }

	[CompilerGenerated]
	// RVA: 0xCD1880 Offset: 0xCD0280 VA: 0x180CD1880
	public void set_TlsUpgrade(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Link() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Link(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Nullable<int> get_Proxy() { }

	[CompilerGenerated]
	// RVA: 0x54D020 Offset: 0x54BA20 VA: 0x18054D020
	public void set_Proxy(Nullable<int> value) { }

	// RVA: 0xCD1C20 Offset: 0xCD0620 VA: 0x180CD1C20 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD1BD0 Offset: 0xCD05D0 VA: 0x180CD1BD0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
