public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 4116
{
	// Fields
	private string _strDefault; // 0x30
	private int _fallbackCount; // 0x38
	private int _fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1AB80D0 Offset: 0x1AB6AD0 VA: 0x181AB80D0
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x1AB7EF0 Offset: 0x1AB68F0 VA: 0x181AB7EF0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1AB7CA0 Offset: 0x1AB66A0 VA: 0x181AB7CA0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1AB8040 Offset: 0x1AB6A40 VA: 0x181AB8040 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1AB8090 Offset: 0x1AB6A90 VA: 0x181AB8090 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1AB8130 Offset: 0x1AB6B30 VA: 0x181AB8130 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1AB80B0 Offset: 0x1AB6AB0 VA: 0x181AB80B0 Slot: 9
	public override void Reset() { }
}
