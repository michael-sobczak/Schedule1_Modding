internal class EncoderNLS : Encoder // TypeDefIndex: 4114
{
	// Fields
	internal char _charLeftOver; // 0x20
	private Encoding _encoding; // 0x28
	private bool _mustFlush; // 0x30
	internal bool _throwOnOverflow; // 0x31
	internal int _charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x1AB7C20 Offset: 0x1AB6620 VA: 0x181AB7C20
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1AB7BF0 Offset: 0x1AB65F0 VA: 0x181AB7BF0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1AB7480 Offset: 0x1AB5E80 VA: 0x181AB7480 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1AB7670 Offset: 0x1AB6070 VA: 0x181AB7670 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1AB7790 Offset: 0x1AB6190 VA: 0x181AB7790 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x1AB7AA0 Offset: 0x1AB64A0 VA: 0x181AB7AA0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1AB70C0 Offset: 0x1AB5AC0 VA: 0x181AB70C0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x1AB6EE0 Offset: 0x1AB58E0 VA: 0x181AB6EE0 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Encoding get_Encoding() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_MustFlush() { }

	// RVA: 0x1AB7C90 Offset: 0x1AB6690 VA: 0x181AB7C90 Slot: 11
	internal virtual bool get_HasState() { }

	// RVA: 0x5FF4E0 Offset: 0x5FDEE0 VA: 0x1805FF4E0
	internal void ClearMustFlush() { }
}
