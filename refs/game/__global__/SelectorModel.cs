public class SelectorModel // TypeDefIndex: 16843
{
	// Fields
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<bool> <TagOnly>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <Env>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "tag", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tag")]
	public string Tag { get; set; }
	[JsonProperty(PropertyName = "tag_only")]
	[DataMember(Name = "tag_only", EmitDefaultValue = False)]
	public Nullable<bool> TagOnly { get; set; }
	[JsonProperty(PropertyName = "env")]
	[DataMember(Name = "env", EmitDefaultValue = False)]
	public object Env { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Tag(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6380 Offset: 0xCC4D80 VA: 0x180CC6380
	public Nullable<bool> get_TagOnly() { }

	[CompilerGenerated]
	// RVA: 0xCC63F0 Offset: 0xCC4DF0 VA: 0x180CC63F0
	public void set_TagOnly(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public object get_Env() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Env(object value) { }

	// RVA: 0xCD2660 Offset: 0xCD1060 VA: 0x180CD2660 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD2610 Offset: 0xCD1010 VA: 0x180CD2610
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
