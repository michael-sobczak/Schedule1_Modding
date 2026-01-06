internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 4107
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1ABB1A0 Offset: 0x1AB9BA0 VA: 0x181ABB1A0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1ABB200 Offset: 0x1AB9C00 VA: 0x181ABB200 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 2
	public override int GetHashCode() { }
}
