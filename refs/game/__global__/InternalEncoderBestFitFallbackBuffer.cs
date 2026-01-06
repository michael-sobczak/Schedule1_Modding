internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 4108
{
	// Fields
	private char _cBestFit; // 0x30
	private InternalEncoderBestFitFallback _oFallback; // 0x38
	private int _iCount; // 0x40
	private int _iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1ABB0F0 Offset: 0x1AB9AF0 VA: 0x181ABB0F0
	private static object get_InternalSyncObject() { }

	// RVA: 0x1ABAF40 Offset: 0x1AB9940 VA: 0x181ABAF40
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x1ABAA80 Offset: 0x1AB9480 VA: 0x181ABAA80 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1ABABB0 Offset: 0x1AB95B0 VA: 0x181ABABB0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1ABADC0 Offset: 0x1AB97C0 VA: 0x181ABADC0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1ABADF0 Offset: 0x1AB97F0 VA: 0x181ABADF0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1ABB190 Offset: 0x1AB9B90 VA: 0x181ABB190 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1ABAE10 Offset: 0x1AB9810 VA: 0x181ABAE10 Slot: 9
	public override void Reset() { }

	// RVA: 0x1ABAE30 Offset: 0x1AB9830 VA: 0x181ABAE30
	private char TryBestFit(char cUnknown) { }
}
