public class AppCreation // TypeDefIndex: 16771
{
	// Fields
	[CompilerGenerated]
	private Nullable<bool> <Success>k__BackingField; // 0x10
	[CompilerGenerated]
	private AppVersion <Version>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "success")]
	[DataMember(Name = "success", EmitDefaultValue = False)]
	public Nullable<bool> Success { get; set; }
	[JsonProperty(PropertyName = "version")]
	[DataMember(Name = "version", EmitDefaultValue = False)]
	public AppVersion Version { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public Nullable<bool> get_Success() { }

	[CompilerGenerated]
	// RVA: 0xCC4B30 Offset: 0xCC3530 VA: 0x180CC4B30
	public void set_Success(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AppVersion get_Version() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Version(AppVersion value) { }

	// RVA: 0xCC49A0 Offset: 0xCC33A0 VA: 0x180CC49A0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC4950 Offset: 0xCC3350 VA: 0x180CC4950
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
