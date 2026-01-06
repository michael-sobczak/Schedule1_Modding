public class CreateDeploymentRequest // TypeDefIndex: 16927
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string[] <IpList>k__BackingField; // 0x20
	[CompilerGenerated]
	private string[] <GeoIpList>k__BackingField; // 0x28

	// Properties
	[JsonProperty("app_name")]
	public string AppName { get; set; }
	[JsonProperty("version_name")]
	public string VersionName { get; set; }
	[JsonProperty("ip_list")]
	public string[] IpList { get; set; }
	[JsonProperty("geo_ip_list")]
	public string[] GeoIpList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_AppName() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_AppName(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_VersionName() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_VersionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string[] get_IpList() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_IpList(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string[] get_GeoIpList() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_GeoIpList(string[] value) { }

	// RVA: 0xCD7440 Offset: 0xCD5E40 VA: 0x180CD7440
	public void .ctor() { }

	// RVA: 0xCD7350 Offset: 0xCD5D50 VA: 0x180CD7350
	public void .ctor(string appName, string versionName, string externalIp) { }

	// RVA: 0xCD7300 Offset: 0xCD5D00 VA: 0x180CD7300 Slot: 3
	public override string ToString() { }
}
