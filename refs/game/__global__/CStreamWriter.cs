internal class CStreamWriter : StreamWriter // TypeDefIndex: 5117
{
	// Fields
	private TermInfoDriver driver; // 0x70

	// Methods

	// RVA: 0x1C26E60 Offset: 0x1C25860 VA: 0x181C26E60
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1C26AA0 Offset: 0x1C254A0 VA: 0x181C26AA0 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C26CC0 Offset: 0x1C256C0 VA: 0x181C26CC0 Slot: 13
	public override void Write(char val) { }

	// RVA: 0x1C26A20 Offset: 0x1C25420 VA: 0x181C26A20
	public void InternalWriteString(string val) { }

	// RVA: 0x1C269E0 Offset: 0x1C253E0 VA: 0x181C269E0
	public void InternalWriteChar(char val) { }

	// RVA: 0x1C26A00 Offset: 0x1C25400 VA: 0x181C26A00
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x1C26E20 Offset: 0x1C25820 VA: 0x181C26E20 Slot: 14
	public override void Write(char[] val) { }

	// RVA: 0x1C26DB0 Offset: 0x1C257B0 VA: 0x181C26DB0 Slot: 16
	public override void Write(string val) { }

	// RVA: 0x1C26A40 Offset: 0x1C25440 VA: 0x181C26A40 Slot: 19
	public override void WriteLine(string val) { }
}
