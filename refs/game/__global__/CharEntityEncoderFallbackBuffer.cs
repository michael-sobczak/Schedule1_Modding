internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 7912
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x23AFA90 Offset: 0x23AE490 VA: 0x1823AFA90
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x23AF450 Offset: 0x23ADE50 VA: 0x1823AF450 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x23AF6E0 Offset: 0x23AE0E0 VA: 0x1823AF6E0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x23AFA10 Offset: 0x23AE410 VA: 0x1823AFA10 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x23AFA60 Offset: 0x23AE460 VA: 0x1823AFA60 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x23AFB10 Offset: 0x23AE510 VA: 0x1823AFB10 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x12CC910 Offset: 0x12CB310 VA: 0x1812CC910 Slot: 9
	public override void Reset() { }

	// RVA: 0x23AFA80 Offset: 0x23AE480 VA: 0x1823AFA80
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }
}
