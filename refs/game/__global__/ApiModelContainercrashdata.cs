public class ApiModelContainercrashdata // TypeDefIndex: 16769
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <ExitCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <RestartCount>k__BackingField; // 0x20

	// Properties
	[JsonProperty(PropertyName = "exit_code")]
	[DataMember(Name = "exit_code", EmitDefaultValue = False)]
	public Nullable<int> ExitCode { get; set; }
	[DataMember(Name = "message", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "message")]
	public string Message { get; set; }
	[DataMember(Name = "restart_count", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "restart_count")]
	public Nullable<int> RestartCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_ExitCode() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_ExitCode(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Nullable<int> get_RestartCount() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_RestartCount(Nullable<int> value) { }

	// RVA: 0xCC44F0 Offset: 0xCC2EF0 VA: 0x180CC44F0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC44A0 Offset: 0xCC2EA0 VA: 0x180CC44A0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
