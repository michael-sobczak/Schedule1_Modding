public class AppVersionEnv // TypeDefIndex: 16778
{
	// Fields
	[CompilerGenerated]
	private string <Key>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <IsSecret>k__BackingField; // 0x20

	// Properties
	[DataMember(Name = "key", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "key")]
	public string Key { get; set; }
	[DataMember(Name = "value", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "value")]
	public string Value { get; set; }
	[DataMember(Name = "is_secret", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "is_secret")]
	public Nullable<bool> IsSecret { get; set; }

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
	public Nullable<bool> get_IsSecret() { }

	[CompilerGenerated]
	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0
	public void set_IsSecret(Nullable<bool> value) { }

	// RVA: 0xCC4F20 Offset: 0xCC3920 VA: 0x180CC4F20 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC4ED0 Offset: 0xCC38D0 VA: 0x180CC4ED0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
