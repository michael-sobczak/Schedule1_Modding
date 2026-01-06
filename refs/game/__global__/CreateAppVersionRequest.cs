public class CreateAppVersionRequest // TypeDefIndex: 16926
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <DockerTag>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <DockerImage>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DockerRepository>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ReqCpu>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <ReqMemory>k__BackingField; // 0x3C
	[CompilerGenerated]
	private AppPortsData[] <Ports>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <PrivateUsername>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <PrivateToken>k__BackingField; // 0x50

	// Properties
	[JsonIgnore]
	public string AppName { get; set; }
	[JsonProperty("name")]
	public string VersionName { get; set; }
	[JsonProperty("docker_tag")]
	public string DockerTag { get; set; }
	[JsonProperty("docker_image")]
	public string DockerImage { get; set; }
	[JsonProperty("docker_repository")]
	public string DockerRepository { get; set; }
	[JsonProperty("req_cpu")]
	public int ReqCpu { get; set; }
	[JsonProperty("req_memory")]
	public int ReqMemory { get; set; }
	[JsonProperty("ports")]
	public AppPortsData[] Ports { get; set; }
	[JsonProperty("private_username")]
	public string PrivateUsername { get; set; }
	[JsonProperty("private_token")]
	public string PrivateToken { get; set; }

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
	public string get_DockerTag() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DockerTag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_DockerImage() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_DockerImage(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_DockerRepository() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DockerRepository(string value) { }

	[CompilerGenerated]
	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_ReqCpu() { }

	[CompilerGenerated]
	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_ReqCpu(int value) { }

	[CompilerGenerated]
	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_ReqMemory() { }

	[CompilerGenerated]
	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_ReqMemory(int value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public AppPortsData[] get_Ports() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Ports(AppPortsData[] value) { }

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

	// RVA: 0xCD71E0 Offset: 0xCD5BE0 VA: 0x180CD71E0
	public void .ctor() { }

	// RVA: 0xCD6F00 Offset: 0xCD5900 VA: 0x180CD6F00
	public void .ctor(string appName, string containerRegistryUsername, string containerRegistryPasswordToken, int portNum, ProtocolType protocolType) { }

	// RVA: 0xCD6D50 Offset: 0xCD5750 VA: 0x180CD6D50
	public static CreateAppVersionRequest FromUpdateRequest(UpdateAppVersionRequest updateRequest) { }

	// RVA: 0xCD6EB0 Offset: 0xCD58B0 VA: 0x180CD6EB0 Slot: 3
	public override string ToString() { }
}
