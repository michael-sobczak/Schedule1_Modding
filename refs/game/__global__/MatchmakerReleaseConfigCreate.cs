public class MatchmakerReleaseConfigCreate // TypeDefIndex: 16822
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Configuration>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "name")]
	[DataMember(Name = "name", EmitDefaultValue = False)]
	public string Name { get; set; }
	[DataMember(Name = "configuration", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "configuration")]
	public string Configuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Configuration() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Configuration(string value) { }

	// RVA: 0xCCF940 Offset: 0xCCE340 VA: 0x180CCF940 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCF8F0 Offset: 0xCCE2F0 VA: 0x180CCF8F0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
