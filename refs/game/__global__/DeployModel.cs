public class DeployModel // TypeDefIndex: 16803
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <IsPublicApp>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<string> <IpList>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<GeoIpListModel> <GeoIpList>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<DeployEnvModel> <EnvVars>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<bool> <SkipTelemetry>k__BackingField; // 0x40
	[CompilerGenerated]
	private LocationModel <Location>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <City>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Country>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Continent>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <Region>k__BackingField; // 0x68
	[CompilerGenerated]
	private string <AdministrativeDivision>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <WebhookUrl>k__BackingField; // 0x78
	[CompilerGenerated]
	private List<string> <Tags>k__BackingField; // 0x80
	[CompilerGenerated]
	private ContainerLogStorageModel <ContainerLogStorage>k__BackingField; // 0x88

	// Properties
	[JsonProperty(PropertyName = "app_name")]
	[DataMember(Name = "app_name", EmitDefaultValue = False)]
	public string AppName { get; set; }
	[DataMember(Name = "version_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "version_name")]
	public string VersionName { get; set; }
	[DataMember(Name = "is_public_app", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_public_app")]
	public Nullable<bool> IsPublicApp { get; set; }
	[DataMember(Name = "ip_list", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ip_list")]
	public List<string> IpList { get; set; }
	[DataMember(Name = "geo_ip_list", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "geo_ip_list")]
	public List<GeoIpListModel> GeoIpList { get; set; }
	[JsonProperty(PropertyName = "env_vars")]
	[DataMember(Name = "env_vars", EmitDefaultValue = False)]
	public List<DeployEnvModel> EnvVars { get; set; }
	[JsonProperty(PropertyName = "skip_telemetry")]
	[DataMember(Name = "skip_telemetry", EmitDefaultValue = False)]
	public Nullable<bool> SkipTelemetry { get; set; }
	[JsonProperty(PropertyName = "location")]
	[DataMember(Name = "location", EmitDefaultValue = False)]
	public LocationModel Location { get; set; }
	[JsonProperty(PropertyName = "city")]
	[DataMember(Name = "city", EmitDefaultValue = False)]
	public string City { get; set; }
	[JsonProperty(PropertyName = "country")]
	[DataMember(Name = "country", EmitDefaultValue = False)]
	public string Country { get; set; }
	[DataMember(Name = "continent", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "continent")]
	public string Continent { get; set; }
	[JsonProperty(PropertyName = "region")]
	[DataMember(Name = "region", EmitDefaultValue = False)]
	public string Region { get; set; }
	[JsonProperty(PropertyName = "administrative_division")]
	[DataMember(Name = "administrative_division", EmitDefaultValue = False)]
	public string AdministrativeDivision { get; set; }
	[DataMember(Name = "webhook_url", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "webhook_url")]
	public string WebhookUrl { get; set; }
	[DataMember(Name = "tags", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tags")]
	public List<string> Tags { get; set; }
	[DataMember(Name = "container_log_storage", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "container_log_storage")]
	public ContainerLogStorageModel ContainerLogStorage { get; set; }

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
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_IsPublicApp() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_IsPublicApp(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<string> get_IpList() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_IpList(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<GeoIpListModel> get_GeoIpList() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_GeoIpList(List<GeoIpListModel> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public List<DeployEnvModel> get_EnvVars() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_EnvVars(List<DeployEnvModel> value) { }

	[CompilerGenerated]
	// RVA: 0xCC9B70 Offset: 0xCC8570 VA: 0x180CC9B70
	public Nullable<bool> get_SkipTelemetry() { }

	[CompilerGenerated]
	// RVA: 0xA82900 Offset: 0xA81300 VA: 0x180A82900
	public void set_SkipTelemetry(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public LocationModel get_Location() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Location(LocationModel value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_City() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_City(string value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_Country() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Country(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Continent() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Continent(string value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_Region() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Region(string value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public string get_AdministrativeDivision() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_AdministrativeDivision(string value) { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_WebhookUrl() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_WebhookUrl(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public List<string> get_Tags() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_Tags(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public ContainerLogStorageModel get_ContainerLogStorage() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_ContainerLogStorage(ContainerLogStorageModel value) { }

	// RVA: 0xCC9550 Offset: 0xCC7F50 VA: 0x180CC9550 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9500 Offset: 0xCC7F00 VA: 0x180CC9500
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
