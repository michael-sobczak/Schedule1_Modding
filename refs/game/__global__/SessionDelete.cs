public class SessionDelete // TypeDefIndex: 16845
{
	// Fields
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <SessionId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <CustomId>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "message", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "message")]
	public string Message { get; set; }
	[DataMember(Name = "session_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "session_id")]
	public string SessionId { get; set; }
	[JsonProperty(PropertyName = "custom_id")]
	[DataMember(Name = "custom_id", EmitDefaultValue = False)]
	public string CustomId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_SessionId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_CustomId() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_CustomId(string value) { }

	// RVA: 0xCD3160 Offset: 0xCD1B60 VA: 0x180CD3160 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD3110 Offset: 0xCD1B10 VA: 0x180CD3110
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
