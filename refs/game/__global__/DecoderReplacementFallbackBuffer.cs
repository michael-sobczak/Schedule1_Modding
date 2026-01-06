public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 4105
{
	// Fields
	private string _strDefault; // 0x20
	private int _fallbackCount; // 0x28
	private int _fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1AB5CC0 Offset: 0x1AB46C0 VA: 0x181AB5CC0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x1AB5BE0 Offset: 0x1AB45E0 VA: 0x181AB5BE0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1AB5C30 Offset: 0x1AB4630 VA: 0x181AB5C30 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1AB5D10 Offset: 0x1AB4710 VA: 0x181AB5D10 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1AB5CA0 Offset: 0x1AB46A0 VA: 0x181AB5CA0 Slot: 7
	public override void Reset() { }

	// RVA: 0x1AB5C80 Offset: 0x1AB4680 VA: 0x181AB5C80 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}
