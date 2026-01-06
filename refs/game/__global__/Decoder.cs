public abstract class Decoder // TypeDefIndex: 4095
{
	// Fields
	internal DecoderFallback _fallback; // 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public DecoderFallback Fallback { get; }
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public DecoderFallback get_Fallback() { }

	// RVA: 0x1CF0C10 Offset: 0x1CEF610 VA: 0x181CF0C10
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0xC2FB40 Offset: 0xC2E540 VA: 0x180C2FB40
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x1CF0AE0 Offset: 0x1CEF4E0 VA: 0x181CF0AE0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	// RVA: 0x1CF0700 Offset: 0x1CEF100 VA: 0x181CF0700 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x1CF0570 Offset: 0x1CEEF70 VA: 0x181CF0570 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x1CF0720 Offset: 0x1CEF120 VA: 0x181CF0720 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x1CF0740 Offset: 0x1CEF140 VA: 0x181CF0740 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x1CF09A0 Offset: 0x1CEF3A0 VA: 0x181CF09A0 Slot: 11
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush) { }

	// RVA: 0x1CEFF30 Offset: 0x1CEE930 VA: 0x181CEFF30 Slot: 12
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x1CF0310 Offset: 0x1CEED10 VA: 0x181CF0310 Slot: 13
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}
