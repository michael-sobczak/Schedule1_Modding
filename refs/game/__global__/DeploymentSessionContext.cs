public class DeploymentSessionContext // TypeDefIndex: 16802
{
	// Fields
	[CompilerGenerated]
	private string <SessionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Status>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <Ready>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <Linked>k__BackingField; // 0x22
	[CompilerGenerated]
	private string <Kind>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<int> <UserCount>k__BackingField; // 0x30

	// Properties
	[JsonProperty(PropertyName = "session_id")]
	[DataMember(Name = "session_id", EmitDefaultValue = False)]
	public string SessionId { get; set; }
	[JsonProperty(PropertyName = "status")]
	[DataMember(Name = "status", EmitDefaultValue = False)]
	public string Status { get; set; }
	[DataMember(Name = "ready", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ready")]
	public Nullable<bool> Ready { get; set; }
	[DataMember(Name = "linked", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "linked")]
	public Nullable<bool> Linked { get; set; }
	[DataMember(Name = "kind", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "kind")]
	public string Kind { get; set; }
	[DataMember(Name = "user_count", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "user_count")]
	public Nullable<int> UserCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_SessionId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Status() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Status(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_Ready() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_Ready(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC5420 Offset: 0xCC3E20 VA: 0x180CC5420
	public Nullable<bool> get_Linked() { }

	[CompilerGenerated]
	// RVA: 0xCC5430 Offset: 0xCC3E30 VA: 0x180CC5430
	public void set_Linked(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Kind() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Kind(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Nullable<int> get_UserCount() { }

	[CompilerGenerated]
	// RVA: 0x5E0890 Offset: 0x5DF290 VA: 0x1805E0890
	public void set_UserCount(Nullable<int> value) { }

	// RVA: 0xCC9FF0 Offset: 0xCC89F0 VA: 0x180CC9FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9FA0 Offset: 0xCC89A0 VA: 0x180CC9FA0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
