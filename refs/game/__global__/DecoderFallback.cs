public abstract class DecoderFallback // TypeDefIndex: 4101
{
	// Fields
	private static DecoderFallback s_replacementFallback; // 0x0
	private static DecoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x1CEFE90 Offset: 0x1CEE890 VA: 0x181CEFE90
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x1CEFDF0 Offset: 0x1CEE7F0 VA: 0x181CEFDF0
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
