public class MatchmakerComponentCreate // TypeDefIndex: 16809
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Repository>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Image>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x28
	[CompilerGenerated]
	private object <Credentials>k__BackingField; // 0x30

	// Properties
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }
	[JsonProperty(PropertyName = "repository")]
	[DataMember(Name = "repository", EmitDefaultValue = False)]
	public string Repository { get; set; }
	[DataMember(Name = "image", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "image")]
	public string Image { get; set; }
	[DataMember(Name = "tag", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tag")]
	public string Tag { get; set; }
	[JsonProperty(PropertyName = "credentials")]
	[DataMember(Name = "credentials", EmitDefaultValue = False)]
	public object Credentials { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Repository() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Repository(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Image() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Image(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Tag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public object get_Credentials() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Credentials(object value) { }

	// RVA: 0xCCE130 Offset: 0xCCCB30 VA: 0x180CCE130 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCE0E0 Offset: 0xCCCAE0 VA: 0x180CCE0E0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
