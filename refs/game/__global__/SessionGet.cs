public class SessionGet // TypeDefIndex: 16846
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
	private Nullable<int> <AppId>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <CreateTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<int> <Elapsed>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x58
	[CompilerGenerated]
	private List<SessionUser> <SessionUsers>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<SessionUser> <SessionIps>k__BackingField; // 0x68
	[CompilerGenerated]
	private Deployment <Deployment>k__BackingField; // 0x70

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
	[DataMember(Name = "ready", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ready")]
	public Nullable<bool> Ready { get; set; }
	[DataMember(Name = "linked", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "linked")]
	public Nullable<bool> Linked { get; set; }
	[DataMember(Name = "kind", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "kind")]
	public string Kind { get; set; }
	[JsonProperty(PropertyName = "user_count")]
	[DataMember(Name = "user_count", EmitDefaultValue = False)]
	public Nullable<int> UserCount { get; set; }
	[DataMember(Name = "app_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "app_id")]
	public Nullable<int> AppId { get; set; }
	[JsonProperty(PropertyName = "create_time")]
	[DataMember(Name = "create_time", EmitDefaultValue = False)]
	public string CreateTime { get; set; }
	[DataMember(Name = "elapsed", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "elapsed")]
	public Nullable<int> Elapsed { get; set; }
	[DataMember(Name = "error", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "error")]
	public string Error { get; set; }
	[DataMember(Name = "session_users", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "session_users")]
	public List<SessionUser> SessionUsers { get; set; }
	[DataMember(Name = "session_ips", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "session_ips")]
	public List<SessionUser> SessionIps { get; set; }
	[DataMember(Name = "deployment", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "deployment")]
	public Deployment Deployment { get; set; }

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
	public Nullable<int> get_AppId() { }

	[CompilerGenerated]
	// RVA: 0x54D020 Offset: 0x54BA20 VA: 0x18054D020
	public void set_AppId(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_CreateTime() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_CreateTime(string value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Nullable<int> get_Elapsed() { }

	[CompilerGenerated]
	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_Elapsed(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public List<SessionUser> get_SessionUsers() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_SessionUsers(List<SessionUser> value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public List<SessionUser> get_SessionIps() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_SessionIps(List<SessionUser> value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Deployment get_Deployment() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_Deployment(Deployment value) { }

	// RVA: 0xCD3360 Offset: 0xCD1D60 VA: 0x180CD3360 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD3310 Offset: 0xCD1D10 VA: 0x180CD3310
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
