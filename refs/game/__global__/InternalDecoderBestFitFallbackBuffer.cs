internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 4097
{
	// Fields
	private char _cBestFit; // 0x20
	private int _iCount; // 0x24
	private int _iSize; // 0x28
	private InternalDecoderBestFitFallback _oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1CF1450 Offset: 0x1CEFE50 VA: 0x181CF1450
	private static object get_InternalSyncObject() { }

	// RVA: 0x1CF12A0 Offset: 0x1CEFCA0 VA: 0x181CF12A0
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x1CF1070 Offset: 0x1CEFA70 VA: 0x181CF1070 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1CF10C0 Offset: 0x1CEFAC0 VA: 0x181CF10C0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1AB6240 Offset: 0x1AB4C40 VA: 0x181AB6240 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1AB6220 Offset: 0x1AB4C20 VA: 0x181AB6220 Slot: 7
	public override void Reset() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x1CF10F0 Offset: 0x1CEFAF0 VA: 0x181CF10F0
	private char TryBestFit(byte[] bytesCheck) { }
}
