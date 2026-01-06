public class MetricsResponse // TypeDefIndex: 16834
{
	// Fields
	[CompilerGenerated]
	private TotalMetricsModel <Total>k__BackingField; // 0x10
	[CompilerGenerated]
	private MetricsModel <Cpu>k__BackingField; // 0x18
	[CompilerGenerated]
	private MetricsModel <Mem>k__BackingField; // 0x20
	[CompilerGenerated]
	private NetworkMetricsModel <Network>k__BackingField; // 0x28

	// Properties
	[DataMember(Name = "total", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "total")]
	public TotalMetricsModel Total { get; set; }
	[DataMember(Name = "cpu", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "cpu")]
	public MetricsModel Cpu { get; set; }
	[JsonProperty(PropertyName = "mem")]
	[DataMember(Name = "mem", EmitDefaultValue = False)]
	public MetricsModel Mem { get; set; }
	[DataMember(Name = "network", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "network")]
	public NetworkMetricsModel Network { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public TotalMetricsModel get_Total() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Total(TotalMetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MetricsModel get_Cpu() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Cpu(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public MetricsModel get_Mem() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Mem(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public NetworkMetricsModel get_Network() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Network(NetworkMetricsModel value) { }

	// RVA: 0xCD0DD0 Offset: 0xCCF7D0 VA: 0x180CD0DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD0D80 Offset: 0xCCF780 VA: 0x180CD0D80
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
