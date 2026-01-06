public class Sessions // TypeDefIndex: 16849
{
	// Fields
	[CompilerGenerated]
	private List<SessionContext> <Data>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <TotalCount>k__BackingField; // 0x18
	[CompilerGenerated]
	private Pagination <Pagination>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "data", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "data")]
	public List<SessionContext> Data { get; set; }
	[DataMember(Name = "total_count", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "total_count")]
	public Nullable<int> TotalCount { get; set; }
	[JsonProperty(PropertyName = "pagination")]
	[DataMember(Name = "pagination", EmitDefaultValue = False)]
	public Pagination Pagination { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<SessionContext> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Data(List<SessionContext> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_TotalCount() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_TotalCount(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Pagination get_Pagination() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Pagination(Pagination value) { }

	// RVA: 0xCD4520 Offset: 0xCD2F20 VA: 0x180CD4520 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD44D0 Offset: 0xCD2ED0 VA: 0x180CD44D0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
