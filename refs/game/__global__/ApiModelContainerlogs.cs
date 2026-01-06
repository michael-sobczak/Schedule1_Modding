public class ApiModelContainerlogs // TypeDefIndex: 16770
{
	// Fields
	[CompilerGenerated]
	private string <Logs>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Encoding>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <CrashLogs>k__BackingField; // 0x20
	[CompilerGenerated]
	private ApiModelContainercrashdata <CrashData>k__BackingField; // 0x28

	// Properties
	[JsonProperty(PropertyName = "logs")]
	[DataMember(Name = "logs", EmitDefaultValue = False)]
	public string Logs { get; set; }
	[DataMember(Name = "encoding", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "encoding")]
	public string Encoding { get; set; }
	[JsonProperty(PropertyName = "crash_logs")]
	[DataMember(Name = "crash_logs", EmitDefaultValue = False)]
	public string CrashLogs { get; set; }
	[DataMember(Name = "crash_data", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "crash_data")]
	public ApiModelContainercrashdata CrashData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Logs() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Logs(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Encoding() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Encoding(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_CrashLogs() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_CrashLogs(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ApiModelContainercrashdata get_CrashData() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_CrashData(ApiModelContainercrashdata value) { }

	// RVA: 0xCC4750 Offset: 0xCC3150 VA: 0x180CC4750 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC4700 Offset: 0xCC3100 VA: 0x180CC4700
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
