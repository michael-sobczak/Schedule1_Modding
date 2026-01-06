public class BarbershopUI : CharacterCustomizationUI // TypeDefIndex: 2966
{
	// Fields
	public ColorPicker ColorPicker; // 0xB0
	public Button ApplyColorButton; // 0xB8
	private Color appliedColor; // 0xC0

	// Methods

	// RVA: 0x973D40 Offset: 0x972740 VA: 0x180973D40 Slot: 5
	public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option) { }

	// RVA: 0x973DF0 Offset: 0x9727F0 VA: 0x180973DF0 Slot: 6
	public override void OptionSelected(CharacterCustomizationOption option) { }

	// RVA: 0x973F60 Offset: 0x972960 VA: 0x180973F60 Slot: 4
	protected override void Update() { }

	// RVA: 0x973D70 Offset: 0x972770 VA: 0x180973D70 Slot: 9
	public override void Open() { }

	// RVA: 0x973CC0 Offset: 0x9726C0 VA: 0x180973CC0
	public void ColorFieldChanged(Color color) { }

	// RVA: 0x973C30 Offset: 0x972630 VA: 0x180973C30
	public void ApplyColorChange() { }

	// RVA: 0x973EA0 Offset: 0x9728A0 VA: 0x180973EA0
	public void RevertColorChange() { }

	// RVA: 0x9740B0 Offset: 0x972AB0 VA: 0x1809740B0
	public void .ctor() { }
}
