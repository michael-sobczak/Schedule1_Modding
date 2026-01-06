public class DeployEnvModel // TypeDefIndex: 16798
{
	// Fields
	[CompilerGenerated]
	private string <Key>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <IsHidden>k__BackingField; // 0x20

	// Properties
	[JsonProperty(PropertyName = "key")]
	[DataMember(Name = "key", EmitDefaultValue = False)]
	public string Key { get; set; }
	[JsonProperty(PropertyName = "value")]
	[DataMember(Name = "value", EmitDefaultValue = False)]
	public string Value { get; set; }
	[DataMember(Name = "is_hidden", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_hidden")]
	public Nullable<bool> IsHidden { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Key() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Key(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Value(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	public Nullable<bool> get_IsHidden() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_IsHidden(Nullable<bool> value) { }

	// RVA: 0xCC9320 Offset: 0xCC7D20 VA: 0x180CC9320 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC92D0 Offset: 0xCC7CD0 VA: 0x180CC92D0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
