public class BaseModel // TypeDefIndex: 16788
{
	// Fields
	[CompilerGenerated]
	private string <CreatedAt>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <UpdatedAt>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "created_at")]
	[DataMember(Name = "created_at", EmitDefaultValue = False)]
	public string CreatedAt { get; set; }
	[DataMember(Name = "updated_at", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "updated_at")]
	public string UpdatedAt { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_CreatedAt() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_CreatedAt(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_UpdatedAt() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_UpdatedAt(string value) { }

	// RVA: 0xCC8120 Offset: 0xCC6B20 VA: 0x180CC8120 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC80D0 Offset: 0xCC6AD0 VA: 0x180CC80D0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
