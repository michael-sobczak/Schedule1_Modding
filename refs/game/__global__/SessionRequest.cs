public class SessionRequest // TypeDefIndex: 16848
{
	// Fields
	[CompilerGenerated]
	private string <SessionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <CustomId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <App>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DeploymentRequestId>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<SelectorModel> <Selectors>k__BackingField; // 0x38

	// Properties
	[DataMember(Name = "session_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "session_id")]
	public string SessionId { get; set; }
	[DataMember(Name = "custom_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "custom_id")]
	public string CustomId { get; set; }
	[JsonProperty(PropertyName = "app")]
	[DataMember(Name = "app", EmitDefaultValue = False)]
	public string App { get; set; }
	[DataMember(Name = "version", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "version")]
	public string Version { get; set; }
	[DataMember(Name = "deployment_request_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "deployment_request_id")]
	public string DeploymentRequestId { get; set; }
	[JsonProperty(PropertyName = "selectors")]
	[DataMember(Name = "selectors", EmitDefaultValue = False)]
	public List<SelectorModel> Selectors { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_SessionId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_CustomId() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_CustomId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_App() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_App(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_DeploymentRequestId() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DeploymentRequestId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public List<SelectorModel> get_Selectors() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Selectors(List<SelectorModel> value) { }

	// RVA: 0xCD3E70 Offset: 0xCD2870 VA: 0x180CD3E70 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD3E20 Offset: 0xCD2820 VA: 0x180CD3E20
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
