public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 4110
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1AB6350 Offset: 0x1AB4D50 VA: 0x181AB6350 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1AB6410 Offset: 0x1AB4E10 VA: 0x181AB6410 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public override int get_Remaining() { }
}
