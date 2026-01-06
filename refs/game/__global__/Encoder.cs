public abstract class Encoder // TypeDefIndex: 4106
{
	// Fields
	internal EncoderFallback _fallback; // 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public EncoderFallback Fallback { get; }
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x1AB9090 Offset: 0x1AB7A90 VA: 0x181AB9090
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0xC2FB40 Offset: 0xC2E540 VA: 0x180C2FB40
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x1AB8FB0 Offset: 0x1AB79B0 VA: 0x181AB8FB0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x1AB8B80 Offset: 0x1AB7580 VA: 0x181AB8B80 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x1AB8D20 Offset: 0x1AB7720 VA: 0x181AB8D20 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1AB87A0 Offset: 0x1AB71A0 VA: 0x181AB87A0 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x1AB8540 Offset: 0x1AB6F40 VA: 0x181AB8540 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }
}
