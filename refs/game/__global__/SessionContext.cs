public class SessionContext // TypeDefIndex: 16844
{
	// Fields
	[CompilerGenerated]
	private string <SessionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <CustomId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <Ready>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<bool> <Linked>k__BackingField; // 0x2A
	[CompilerGenerated]
	private string <Kind>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<int> <UserCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <DeploymentRequestId>k__BackingField; // 0x40

	// Properties
	[JsonProperty(PropertyName = "session_id")]
	[DataMember(Name = "session_id", EmitDefaultValue = False)]
	public string SessionId { get; set; }
	[JsonProperty(PropertyName = "custom_id")]
	[DataMember(Name = "custom_id", EmitDefaultValue = False)]
	public string CustomId { get; set; }
	[JsonProperty(PropertyName = "status")]
	[DataMember(Name = "status", EmitDefaultValue = False)]
	public string Status { get; set; }
	[JsonProperty(PropertyName = "ready")]
	[DataMember(Name = "ready", EmitDefaultValue = False)]
	public Nullable<bool> Ready { get; set; }
	[JsonProperty(PropertyName = "linked")]
	[DataMember(Name = "linked", EmitDefaultValue = False)]
	public Nullable<bool> Linked { get; set; }
	[DataMember(Name = "kind", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "kind")]
	public string Kind { get; set; }
	[JsonProperty(PropertyName = "user_count")]
	[DataMember(Name = "user_count", EmitDefaultValue = False)]
	public Nullable<int> UserCount { get; set; }
	[DataMember(Name = "deployment_request_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "deployment_request_id")]
	public string DeploymentRequestId { get; set; }

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
	public string get_Status() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Status(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6B00 Offset: 0xCC5500 VA: 0x180CC6B00
	public Nullable<bool> get_Ready() { }

	[CompilerGenerated]
	// RVA: 0xCC6B10 Offset: 0xCC5510 VA: 0x180CC6B10
	public void set_Ready(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCCA830 Offset: 0xCC9230 VA: 0x180CCA830
	public Nullable<bool> get_Linked() { }

	[CompilerGenerated]
	// RVA: 0xCCA840 Offset: 0xCC9240 VA: 0x180CCA840
	public void set_Linked(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Kind() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Kind(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Nullable<int> get_UserCount() { }

	[CompilerGenerated]
	// RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	public void set_UserCount(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_DeploymentRequestId() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_DeploymentRequestId(string value) { }

	// RVA: 0xCD2D50 Offset: 0xCD1750 VA: 0x180CD2D50 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD2D00 Offset: 0xCD1700 VA: 0x180CD2D00
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
