public sealed class IdnMapping // TypeDefIndex: 4855
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x1BFE930 Offset: 0x1BFD330 VA: 0x181BFE930
	public void .ctor() { }

	// RVA: 0x1BFD840 Offset: 0x1BFC240 VA: 0x181BFD840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BFDAB0 Offset: 0x1BFC4B0 VA: 0x181BFDAB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BFD8C0 Offset: 0x1BFC2C0 VA: 0x181BFD8C0
	public string GetAscii(string unicode) { }

	// RVA: 0x1BFD990 Offset: 0x1BFC390 VA: 0x181BFD990
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x1BFD640 Offset: 0x1BFC040 VA: 0x181BFD640
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x1BFDE10 Offset: 0x1BFC810 VA: 0x181BFDE10
	private string ToAscii(string s, int offset) { }

	// RVA: 0x1BFE360 Offset: 0x1BFCD60 VA: 0x181BFE360
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x1BFDCC0 Offset: 0x1BFC6C0 VA: 0x181BFDCC0
	private string NamePrep(string s, int offset) { }

	// RVA: 0x1BFE4A0 Offset: 0x1BFCEA0 VA: 0x181BFE4A0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x1BFE6C0 Offset: 0x1BFD0C0 VA: 0x181BFE6C0
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x1BFDBF0 Offset: 0x1BFC5F0 VA: 0x181BFDBF0
	public string GetUnicode(string ascii) { }

	// RVA: 0x1BFDAD0 Offset: 0x1BFC4D0 VA: 0x181BFDAD0
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x1BFE190 Offset: 0x1BFCB90 VA: 0x181BFE190
	private string ToUnicode(string s, int offset) { }
}
