public class MatchmakerComponentEnvsResponse : BaseModel // TypeDefIndex: 16812
{
	// Fields
	[CompilerGenerated]
	private string <Key>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x28

	// Properties
	[DataMember(Name = "key", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "key")]
	public string Key { get; set; }
	[DataMember(Name = "value", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "value")]
	public string Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Key() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Key(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Value(string value) { }

	// RVA: 0xCCE760 Offset: 0xCCD160 VA: 0x180CCE760 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCE710 Offset: 0xCCD110 VA: 0x180CCE710
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
