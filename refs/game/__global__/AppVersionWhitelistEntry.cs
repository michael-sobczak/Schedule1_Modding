public class AppVersionWhitelistEntry // TypeDefIndex: 16784
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Cidr>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Label>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <IsActive>k__BackingField; // 0x28

	// Properties
	[JsonProperty(PropertyName = "id")]
	[DataMember(Name = "id", EmitDefaultValue = False)]
	public string Id { get; set; }
	[DataMember(Name = "cidr", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "cidr")]
	public string Cidr { get; set; }
	[DataMember(Name = "label", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "label")]
	public string Label { get; set; }
	[DataMember(Name = "is_active", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_active")]
	public Nullable<bool> IsActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Id(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Cidr() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Cidr(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Label() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Label(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6B00 Offset: 0xCC5500 VA: 0x180CC6B00
	public Nullable<bool> get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0xCC6B10 Offset: 0xCC5510 VA: 0x180CC6B10
	public void set_IsActive(Nullable<bool> value) { }

	// RVA: 0xCC68D0 Offset: 0xCC52D0 VA: 0x180CC68D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC6880 Offset: 0xCC5280 VA: 0x180CC6880
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
