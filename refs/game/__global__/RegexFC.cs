internal sealed class RegexFC // TypeDefIndex: 9562
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Properties
	public bool CaseInsensitive { get; set; }

	// Methods

	// RVA: 0x2622AC0 Offset: 0x26214C0 VA: 0x182622AC0
	public void .ctor(bool nullable) { }

	// RVA: 0x26229C0 Offset: 0x26213C0 VA: 0x1826229C0
	public void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x2622B40 Offset: 0x2621540 VA: 0x182622B40
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x26227C0 Offset: 0x26211C0 VA: 0x1826227C0
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CompilerGenerated]
	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	public bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x2622850 Offset: 0x2621250 VA: 0x182622850
	public string GetFirstChars(CultureInfo culture) { }
}
