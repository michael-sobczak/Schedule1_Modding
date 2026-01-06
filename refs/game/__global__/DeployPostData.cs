public struct DeployPostData // TypeDefIndex: 16867
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <AppVersionName>k__BackingField; // 0x8
	[CompilerGenerated]
	private IList<string> <IpList>k__BackingField; // 0x10

	// Properties
	[JsonProperty("app_name")]
	public string AppName { get; set; }
	[JsonProperty("version_name")]
	public string AppVersionName { get; set; }
	[JsonProperty("ip_list")]
	public IList<string> IpList { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_AppName() { }

	[CompilerGenerated]
	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_AppName(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public string get_AppVersionName() { }

	[CompilerGenerated]
	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_AppVersionName(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IList<string> get_IpList() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_IpList(IList<string> value) { }

	// RVA: 0xB0FAD0 Offset: 0xB0E4D0 VA: 0x180B0FAD0
	public void .ctor(string appName, string appVersionName, IList<string> ipList) { }
}
