public class MatchmakerReleaseResponseBase : BaseModel // TypeDefIndex: 16828
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x30

	// Properties
	[DataMember(Name = "app_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "app_name")]
	public string AppName { get; set; }
	[DataMember(Name = "version_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "version_name")]
	public string VersionName { get; set; }
	[DataMember(Name = "version", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "version")]
	public string Version { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_AppName() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_AppName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_VersionName() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_VersionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Version(string value) { }

	// RVA: 0xCD01B0 Offset: 0xCCEBB0 VA: 0x180CD01B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD0160 Offset: 0xCCEB60 VA: 0x180CD0160
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
