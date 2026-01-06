public class CreateAppRequest // TypeDefIndex: 16925
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Image>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsTelemetryAgentActive>k__BackingField; // 0x28

	// Properties
	[JsonProperty("name")]
	public string AppName { get; set; }
	[JsonProperty("is_active")]
	public bool IsActive { get; set; }
	[JsonProperty("image")]
	public string Image { get; set; }
	[JsonProperty("is_telemetry_agent_active")]
	public bool IsTelemetryAgentActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_AppName() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_AppName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Image() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Image(string value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsTelemetryAgentActive() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_IsTelemetryAgentActive(bool value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xCD6CF0 Offset: 0xCD56F0 VA: 0x180CD6CF0
	public void .ctor(string appName, bool isActive, string image) { }

	// RVA: 0xCD6CA0 Offset: 0xCD56A0 VA: 0x180CD6CA0 Slot: 3
	public override string ToString() { }
}
