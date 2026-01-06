public class Pagination // TypeDefIndex: 16837
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Number>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <NextPageNumber>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <PreviousPageNumber>k__BackingField; // 0x20
	[CompilerGenerated]
	private Paginator <Paginator>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<bool> <HasNext>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<bool> <HasPrevious>k__BackingField; // 0x32

	// Properties
	[DataMember(Name = "number", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "number")]
	public Nullable<int> Number { get; set; }
	[DataMember(Name = "next_page_number", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "next_page_number")]
	public Nullable<int> NextPageNumber { get; set; }
	[DataMember(Name = "previous_page_number", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "previous_page_number")]
	public Nullable<int> PreviousPageNumber { get; set; }
	[JsonProperty(PropertyName = "paginator")]
	[DataMember(Name = "paginator", EmitDefaultValue = False)]
	public Paginator Paginator { get; set; }
	[JsonProperty(PropertyName = "has_next")]
	[DataMember(Name = "has_next", EmitDefaultValue = False)]
	public Nullable<bool> HasNext { get; set; }
	[DataMember(Name = "has_previous", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "has_previous")]
	public Nullable<bool> HasPrevious { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_Number() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_Number(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_NextPageNumber() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_NextPageNumber(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Nullable<int> get_PreviousPageNumber() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_PreviousPageNumber(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Paginator get_Paginator() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Paginator(Paginator value) { }

	[CompilerGenerated]
	// RVA: 0xCD1860 Offset: 0xCD0260 VA: 0x180CD1860
	public Nullable<bool> get_HasNext() { }

	[CompilerGenerated]
	// RVA: 0xCD1880 Offset: 0xCD0280 VA: 0x180CD1880
	public void set_HasNext(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCD1870 Offset: 0xCD0270 VA: 0x180CD1870
	public Nullable<bool> get_HasPrevious() { }

	[CompilerGenerated]
	// RVA: 0xCD1890 Offset: 0xCD0290 VA: 0x180CD1890
	public void set_HasPrevious(Nullable<bool> value) { }

	// RVA: 0xCD1510 Offset: 0xCCFF10 VA: 0x180CD1510 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD14C0 Offset: 0xCCFEC0 VA: 0x180CD14C0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
