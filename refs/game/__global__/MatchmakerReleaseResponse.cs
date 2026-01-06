public class MatchmakerReleaseResponse : MatchmakerReleaseResponseBase // TypeDefIndex: 16827
{
	// Fields
	[CompilerGenerated]
	private string <FrontendComponentName>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <DirectorComponentName>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <MatchFunctionComponentName>k__BackingField; // 0x48

	// Properties
	[DataMember(Name = "frontend_component_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "frontend_component_name")]
	public string FrontendComponentName { get; set; }
	[JsonProperty(PropertyName = "director_component_name")]
	[DataMember(Name = "director_component_name", EmitDefaultValue = False)]
	public string DirectorComponentName { get; set; }
	[JsonProperty(PropertyName = "match_function_component_name")]
	[DataMember(Name = "match_function_component_name", EmitDefaultValue = False)]
	public string MatchFunctionComponentName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_FrontendComponentName() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_FrontendComponentName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_DirectorComponentName() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_DirectorComponentName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_MatchFunctionComponentName() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_MatchFunctionComponentName(string value) { }

	// RVA: 0xCD03B0 Offset: 0xCCEDB0 VA: 0x180CD03B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD0360 Offset: 0xCCED60 VA: 0x180CD0360
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
