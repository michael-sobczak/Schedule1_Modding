public class ButtonData : IResettable // TypeDefIndex: 18208
{
	// Fields
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Key>k__BackingField; // 0x18
	private ButtonData.PressedDelegate _delegate; // 0x20

	// Properties
	public string Text { get; set; }
	public string Key { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Text(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Key() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_Key(string value) { }

	// RVA: 0xDA30C0 Offset: 0xDA1AC0 VA: 0x180DA30C0
	public void Initialize(string text, ButtonData.PressedDelegate callback, string key = "") { }

	// RVA: 0xDA3120 Offset: 0xDA1B20 VA: 0x180DA3120 Slot: 6
	public virtual void OnPressed() { }

	// RVA: 0xDA3140 Offset: 0xDA1B40 VA: 0x180DA3140 Slot: 7
	public virtual void ResetState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void InitializeState() { }

	// RVA: 0xDA31C0 Offset: 0xDA1BC0 VA: 0x180DA31C0
	public void .ctor() { }
}
