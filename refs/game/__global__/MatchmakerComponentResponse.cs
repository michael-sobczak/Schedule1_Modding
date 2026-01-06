public class MatchmakerComponentResponse : BaseModel // TypeDefIndex: 16815
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Repository>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Image>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x38
	[CompilerGenerated]
	private object <Credentials>k__BackingField; // 0x40

	// Properties
	[DataMember(Name = "name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }
	[JsonProperty(PropertyName = "repository")]
	[DataMember(Name = "repository", EmitDefaultValue = False)]
	public string Repository { get; set; }
	[JsonProperty(PropertyName = "image")]
	[DataMember(Name = "image", EmitDefaultValue = False)]
	public string Image { get; set; }
	[JsonProperty(PropertyName = "tag")]
	[DataMember(Name = "tag", EmitDefaultValue = False)]
	public string Tag { get; set; }
	[DataMember(Name = "credentials", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "credentials")]
	public object Credentials { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Repository() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Repository(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Image() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Image(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Tag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public object get_Credentials() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Credentials(object value) { }

	// RVA: 0xCCECA0 Offset: 0xCCD6A0 VA: 0x180CCECA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCEC50 Offset: 0xCCD650 VA: 0x180CCEC50
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
