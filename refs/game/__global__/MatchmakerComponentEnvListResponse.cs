public class MatchmakerComponentEnvListResponse // TypeDefIndex: 16810
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Count>k__BackingField; // 0x10
	[CompilerGenerated]
	private MatchmakerComponentEnvsResponse <Data>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "count")]
	[DataMember(Name = "count", EmitDefaultValue = False)]
	public Nullable<int> Count { get; set; }
	[JsonProperty(PropertyName = "data")]
	[DataMember(Name = "data", EmitDefaultValue = False)]
	public MatchmakerComponentEnvsResponse Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_Count() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_Count(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MatchmakerComponentEnvsResponse get_Data() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Data(MatchmakerComponentEnvsResponse value) { }

	// RVA: 0xCCE3D0 Offset: 0xCCCDD0 VA: 0x180CCE3D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCE380 Offset: 0xCCCD80 VA: 0x180CCE380
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
