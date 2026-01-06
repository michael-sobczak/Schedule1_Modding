public class AppVersionCreateSessionConfig // TypeDefIndex: 16777
{
	// Fields
	[CompilerGenerated]
	private string <Kind>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <Sockets>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <Autodeploy>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<int> <EmptyTtl>k__BackingField; // 0x24
	[CompilerGenerated]
	private Nullable<int> <SessionMaxDuration>k__BackingField; // 0x2C

	// Properties
	[JsonProperty(PropertyName = "kind")]
	[DataMember(Name = "kind", EmitDefaultValue = False)]
	public string Kind { get; set; }
	[DataMember(Name = "sockets", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "sockets")]
	public Nullable<int> Sockets { get; set; }
	[DataMember(Name = "autodeploy", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "autodeploy")]
	public Nullable<bool> Autodeploy { get; set; }
	[DataMember(Name = "empty_ttl", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "empty_ttl")]
	public Nullable<int> EmptyTtl { get; set; }
	[JsonProperty(PropertyName = "session_max_duration")]
	[DataMember(Name = "session_max_duration", EmitDefaultValue = False)]
	public Nullable<int> SessionMaxDuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Kind() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Kind(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_Sockets() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_Sockets(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_Autodeploy() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_Autodeploy(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E80 Offset: 0xCC3880 VA: 0x180CC4E80
	public Nullable<int> get_EmptyTtl() { }

	[CompilerGenerated]
	// RVA: 0xCC4EB0 Offset: 0xCC38B0 VA: 0x180CC4EB0
	public void set_EmptyTtl(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E90 Offset: 0xCC3890 VA: 0x180CC4E90
	public Nullable<int> get_SessionMaxDuration() { }

	[CompilerGenerated]
	// RVA: 0x4944B0 Offset: 0x492EB0 VA: 0x1804944B0
	public void set_SessionMaxDuration(Nullable<int> value) { }

	// RVA: 0xCC4B90 Offset: 0xCC3590 VA: 0x180CC4B90 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC4B40 Offset: 0xCC3540 VA: 0x180CC4B40
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
