public sealed class SaveFileDialog : FileDialog // TypeDefIndex: 5549
{
	// Properties
	[DefaultValue(False)]
	public bool CreatePrompt { get; set; }
	[DefaultValue(True)]
	public bool OverwritePrompt { get; set; }
	internal override string DialogTitle { get; }

	// Methods

	// RVA: 0x21DAE90 Offset: 0x21D9890 VA: 0x1821DAE90
	public void .ctor() { }

	// RVA: 0x21DB000 Offset: 0x21D9A00 VA: 0x1821DB000
	public void set_CreatePrompt(bool value) { }

	// RVA: 0x21DAFA0 Offset: 0x21D99A0 VA: 0x1821DAFA0
	public bool get_CreatePrompt() { }

	// RVA: 0x6643B0 Offset: 0x662DB0 VA: 0x1806643B0
	public void set_OverwritePrompt(bool value) { }

	// RVA: 0x8391D0 Offset: 0x837BD0 VA: 0x1808391D0
	public bool get_OverwritePrompt() { }

	// RVA: 0x21DAD80 Offset: 0x21D9780 VA: 0x1821DAD80
	public Stream OpenFile() { }

	// RVA: 0x21DAE70 Offset: 0x21D9870 VA: 0x1821DAE70 Slot: 14
	public override void Reset() { }

	// RVA: 0x21DAFB0 Offset: 0x21D99B0 VA: 0x1821DAFB0 Slot: 19
	internal override string get_DialogTitle() { }
}
