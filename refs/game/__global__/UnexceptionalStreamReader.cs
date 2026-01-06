internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 5114
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1C40360 Offset: 0x1C3ED60 VA: 0x181C40360
	private static void .cctor() { }

	// RVA: 0x1C40410 Offset: 0x1C3EE10 VA: 0x181C40410
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1C26620 Offset: 0x1C25020 VA: 0x181C26620 Slot: 9
	public override int Peek() { }

	// RVA: 0x1C40340 Offset: 0x1C3ED40 VA: 0x181C40340 Slot: 10
	public override int Read() { }

	// RVA: 0x1C400E0 Offset: 0x1C3EAE0 VA: 0x181C400E0 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x1C3FEC0 Offset: 0x1C3E8C0 VA: 0x181C3FEC0
	private bool CheckEOL(char current) { }

	// RVA: 0x1C400A0 Offset: 0x1C3EAA0 VA: 0x181C400A0 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x1C400C0 Offset: 0x1C3EAC0 VA: 0x181C400C0 Slot: 13
	public override string ReadToEnd() { }
}
