public class AppVersions // TypeDefIndex: 16781
{
	// Fields
	[CompilerGenerated]
	private List<AppVersion> <Versions>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <TotalCount>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "versions")]
	[DataMember(Name = "versions", EmitDefaultValue = False)]
	public List<AppVersion> Versions { get; set; }
	[JsonProperty(PropertyName = "total_count")]
	[DataMember(Name = "total_count", EmitDefaultValue = False)]
	public Nullable<int> TotalCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<AppVersion> get_Versions() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Versions(List<AppVersion> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_TotalCount() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_TotalCount(Nullable<int> value) { }

	// RVA: 0xCC76B0 Offset: 0xCC60B0 VA: 0x180CC76B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC7660 Offset: 0xCC6060 VA: 0x180CC7660
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
