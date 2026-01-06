public class GeoIpListModel // TypeDefIndex: 16805
{
	// Fields
	[CompilerGenerated]
	private string <Ip>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Decimal> <Latitude>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<Decimal> <Longitude>k__BackingField; // 0x30

	// Properties
	[DataMember(Name = "ip", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ip")]
	public string Ip { get; set; }
	[JsonProperty(PropertyName = "latitude")]
	[DataMember(Name = "latitude", EmitDefaultValue = False)]
	public Nullable<Decimal> Latitude { get; set; }
	[JsonProperty(PropertyName = "longitude")]
	[DataMember(Name = "longitude", EmitDefaultValue = False)]
	public Nullable<Decimal> Longitude { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Ip() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Ip(string value) { }

	[CompilerGenerated]
	// RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	public Nullable<Decimal> get_Latitude() { }

	[CompilerGenerated]
	// RVA: 0x49D300 Offset: 0x49BD00 VA: 0x18049D300
	public void set_Latitude(Nullable<Decimal> value) { }

	[CompilerGenerated]
	// RVA: 0xCCD880 Offset: 0xCCC280 VA: 0x180CCD880
	public Nullable<Decimal> get_Longitude() { }

	[CompilerGenerated]
	// RVA: 0xCCD8A0 Offset: 0xCCC2A0 VA: 0x180CCD8A0
	public void set_Longitude(Nullable<Decimal> value) { }

	// RVA: 0xCCD670 Offset: 0xCCC070 VA: 0x180CCD670 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCD620 Offset: 0xCCC020 VA: 0x180CCD620
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
