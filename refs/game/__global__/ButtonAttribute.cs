public sealed class ButtonAttribute : Attribute // TypeDefIndex: 19363
{
	// Fields
	public readonly string Name; // 0x10
	[CompilerGenerated]
	private ButtonMode <Mode>k__BackingField; // 0x18
	[CompilerGenerated]
	private ButtonSpacing <Spacing>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <Expanded>k__BackingField; // 0x20

	// Properties
	[PublicAPI]
	public ButtonMode Mode { get; set; }
	[PublicAPI]
	public ButtonSpacing Spacing { get; set; }
	[PublicAPI]
	public bool Expanded { get; set; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public ButtonMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_Mode(ButtonMode value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public ButtonSpacing get_Spacing() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_Spacing(ButtonSpacing value) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Expanded() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_Expanded(bool value) { }
}
