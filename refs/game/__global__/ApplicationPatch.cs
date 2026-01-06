public class ApplicationPatch // TypeDefIndex: 16773
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<bool> <IsActive>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Image>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }
	[DataMember(Name = "is_active", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_active")]
	public Nullable<bool> IsActive { get; set; }
	[JsonProperty(PropertyName = "image")]
	[DataMember(Name = "image", EmitDefaultValue = False)]
	public string Image { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6380 Offset: 0xCC4D80 VA: 0x180CC6380
	public Nullable<bool> get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0xCC63F0 Offset: 0xCC4DF0 VA: 0x180CC63F0
	public void set_IsActive(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Image() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Image(string value) { }

	// RVA: 0xCC7890 Offset: 0xCC6290 VA: 0x180CC7890 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC7840 Offset: 0xCC6240 VA: 0x180CC7840
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
