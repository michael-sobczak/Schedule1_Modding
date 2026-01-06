public class LocationModel // TypeDefIndex: 16807
{
	// Fields
	[CompilerGenerated]
	private Nullable<Decimal> <Latitude>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Decimal> <Longitude>k__BackingField; // 0x28

	// Properties
	[JsonProperty(PropertyName = "latitude")]
	[DataMember(Name = "latitude", EmitDefaultValue = False)]
	public Nullable<Decimal> Latitude { get; set; }
	[DataMember(Name = "longitude", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "longitude")]
	public Nullable<Decimal> Longitude { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Nullable<Decimal> get_Latitude() { }

	[CompilerGenerated]
	// RVA: 0xCCDAF0 Offset: 0xCCC4F0 VA: 0x180CCDAF0
	public void set_Latitude(Nullable<Decimal> value) { }

	[CompilerGenerated]
	// RVA: 0xCCDAD0 Offset: 0xCCC4D0 VA: 0x180CCDAD0
	public Nullable<Decimal> get_Longitude() { }

	[CompilerGenerated]
	// RVA: 0xCCDB10 Offset: 0xCCC510 VA: 0x180CCDB10
	public void set_Longitude(Nullable<Decimal> value) { }

	// RVA: 0xCCD910 Offset: 0xCCC310 VA: 0x180CCD910 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCD8C0 Offset: 0xCCC2C0 VA: 0x180CCD8C0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
