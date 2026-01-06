public class Location // TypeDefIndex: 16806
{
	// Fields
	[CompilerGenerated]
	private string <City>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Continent>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Country>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Timezone>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <AdministrativeDivision>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<Decimal> <Latitude>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<Decimal> <Longitude>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Type>k__BackingField; // 0x68

	// Properties
	[DataMember(Name = "city", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "city")]
	public string City { get; set; }
	[DataMember(Name = "continent", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "continent")]
	public string Continent { get; set; }
	[DataMember(Name = "country", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "country")]
	public string Country { get; set; }
	[DataMember(Name = "timezone", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "timezone")]
	public string Timezone { get; set; }
	[DataMember(Name = "administrative_division", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "administrative_division")]
	public string AdministrativeDivision { get; set; }
	[DataMember(Name = "latitude", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "latitude")]
	public Nullable<Decimal> Latitude { get; set; }
	[JsonProperty(PropertyName = "longitude")]
	[DataMember(Name = "longitude", EmitDefaultValue = False)]
	public Nullable<Decimal> Longitude { get; set; }
	[DataMember(Name = "type", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "type")]
	public string Type { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_City() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_City(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Continent() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Continent(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Country() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Country(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Timezone() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Timezone(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_AdministrativeDivision() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_AdministrativeDivision(string value) { }

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

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_Type() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Type(string value) { }

	// RVA: 0xCCDB80 Offset: 0xCCC580 VA: 0x180CCDB80 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCDB30 Offset: 0xCCC530 VA: 0x180CCDB30
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
