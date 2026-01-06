public class GetCreateAppResult // TypeDefIndex: 16912
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsTelemetryAgentActive>k__BackingField; // 0x19
	[CompilerGenerated]
	private string <Image>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <CreateTimeStr>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <LastUpdatedStr>k__BackingField; // 0x30

	// Properties
	[JsonProperty("name")]
	public string AppName { get; set; }
	[JsonProperty("is_active")]
	public bool IsActive { get; set; }
	[JsonProperty("is_telemetry_agent_active")]
	public bool IsTelemetryAgentActive { get; set; }
	[JsonProperty("image")]
	public string Image { get; set; }
	[JsonProperty("create_time")]
	public string CreateTimeStr { get; set; }
	[JsonProperty("last_updated")]
	public string LastUpdatedStr { get; set; }

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
	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	public bool get_IsTelemetryAgentActive() { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	public void set_IsTelemetryAgentActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Image() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Image(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_CreateTimeStr() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_CreateTimeStr(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_LastUpdatedStr() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_LastUpdatedStr(string value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
