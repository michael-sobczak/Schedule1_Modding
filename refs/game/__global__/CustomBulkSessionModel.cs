public class CustomBulkSessionModel // TypeDefIndex: 16793
{
	// Fields
	[CompilerGenerated]
	private string <CustomId>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<string> <IpList>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "custom_id")]
	[DataMember(Name = "custom_id", EmitDefaultValue = False)]
	public string CustomId { get; set; }
	[JsonProperty(PropertyName = "ip_list")]
	[DataMember(Name = "ip_list", EmitDefaultValue = False)]
	public List<string> IpList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_CustomId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_CustomId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<string> get_IpList() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_IpList(List<string> value) { }

	// RVA: 0xCC8BA0 Offset: 0xCC75A0 VA: 0x180CC8BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC8B50 Offset: 0xCC7550 VA: 0x180CC8B50
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
