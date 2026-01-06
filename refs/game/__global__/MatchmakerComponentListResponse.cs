public class MatchmakerComponentListResponse // TypeDefIndex: 16814
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Count>k__BackingField; // 0x10
	[CompilerGenerated]
	private MatchmakerComponentResponse <Data>k__BackingField; // 0x18

	// Properties
	[DataMember(Name = "count", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "count")]
	public Nullable<int> Count { get; set; }
	[DataMember(Name = "data", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "data")]
	public MatchmakerComponentResponse Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_Count() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_Count(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MatchmakerComponentResponse get_Data() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Data(MatchmakerComponentResponse value) { }

	// RVA: 0xCCEAC0 Offset: 0xCCD4C0 VA: 0x180CCEAC0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCEA70 Offset: 0xCCD470 VA: 0x180CCEA70
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
