public class GetDeploymentStatusResult // TypeDefIndex: 16913
{
	// Fields
	[CompilerGenerated]
	private string <RequestId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Fqdn>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <CurrentStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Running>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <WhitelistingActive>k__BackingField; // 0x39
	[CompilerGenerated]
	private string <StartTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <RemovalTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<int> <ElapsedTime>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <LastStatus>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <Error>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <ErrorDetail>k__BackingField; // 0x68
	[CompilerGenerated]
	private string <PublicIp>k__BackingField; // 0x70
	[CompilerGenerated]
	private SessionData[] <Sessions>k__BackingField; // 0x78
	[CompilerGenerated]
	private LocationData <Location>k__BackingField; // 0x80
	[CompilerGenerated]
	private string[] <Tags>k__BackingField; // 0x88
	[CompilerGenerated]
	private string <Sockets>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <SocketsUsage>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <Command>k__BackingField; // 0xA0
	[CompilerGenerated]
	private string <Arguments>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Dictionary<string, DeploymentPortsData> <PortsDict>k__BackingField; // 0xB0

	// Properties
	[JsonProperty("request_id")]
	public string RequestId { get; set; }
	[JsonProperty("fqdn")]
	public string Fqdn { get; set; }
	[JsonProperty("app_name")]
	public string AppName { get; set; }
	[JsonProperty("app_version")]
	public string AppVersion { get; set; }
	[JsonProperty("current_status")]
	public string CurrentStatus { get; set; }
	[JsonProperty("running")]
	public bool Running { get; set; }
	[JsonProperty("whitelisting_active")]
	public bool WhitelistingActive { get; set; }
	[JsonProperty("start_time")]
	public string StartTime { get; set; }
	[JsonProperty("removal_time")]
	public string RemovalTime { get; set; }
	[JsonProperty("elapsed_time")]
	public Nullable<int> ElapsedTime { get; set; }
	[JsonProperty("last_status")]
	public string LastStatus { get; set; }
	[JsonProperty("error")]
	public bool Error { get; set; }
	[JsonProperty("error_detail")]
	public string ErrorDetail { get; set; }
	[JsonProperty("public_ip")]
	public string PublicIp { get; set; }
	[JsonProperty("sessions")]
	public SessionData[] Sessions { get; set; }
	[JsonProperty("location")]
	public LocationData Location { get; set; }
	[JsonProperty("tags")]
	public string[] Tags { get; set; }
	[JsonProperty("sockets")]
	public string Sockets { get; set; }
	[JsonProperty("sockets_usage")]
	public string SocketsUsage { get; set; }
	[JsonProperty("command")]
	public string Command { get; set; }
	[JsonProperty("arguments")]
	public string Arguments { get; set; }
	[JsonProperty("ports")]
	public Dictionary<string, DeploymentPortsData> PortsDict { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_RequestId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_RequestId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Fqdn() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Fqdn(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_AppName() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_AppName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_AppVersion() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_CurrentStatus() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_CurrentStatus(string value) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_Running() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_Running(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_WhitelistingActive() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	public void set_WhitelistingActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_StartTime(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_RemovalTime() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_RemovalTime(string value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Nullable<int> get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_ElapsedTime(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_LastStatus() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_LastStatus(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_Error() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	public void set_Error(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_ErrorDetail() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_ErrorDetail(string value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public string get_PublicIp() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_PublicIp(string value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public SessionData[] get_Sessions() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_Sessions(SessionData[] value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public LocationData get_Location() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_Location(LocationData value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public string[] get_Tags() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_Tags(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_Sockets() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_Sockets(string value) { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_SocketsUsage() { }

	[CompilerGenerated]
	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_SocketsUsage(string value) { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public string get_Command() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_Command(string value) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public string get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void set_Arguments(string value) { }

	[CompilerGenerated]
	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public Dictionary<string, DeploymentPortsData> get_PortsDict() { }

	[CompilerGenerated]
	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_PortsDict(Dictionary<string, DeploymentPortsData> value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
