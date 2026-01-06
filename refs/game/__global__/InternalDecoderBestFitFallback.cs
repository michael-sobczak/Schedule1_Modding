internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 4096
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18
	internal char _cReplacement; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1CF1610 Offset: 0x1CF0010 VA: 0x181CF1610
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1CF14F0 Offset: 0x1CEFEF0 VA: 0x181CF14F0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1CF1550 Offset: 0x1CEFF50 VA: 0x181CF1550 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 2
	public override int GetHashCode() { }
}
