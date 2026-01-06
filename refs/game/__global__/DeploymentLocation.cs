public class DeploymentLocation // TypeDefIndex: 16800
{
	// Fields
	[CompilerGenerated]
	private string <City>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Country>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Continent>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AdministrativeDivision>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Timezone>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<Decimal> <Latitude>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<Decimal> <Longitude>k__BackingField; // 0x50

	// Properties
	[JsonProperty(PropertyName = "city")]
	[DataMember(Name = "city", EmitDefaultValue = False)]
	public string City { get; set; }
	[DataMember(Name = "country", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "country")]
	public string Country { get; set; }
	[DataMember(Name = "continent", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "continent")]
	public string Continent { get; set; }
	[DataMember(Name = "administrative_division", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "administrative_division")]
	public string AdministrativeDivision { get; set; }
	[JsonProperty(PropertyName = "timezone")]
	[DataMember(Name = "timezone", EmitDefaultValue = False)]
	public string Timezone { get; set; }
	[JsonProperty(PropertyName = "latitude")]
	[DataMember(Name = "latitude", EmitDefaultValue = False)]
	public Nullable<Decimal> Latitude { get; set; }
	[DataMember(Name = "longitude", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "longitude")]
	public Nullable<Decimal> Longitude { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_City() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_City(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Country() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Country(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Continent() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Continent(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_AdministrativeDivision() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_AdministrativeDivision(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Timezone() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Timezone(string value) { }

	[CompilerGenerated]
	// RVA: 0x49CCD0 Offset: 0x49B6D0 VA: 0x18049CCD0
	public Nullable<Decimal> get_Latitude() { }

	[CompilerGenerated]
	// RVA: 0xCC9F60 Offset: 0xCC8960 VA: 0x180CC9F60
	public void set_Latitude(Nullable<Decimal> value) { }

	[CompilerGenerated]
	// RVA: 0xCC9F40 Offset: 0xCC8940 VA: 0x180CC9F40
	public Nullable<Decimal> get_Longitude() { }

	[CompilerGenerated]
	// RVA: 0xCC9F80 Offset: 0xCC8980 VA: 0x180CC9F80
	public void set_Longitude(Nullable<Decimal> value) { }

	// RVA: 0xCC9BE0 Offset: 0xCC85E0 VA: 0x180CC9BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC9B90 Offset: 0xCC8590 VA: 0x180CC9B90
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
