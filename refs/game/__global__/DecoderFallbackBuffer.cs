public abstract class DecoderFallbackBuffer // TypeDefIndex: 4102
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x1CEFB00 Offset: 0x1CEE500 VA: 0x181CEFB00 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x1CEFAE0 Offset: 0x1CEE4E0 VA: 0x181CEFAE0
	internal void InternalReset() { }

	// RVA: 0x1CEFAD0 Offset: 0x1CEE4D0 VA: 0x181CEFAD0
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x1CEF890 Offset: 0x1CEE290 VA: 0x181CEF890 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x1CEF670 Offset: 0x1CEE070 VA: 0x181CEF670 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x1CEFB40 Offset: 0x1CEE540 VA: 0x181CEFB40
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
