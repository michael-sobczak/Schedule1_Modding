public abstract class EncoderFallbackBuffer // TypeDefIndex: 4113
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x1AB69D0 Offset: 0x1AB53D0 VA: 0x181AB69D0 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x1AB69B0 Offset: 0x1AB53B0 VA: 0x181AB69B0
	internal void InternalReset() { }

	// RVA: 0x1AB6970 Offset: 0x1AB5370 VA: 0x181AB6970
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x1AB6930 Offset: 0x1AB5330 VA: 0x181AB6930
	internal char InternalGetNextChar() { }

	// RVA: 0x1AB6780 Offset: 0x1AB5180 VA: 0x181AB6780 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x1AB6A10 Offset: 0x1AB5410 VA: 0x181AB6A10
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
