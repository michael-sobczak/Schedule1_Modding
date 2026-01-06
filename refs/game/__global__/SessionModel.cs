public class SessionModel // TypeDefIndex: 16847
{
	// Fields
	[CompilerGenerated]
	private string <AppName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <VersionName>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<string> <IpList>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<GeoIpListModel> <GeoIpList>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DeploymentRequestId>k__BackingField; // 0x30
	[CompilerGenerated]
	private LocationModel <Location>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <City>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <Country>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Continent>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <AdministrativeDivision>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Region>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<SelectorModel> <Selectors>k__BackingField; // 0x68

	// Properties
	[JsonProperty(PropertyName = "app_name")]
	[DataMember(Name = "app_name", EmitDefaultValue = False)]
	public string AppName { get; set; }
	[DataMember(Name = "version_name", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "version_name")]
	public string VersionName { get; set; }
	[DataMember(Name = "ip_list", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ip_list")]
	public List<string> IpList { get; set; }
	[JsonProperty(PropertyName = "geo_ip_list")]
	[DataMember(Name = "geo_ip_list", EmitDefaultValue = False)]
	public List<GeoIpListModel> GeoIpList { get; set; }
	[DataMember(Name = "deployment_request_id", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "deployment_request_id")]
	public string DeploymentRequestId { get; set; }
	[DataMember(Name = "location", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "location")]
	public LocationModel Location { get; set; }
	[DataMember(Name = "city", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "city")]
	public string City { get; set; }
	[DataMember(Name = "country", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "country")]
	public string Country { get; set; }
	[DataMember(Name = "continent", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "continent")]
	public string Continent { get; set; }
	[JsonProperty(PropertyName = "administrative_division")]
	[DataMember(Name = "administrative_division", EmitDefaultValue = False)]
	public string AdministrativeDivision { get; set; }
	[DataMember(Name = "region", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "region")]
	public string Region { get; set; }
	[DataMember(Name = "selectors", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "selectors")]
	public List<SelectorModel> Selectors { get; set; }

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
	public List<string> get_IpList() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_IpList(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<GeoIpListModel> get_GeoIpList() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_GeoIpList(List<GeoIpListModel> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_DeploymentRequestId() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DeploymentRequestId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public LocationModel get_Location() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Location(LocationModel value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_City() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_City(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_Country() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Country(string value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Continent() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Continent(string value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_AdministrativeDivision() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_AdministrativeDivision(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Region() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Region(string value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public List<SelectorModel> get_Selectors() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Selectors(List<SelectorModel> value) { }

	// RVA: 0xCD3990 Offset: 0xCD2390 VA: 0x180CD3990 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD3940 Offset: 0xCD2340 VA: 0x180CD3940
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
