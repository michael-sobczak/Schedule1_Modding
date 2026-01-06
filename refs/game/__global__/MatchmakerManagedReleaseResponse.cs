public class MatchmakerManagedReleaseResponse : MatchmakerReleaseResponseBase // TypeDefIndex: 16820
{
	// Fields
	[CompilerGenerated]
	private string <ReleaseConfigName>k__BackingField; // 0x38

	// Properties
	[DataMember(Name = "release_config_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "release_config_name")]
	public string ReleaseConfigName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_ReleaseConfigName() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_ReleaseConfigName(string value) { }

	// RVA: 0xCCF680 Offset: 0xCCE080 VA: 0x180CCF680 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCF630 Offset: 0xCCE030 VA: 0x180CCF630
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
