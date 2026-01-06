public class MetricsModel // TypeDefIndex: 16833
{
	// Fields
	[CompilerGenerated]
	private List<string> <Labels>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<Nullable<Decimal>> <Datasets>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<Nullable<DateTime>> <Timestamps>k__BackingField; // 0x20

	// Properties
	[JsonProperty(PropertyName = "labels")]
	[DataMember(Name = "labels", EmitDefaultValue = False)]
	public List<string> Labels { get; set; }
	[JsonProperty(PropertyName = "datasets")]
	[DataMember(Name = "datasets", EmitDefaultValue = False)]
	public List<Nullable<Decimal>> Datasets { get; set; }
	[JsonProperty(PropertyName = "timestamps")]
	[DataMember(Name = "timestamps", EmitDefaultValue = False)]
	public List<Nullable<DateTime>> Timestamps { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<string> get_Labels() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Labels(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<Nullable<Decimal>> get_Datasets() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Datasets(List<Nullable<Decimal>> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<Nullable<DateTime>> get_Timestamps() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Timestamps(List<Nullable<DateTime>> value) { }

	// RVA: 0xCD0BD0 Offset: 0xCCF5D0 VA: 0x180CD0BD0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD0B80 Offset: 0xCCF580 VA: 0x180CD0B80
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
