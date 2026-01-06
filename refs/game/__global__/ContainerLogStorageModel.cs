public class ContainerLogStorageModel // TypeDefIndex: 16792
{
	// Fields
	[CompilerGenerated]
	private Nullable<bool> <Enabled>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <EndpointStorage>k__BackingField; // 0x18

	// Properties
	[DataMember(Name = "enabled", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "enabled")]
	public Nullable<bool> Enabled { get; set; }
	[DataMember(Name = "endpoint_storage", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "endpoint_storage")]
	public string EndpointStorage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public Nullable<bool> get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0xCC4B30 Offset: 0xCC3530 VA: 0x180CC4B30
	public void set_Enabled(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_EndpointStorage() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_EndpointStorage(string value) { }

	// RVA: 0xCC89C0 Offset: 0xCC73C0 VA: 0x180CC89C0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC8970 Offset: 0xCC7370 VA: 0x180CC8970
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
