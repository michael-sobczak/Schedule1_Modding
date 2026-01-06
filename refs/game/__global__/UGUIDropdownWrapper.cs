internal class UGUIDropdownWrapper : UIInteropWrapper<Dropdown>, IDropdown // TypeDefIndex: 18007
{
	// Fields
	[CompilerGenerated]
	private IText <CaptionText>k__BackingField; // 0x18

	// Properties
	public IText CaptionText { get; set; }
	public int Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public IText get_CaptionText() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_CaptionText(IText value) { }

	// RVA: 0x448CE0 Offset: 0x4476E0 VA: 0x180448CE0 Slot: 6
	public int get_Value() { }

	// RVA: 0x448D00 Offset: 0x447700 VA: 0x180448D00 Slot: 7
	public void set_Value(int value) { }

	// RVA: 0x448C20 Offset: 0x447620 VA: 0x180448C20
	public void .ctor(Dropdown internalTarget) { }

	// RVA: 0x448BE0 Offset: 0x4475E0 VA: 0x180448BE0 Slot: 8
	public void ClearOptions() { }

	// RVA: 0x448C00 Offset: 0x447600 VA: 0x180448C00 Slot: 9
	public void RefreshShownValue() { }

	// RVA: 0x448AE0 Offset: 0x4474E0 VA: 0x180448AE0 Slot: 10
	public void AddOption(string text) { }
}
