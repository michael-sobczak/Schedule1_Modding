public class Delete // TypeDefIndex: 16797
{
	// Fields
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x10
	[CompilerGenerated]
	private Status <DeploymentSummary>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "message")]
	[DataMember(Name = "message", EmitDefaultValue = False)]
	public string Message { get; set; }
	[DataMember(Name = "deployment_summary", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "deployment_summary")]
	public Status DeploymentSummary { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Status get_DeploymentSummary() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_DeploymentSummary(Status value) { }

	// RVA: 0xCC9170 Offset: 0xCC7B70 VA: 0x180CC9170 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9120 Offset: 0xCC7B20 VA: 0x180CC9120
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
