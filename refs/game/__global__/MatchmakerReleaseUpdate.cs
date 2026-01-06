public class MatchmakerReleaseUpdate : MatchmakerReleaseUpdateBase // TypeDefIndex: 16829
{
	// Fields
	[CompilerGenerated]
	private string <FrontendComponentName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <DirectorComponentName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <MatchFunctionComponentName>k__BackingField; // 0x28

	// Properties
	[JsonProperty(PropertyName = "frontend_component_name")]
	[DataMember(Name = "frontend_component_name", EmitDefaultValue = False)]
	public string FrontendComponentName { get; set; }
	[JsonProperty(PropertyName = "director_component_name")]
	[DataMember(Name = "director_component_name", EmitDefaultValue = False)]
	public string DirectorComponentName { get; set; }
	[DataMember(Name = "match_function_component_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "match_function_component_name")]
	public string MatchFunctionComponentName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_FrontendComponentName() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_FrontendComponentName(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_DirectorComponentName() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DirectorComponentName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_MatchFunctionComponentName() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_MatchFunctionComponentName(string value) { }

	// RVA: 0xCD0710 Offset: 0xCCF110 VA: 0x180CD0710 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD06C0 Offset: 0xCCF0C0 VA: 0x180CD06C0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
