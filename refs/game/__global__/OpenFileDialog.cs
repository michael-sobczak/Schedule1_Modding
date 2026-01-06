public sealed class OpenFileDialog : FileDialog // TypeDefIndex: 5523
{
	// Properties
	[DefaultValue(True)]
	public override bool CheckFileExists { get; set; }
	[DefaultValue(False)]
	public bool Multiselect { get; set; }
	[DefaultValue(False)]
	public bool ReadOnlyChecked { get; set; }
	[DefaultValue(False)]
	public bool ShowReadOnly { get; set; }
	internal override string DialogTitle { get; }

	// Methods

	// RVA: 0x239A9A0 Offset: 0x23993A0 VA: 0x18239A9A0
	public void .ctor() { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0 Slot: 17
	public override bool get_CheckFileExists() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0 Slot: 18
	public override void set_CheckFileExists(bool value) { }

	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0
	public bool get_Multiselect() { }

	// RVA: 0x239AAD0 Offset: 0x23994D0 VA: 0x18239AAD0
	public void set_Multiselect(bool value) { }

	// RVA: 0x231C640 Offset: 0x231B040 VA: 0x18231C640
	public bool get_ReadOnlyChecked() { }

	// RVA: 0x239AAE0 Offset: 0x23994E0 VA: 0x18239AAE0
	public void set_ReadOnlyChecked(bool value) { }

	// RVA: 0x231C650 Offset: 0x231B050 VA: 0x18231C650
	public bool get_ShowReadOnly() { }

	// RVA: 0x239AAF0 Offset: 0x23994F0 VA: 0x18239AAF0
	public void set_ShowReadOnly(bool value) { }

	// RVA: 0x239A870 Offset: 0x2399270 VA: 0x18239A870
	public Stream OpenFile() { }

	// RVA: 0x239A960 Offset: 0x2399360 VA: 0x18239A960 Slot: 14
	public override void Reset() { }

	// RVA: 0x239AA80 Offset: 0x2399480 VA: 0x18239AA80 Slot: 19
	internal override string get_DialogTitle() { }
}
