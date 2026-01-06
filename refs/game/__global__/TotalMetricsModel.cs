public class TotalMetricsModel // TypeDefIndex: 16855
{
	// Fields
	[CompilerGenerated]
	private MetricsModel <ReceiveTotal>k__BackingField; // 0x10
	[CompilerGenerated]
	private MetricsModel <TransmitTotal>k__BackingField; // 0x18
	[CompilerGenerated]
	private MetricsModel <DiskReadTotal>k__BackingField; // 0x20
	[CompilerGenerated]
	private MetricsModel <DiskWriteTotal>k__BackingField; // 0x28

	// Properties
	[DataMember(Name = "receive_total", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "receive_total")]
	public MetricsModel ReceiveTotal { get; set; }
	[DataMember(Name = "transmit_total", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "transmit_total")]
	public MetricsModel TransmitTotal { get; set; }
	[JsonProperty(PropertyName = "disk_read_total")]
	[DataMember(Name = "disk_read_total", EmitDefaultValue = False)]
	public MetricsModel DiskReadTotal { get; set; }
	[DataMember(Name = "disk_write_total", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "disk_write_total")]
	public MetricsModel DiskWriteTotal { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MetricsModel get_ReceiveTotal() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_ReceiveTotal(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MetricsModel get_TransmitTotal() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_TransmitTotal(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public MetricsModel get_DiskReadTotal() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DiskReadTotal(MetricsModel value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public MetricsModel get_DiskWriteTotal() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_DiskWriteTotal(MetricsModel value) { }

	// RVA: 0xCD5560 Offset: 0xCD3F60 VA: 0x180CD5560 Slot: 3
	public override string ToString() { }

	// RVA: 0xCD5510 Offset: 0xCD3F10 VA: 0x180CD5510
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
