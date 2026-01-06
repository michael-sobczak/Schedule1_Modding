public class BulkSessionPost // TypeDefIndex: 16790
{
	// Fields
	[CompilerGenerated]
	private List<SessionRequest> <Sessions>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<string> <Errors>k__BackingField; // 0x18

	// Properties
	[DataMember(Name = "sessions", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "sessions")]
	public List<SessionRequest> Sessions { get; set; }
	[JsonProperty(PropertyName = "errors")]
	[DataMember(Name = "errors", EmitDefaultValue = False)]
	public List<string> Errors { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<SessionRequest> get_Sessions() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Sessions(List<SessionRequest> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<string> get_Errors() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Errors(List<string> value) { }

	// RVA: 0xCC8480 Offset: 0xCC6E80 VA: 0x180CC8480 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC8430 Offset: 0xCC6E30 VA: 0x180CC8430
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
