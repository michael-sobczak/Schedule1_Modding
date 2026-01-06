public class UpdateAppVersionRequest // TypeDefIndex: 16931
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x18
	[CompilerGenerated]
	private AppPortsData[] <Ports>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <DockerRepository>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DockerImage>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <DockerTag>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <PrivateUsername>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <PrivateToken>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <MaxDuration>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <UseTelemetry>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <InjectContextEnv>k__BackingField; // 0x5D
	[CompilerGenerated]
	private bool <WhitelistingActive>k__BackingField; // 0x5E
	[CompilerGenerated]
	private bool <ForceCache>k__BackingField; // 0x5F
	[CompilerGenerated]
	private int <CacheMinHour>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <CacheMaxHour>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <TimeToDeploy>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <EnableAllLocations>k__BackingField; // 0x6C
	[CompilerGenerated]
	private int <TerminationGracePeriodSeconds>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <Command>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <Arguments>k__BackingField; // 0x80
	[CompilerGenerated]
	private UpdateAppVersionRequest.ProbeData <Probe>k__BackingField; // 0x88
	[CompilerGenerated]
	private UpdateAppVersionRequest.EnvsData[] <Envs>k__BackingField; // 0x90

	// Properties
	[JsonIgnore]
	public string AppName { get; set; }
	[JsonIgnore]
	public string VersionName { get; set; }
	[JsonProperty("ports")]
	public AppPortsData[] Ports { get; set; }
	[JsonProperty("docker_repository")]
	public string DockerRepository { get; set; }
	[JsonProperty("docker_image")]
	public string DockerImage { get; set; }
	[JsonProperty("docker_tag")]
	public string DockerTag { get; set; }
	[JsonProperty("is_active")]
	public bool IsActive { get; set; }
	[JsonProperty("private_username")]
	public string PrivateUsername { get; set; }
	[JsonProperty("private_token")]
	public string PrivateToken { get; set; }
	[JsonProperty("max_duration")]
	public int MaxDuration { get; set; }
	[JsonProperty("use_telemetry")]
	public bool UseTelemetry { get; set; }
	[JsonProperty("inject_context_env")]
	public bool InjectContextEnv { get; set; }
	[JsonProperty("whitelisting_active")]
	public bool WhitelistingActive { get; set; }
	[JsonProperty("force_cache")]
	public bool ForceCache { get; set; }
	[JsonProperty("cache_min_hour")]
	public int CacheMinHour { get; set; }
	[JsonProperty("cache_max_hour")]
	public int CacheMaxHour { get; set; }
	[JsonProperty("time_to_deploy")]
	public int TimeToDeploy { get; set; }
	[JsonProperty("enable_all_locations")]
	public bool EnableAllLocations { get; set; }
	[JsonProperty("termination_grace_period_seconds")]
	public int TerminationGracePeriodSeconds { get; set; }
	[JsonProperty("command")]
	public string Command { get; set; }
	[JsonProperty("arguments")]
	public string Arguments { get; set; }
	[JsonProperty("probe")]
	public UpdateAppVersionRequest.ProbeData Probe { get; set; }
	[JsonProperty("envs")]
	public UpdateAppVersionRequest.EnvsData[] Envs { get; set; }

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
	public AppPortsData[] get_Ports() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Ports(AppPortsData[] value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_DockerRepository() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_DockerRepository(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_DockerImage() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DockerImage(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_DockerTag() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_DockerTag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_PrivateUsername() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_PrivateUsername(string value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_PrivateToken() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_PrivateToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_MaxDuration() { }

	[CompilerGenerated]
	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_MaxDuration(int value) { }

	[CompilerGenerated]
	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	public bool get_UseTelemetry() { }

	[CompilerGenerated]
	// RVA: 0xCE3D60 Offset: 0xCE2760 VA: 0x180CE3D60
	public void set_UseTelemetry(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD970 Offset: 0x4CC370 VA: 0x1804CD970
	public bool get_InjectContextEnv() { }

	[CompilerGenerated]
	// RVA: 0xCE3D50 Offset: 0xCE2750 VA: 0x180CE3D50
	public void set_InjectContextEnv(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD960 Offset: 0x4CC360 VA: 0x1804CD960
	public bool get_WhitelistingActive() { }

	[CompilerGenerated]
	// RVA: 0xAEE580 Offset: 0xAECF80 VA: 0x180AEE580
	public void set_WhitelistingActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA10 Offset: 0x4CC410 VA: 0x1804CDA10
	public bool get_ForceCache() { }

	[CompilerGenerated]
	// RVA: 0xCE3D40 Offset: 0xCE2740 VA: 0x180CE3D40
	public void set_ForceCache(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_CacheMinHour() { }

	[CompilerGenerated]
	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_CacheMinHour(int value) { }

	[CompilerGenerated]
	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_CacheMaxHour() { }

	[CompilerGenerated]
	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_CacheMaxHour(int value) { }

	[CompilerGenerated]
	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public int get_TimeToDeploy() { }

	[CompilerGenerated]
	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_TimeToDeploy(int value) { }

	[CompilerGenerated]
	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490
	public bool get_EnableAllLocations() { }

	[CompilerGenerated]
	// RVA: 0x614530 Offset: 0x612F30 VA: 0x180614530
	public void set_EnableAllLocations(bool value) { }

	[CompilerGenerated]
	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public int get_TerminationGracePeriodSeconds() { }

	[CompilerGenerated]
	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_TerminationGracePeriodSeconds(int value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_Command() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_Command(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public string get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_Arguments(string value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public UpdateAppVersionRequest.ProbeData get_Probe() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_Probe(UpdateAppVersionRequest.ProbeData value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public UpdateAppVersionRequest.EnvsData[] get_Envs() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_Envs(UpdateAppVersionRequest.EnvsData[] value) { }

	// RVA: 0xCE3B90 Offset: 0xCE2590 VA: 0x180CE3B90
	public void .ctor() { }

	// RVA: 0xCE39C0 Offset: 0xCE23C0 VA: 0x180CE39C0
	public void .ctor(string appName) { }

	// RVA: 0xCE3970 Offset: 0xCE2370 VA: 0x180CE3970 Slot: 3
	public override string ToString() { }
}
