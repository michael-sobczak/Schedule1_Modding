public class MatchmakerReleaseConfigResponse : BaseModel // TypeDefIndex: 16823
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Configuration>k__BackingField; // 0x28

	// Properties
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }
	[JsonProperty(PropertyName = "configuration")]
	[DataMember(Name = "configuration", EmitDefaultValue = False)]
	public string Configuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Configuration(string value) { }

	// RVA: 0xCCFAF0 Offset: 0xCCE4F0 VA: 0x180CCFAF0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCFAA0 Offset: 0xCCE4A0 VA: 0x180CCFAA0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
