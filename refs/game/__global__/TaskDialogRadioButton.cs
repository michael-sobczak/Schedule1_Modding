public class TaskDialogRadioButton : TaskDialogItem // TypeDefIndex: 17310
{
	// Fields
	private bool _checked; // 0x48

	// Properties
	[DefaultValue(False)]
	[Category("Appearance")]
	[Description("Indicates whether the radio button is checked.")]
	public bool Checked { get; set; }
	protected override IEnumerable ItemCollection { get; }

	// Methods

	// RVA: 0x1E0CCC0 Offset: 0x1E0B6C0 VA: 0x181E0CCC0
	public void .ctor() { }

	// RVA: 0x1E0CDA0 Offset: 0x1E0B7A0 VA: 0x181E0CDA0
	public void .ctor(IContainer container) { }

	// RVA: 0x1E0E1C0 Offset: 0x1E0CBC0 VA: 0x181E0E1C0
	public bool get_Checked() { }

	// RVA: 0x1E0E200 Offset: 0x1E0CC00 VA: 0x181E0E200
	public void set_Checked(bool value) { }

	// RVA: 0x1E0E1D0 Offset: 0x1E0CBD0 VA: 0x181E0E1D0 Slot: 16
	protected override IEnumerable get_ItemCollection() { }
}
