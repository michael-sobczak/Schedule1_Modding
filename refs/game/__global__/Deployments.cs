public class Deployments // TypeDefIndex: 16801
{
	// Fields
	[CompilerGenerated]
	private List<Deployment> <Data>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <TotalCount>k__BackingField; // 0x18
	[CompilerGenerated]
	private Pagination <Pagination>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<string> <Message>k__BackingField; // 0x28

	// Properties
	[DataMember(Name = "data", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "data")]
	public List<Deployment> Data { get; set; }
	[JsonProperty(PropertyName = "total_count")]
	[DataMember(Name = "total_count", EmitDefaultValue = False)]
	public Nullable<int> TotalCount { get; set; }
	[JsonProperty(PropertyName = "pagination")]
	[DataMember(Name = "pagination", EmitDefaultValue = False)]
	public Pagination Pagination { get; set; }
	[JsonProperty(PropertyName = "message")]
	[DataMember(Name = "message", EmitDefaultValue = False)]
	public List<string> Message { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<Deployment> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Data(List<Deployment> value) { }

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

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<string> get_Message() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Message(List<string> value) { }

	// RVA: 0xCCA8A0 Offset: 0xCC92A0 VA: 0x180CCA8A0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCA850 Offset: 0xCC9250 VA: 0x180CCA850
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
