public abstract class EncoderFallback // TypeDefIndex: 4112
{
	// Fields
	private static EncoderFallback s_replacementFallback; // 0x0
	private static EncoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x1AB6E20 Offset: 0x1AB5820 VA: 0x181AB6E20
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x1AB6D80 Offset: 0x1AB5780 VA: 0x181AB6D80
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
