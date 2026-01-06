public class Locations // TypeDefIndex: 16808
{
	// Fields
	[CompilerGenerated]
	private List<Location> <_Locations>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<string> <Messages>k__BackingField; // 0x18

	// Properties
	[JsonProperty(PropertyName = "locations")]
	[DataMember(Name = "locations", EmitDefaultValue = False)]
	public List<Location> _Locations { get; set; }
	[JsonProperty(PropertyName = "messages")]
	[DataMember(Name = "messages", EmitDefaultValue = False)]
	public List<string> Messages { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<Location> get__Locations() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set__Locations(List<Location> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<string> get_Messages() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Messages(List<string> value) { }

	// RVA: 0xCCDF80 Offset: 0xCCC980 VA: 0x180CCDF80 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCDF30 Offset: 0xCCC930 VA: 0x180CCDF30
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
