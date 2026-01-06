public class StringField : ConfigField // TypeDefIndex: 1223
{
	// Fields
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <CharacterLimit>k__BackingField; // 0x20
	private string _defaultValue; // 0x28
	private bool _canBeNullOrEmpty; // 0x30
	public UnityEvent<string> onItemChanged; // 0x38

	// Properties
	public string Value { get; set; }
	public int CharacterLimit { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_Value(string value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_CharacterLimit() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	protected void set_CharacterLimit(int value) { }

	// RVA: 0x622C30 Offset: 0x621630 VA: 0x180622C30
	public void .ctor(EntityConfiguration parentConfig, string defaultValue) { }

	// RVA: 0x622B80 Offset: 0x621580 VA: 0x180622B80
	public void SetValue(string value, bool network) { }

	// RVA: 0x622A60 Offset: 0x621460 VA: 0x180622A60
	public void Configure(int characterLimit, bool canBeNullOrEmpty) { }

	// RVA: 0x622AD0 Offset: 0x6214D0 VA: 0x180622AD0 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x622A70 Offset: 0x621470 VA: 0x180622A70
	public StringFieldData GetData() { }

	// RVA: 0x622AE0 Offset: 0x6214E0 VA: 0x180622AE0
	public void Load(StringFieldData data) { }
}
