public class NetworkMetricsModel // TypeDefIndex: 16836
{
	// Fields
	[CompilerGenerated]
	private MetricsModel <Receive>k__BackingField; // 0x10
	[CompilerGenerated]
	private MetricsModel <Transmit>k__BackingField; // 0x18

	// Properties
	[DataMember(Name = "receive", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "receive")]
	public MetricsModel Receive { get; set; }
	[DataMember(Name = "transmit", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "transmit")]
	public MetricsModel Transmit { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MetricsModel get_Receive() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Receive(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MetricsModel get_Transmit() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Transmit(MetricsModel value) { }

	// RVA: 0xCD1360 Offset: 0xCCFD60 VA: 0x180CD1360 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD1310 Offset: 0xCCFD10 VA: 0x180CD1310
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
