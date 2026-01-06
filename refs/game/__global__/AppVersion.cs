public class AppVersion // TypeDefIndex: 16776
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<bool> <IsActive>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <DockerRepository>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <DockerImage>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DockerTag>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <PrivateUsername>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <PrivateToken>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<int> <ReqCpu>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<int> <ReqMemory>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <ReqVideo>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<int> <MaxDuration>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <UseTelemetry>k__BackingField; // 0x68
	[CompilerGenerated]
	private Nullable<bool> <InjectContextEnv>k__BackingField; // 0x6A
	[CompilerGenerated]
	private Nullable<bool> <WhitelistingActive>k__BackingField; // 0x6C
	[CompilerGenerated]
	private Nullable<bool> <ForceCache>k__BackingField; // 0x6E
	[CompilerGenerated]
	private Nullable<int> <CacheMinHour>k__BackingField; // 0x70
	[CompilerGenerated]
	private Nullable<int> <CacheMaxHour>k__BackingField; // 0x78
	[CompilerGenerated]
	private Nullable<int> <TimeToDeploy>k__BackingField; // 0x80
	[CompilerGenerated]
	private Nullable<bool> <EnableAllLocations>k__BackingField; // 0x88
	[CompilerGenerated]
	private AppVersionCreateSessionConfig <SessionConfig>k__BackingField; // 0x90
	[CompilerGenerated]
	private List<AppVersionPort> <Ports>k__BackingField; // 0x98
	[CompilerGenerated]
	private AppVersionProbe <Probe>k__BackingField; // 0xA0
	[CompilerGenerated]
	private List<AppVersionEnv> <Envs>k__BackingField; // 0xA8

	// Properties
	[JsonProperty(PropertyName = "name")]
	[DataMember(Name = "name", EmitDefaultValue = False)]
	public string Name { get; set; }
	[JsonProperty(PropertyName = "is_active")]
	[DataMember(Name = "is_active", EmitDefaultValue = False)]
	public Nullable<bool> IsActive { get; set; }
	[JsonProperty(PropertyName = "docker_repository")]
	[DataMember(Name = "docker_repository", EmitDefaultValue = False)]
	public string DockerRepository { get; set; }
	[JsonProperty(PropertyName = "docker_image")]
	[DataMember(Name = "docker_image", EmitDefaultValue = False)]
	public string DockerImage { get; set; }
	[DataMember(Name = "docker_tag", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "docker_tag")]
	public string DockerTag { get; set; }
	[JsonProperty(PropertyName = "private_username")]
	[DataMember(Name = "private_username", EmitDefaultValue = False)]
	public string PrivateUsername { get; set; }
	[DataMember(Name = "private_token", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "private_token")]
	public string PrivateToken { get; set; }
	[DataMember(Name = "req_cpu", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "req_cpu")]
	public Nullable<int> ReqCpu { get; set; }
	[JsonProperty(PropertyName = "req_memory")]
	[DataMember(Name = "req_memory", EmitDefaultValue = False)]
	public Nullable<int> ReqMemory { get; set; }
	[DataMember(Name = "req_video", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "req_video")]
	public Nullable<int> ReqVideo { get; set; }
	[JsonProperty(PropertyName = "max_duration")]
	[DataMember(Name = "max_duration", EmitDefaultValue = False)]
	public Nullable<int> MaxDuration { get; set; }
	[DataMember(Name = "use_telemetry", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "use_telemetry")]
	public Nullable<bool> UseTelemetry { get; set; }
	[DataMember(Name = "inject_context_env", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "inject_context_env")]
	public Nullable<bool> InjectContextEnv { get; set; }
	[DataMember(Name = "whitelisting_active", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "whitelisting_active")]
	public Nullable<bool> WhitelistingActive { get; set; }
	[DataMember(Name = "force_cache", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "force_cache")]
	public Nullable<bool> ForceCache { get; set; }
	[JsonProperty(PropertyName = "cache_min_hour")]
	[DataMember(Name = "cache_min_hour", EmitDefaultValue = False)]
	public Nullable<int> CacheMinHour { get; set; }
	[DataMember(Name = "cache_max_hour", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "cache_max_hour")]
	public Nullable<int> CacheMaxHour { get; set; }
	[DataMember(Name = "time_to_deploy", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "time_to_deploy")]
	public Nullable<int> TimeToDeploy { get; set; }
	[JsonProperty(PropertyName = "enable_all_locations")]
	[DataMember(Name = "enable_all_locations", EmitDefaultValue = False)]
	public Nullable<bool> EnableAllLocations { get; set; }
	[JsonProperty(PropertyName = "session_config")]
	[DataMember(Name = "session_config", EmitDefaultValue = False)]
	public AppVersionCreateSessionConfig SessionConfig { get; set; }
	[DataMember(Name = "ports", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ports")]
	public List<AppVersionPort> Ports { get; set; }
	[JsonProperty(PropertyName = "probe")]
	[DataMember(Name = "probe", EmitDefaultValue = False)]
	public AppVersionProbe Probe { get; set; }
	[JsonProperty(PropertyName = "envs")]
	[DataMember(Name = "envs", EmitDefaultValue = False)]
	public List<AppVersionEnv> Envs { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6380 Offset: 0xCC4D80 VA: 0x180CC6380
	public Nullable<bool> get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0xCC63F0 Offset: 0xCC4DF0 VA: 0x180CC63F0
	public void set_IsActive(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_DockerRepository() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DockerRepository(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_DockerImage() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_DockerImage(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_DockerTag() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DockerTag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_PrivateUsername() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_PrivateUsername(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_PrivateToken() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_PrivateToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Nullable<int> get_ReqCpu() { }

	[CompilerGenerated]
	// RVA: 0xCC6410 Offset: 0xCC4E10 VA: 0x180CC6410
	public void set_ReqCpu(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Nullable<int> get_ReqMemory() { }

	[CompilerGenerated]
	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_ReqMemory(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Nullable<int> get_ReqVideo() { }

	[CompilerGenerated]
	// RVA: 0xCC6430 Offset: 0xCC4E30 VA: 0x180CC6430
	public void set_ReqVideo(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Nullable<int> get_MaxDuration() { }

	[CompilerGenerated]
	// RVA: 0xCC6400 Offset: 0xCC4E00 VA: 0x180CC6400
	public void set_MaxDuration(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0xCC6390 Offset: 0xCC4D90 VA: 0x180CC6390
	public Nullable<bool> get_UseTelemetry() { }

	[CompilerGenerated]
	// RVA: 0xCC6450 Offset: 0xCC4E50 VA: 0x180CC6450
	public void set_UseTelemetry(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC6370 Offset: 0xCC4D70 VA: 0x180CC6370
	public Nullable<bool> get_InjectContextEnv() { }

	[CompilerGenerated]
	// RVA: 0xCC63E0 Offset: 0xCC4DE0 VA: 0x180CC63E0
	public void set_InjectContextEnv(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC63A0 Offset: 0xCC4DA0 VA: 0x180CC63A0
	public Nullable<bool> get_WhitelistingActive() { }

	[CompilerGenerated]
	// RVA: 0xCC6460 Offset: 0xCC4E60 VA: 0x180CC6460
	public void set_WhitelistingActive(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCC6360 Offset: 0xCC4D60 VA: 0x180CC6360
	public Nullable<bool> get_ForceCache() { }

	[CompilerGenerated]
	// RVA: 0xCC63D0 Offset: 0xCC4DD0 VA: 0x180CC63D0
	public void set_ForceCache(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Nullable<int> get_CacheMinHour() { }

	[CompilerGenerated]
	// RVA: 0xCC63B0 Offset: 0xCC4DB0 VA: 0x180CC63B0
	public void set_CacheMinHour(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Nullable<int> get_CacheMaxHour() { }

	[CompilerGenerated]
	// RVA: 0xBBA840 Offset: 0xBB9240 VA: 0x180BBA840
	public void set_CacheMaxHour(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public Nullable<int> get_TimeToDeploy() { }

	[CompilerGenerated]
	// RVA: 0xCC6440 Offset: 0xCC4E40 VA: 0x180CC6440
	public void set_TimeToDeploy(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0xCC6350 Offset: 0xCC4D50 VA: 0x180CC6350
	public Nullable<bool> get_EnableAllLocations() { }

	[CompilerGenerated]
	// RVA: 0xCC63C0 Offset: 0xCC4DC0 VA: 0x180CC63C0
	public void set_EnableAllLocations(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public AppVersionCreateSessionConfig get_SessionConfig() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_SessionConfig(AppVersionCreateSessionConfig value) { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public List<AppVersionPort> get_Ports() { }

	[CompilerGenerated]
	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_Ports(List<AppVersionPort> value) { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public AppVersionProbe get_Probe() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_Probe(AppVersionProbe value) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public List<AppVersionEnv> get_Envs() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void set_Envs(List<AppVersionEnv> value) { }

	// RVA: 0xCC6CD0 Offset: 0xCC56D0 VA: 0x180CC6CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC6C80 Offset: 0xCC5680 VA: 0x180CC6C80
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
