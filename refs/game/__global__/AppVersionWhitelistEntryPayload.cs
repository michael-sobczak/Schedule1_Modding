public class AppVersionWhitelistEntryPayload // TypeDefIndex: 16785
{
	// Fields
	[CompilerGenerated]
	private string <Cidr>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Label>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <IsActive>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "cidr", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "cidr")]
	public string Cidr { get; set; }
	[JsonProperty(PropertyName = "label")]
	[DataMember(Name = "label", EmitDefaultValue = False)]
	public string Label { get; set; }
	[DataMember(Name = "is_active", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_active")]
	public Nullable<bool> IsActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Cidr() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Cidr(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Label() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Label(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_IsActive(Nullable<bool> value) { }

	// RVA: 0xCC64C0 Offset: 0xCC4EC0 VA: 0x180CC64C0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC6470 Offset: 0xCC4E70 VA: 0x180CC6470
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
