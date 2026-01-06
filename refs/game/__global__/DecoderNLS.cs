internal class DecoderNLS : Decoder // TypeDefIndex: 4103
{
	// Fields
	private Encoding _encoding; // 0x20
	private bool _mustFlush; // 0x28
	internal bool _throwOnOverflow; // 0x29
	internal int _bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x1AB5B70 Offset: 0x1AB4570 VA: 0x181AB5B70
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1AB5B50 Offset: 0x1AB4550 VA: 0x181AB5B50 Slot: 4
	public override void Reset() { }

	// RVA: 0x1AB5350 Offset: 0x1AB3D50 VA: 0x181AB5350 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1AB54A0 Offset: 0x1AB3EA0 VA: 0x181AB54A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1AB5380 Offset: 0x1AB3D80 VA: 0x181AB5380 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x1AB56A0 Offset: 0x1AB40A0 VA: 0x181AB56A0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1AB5840 Offset: 0x1AB4240 VA: 0x181AB5840 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x1AB56E0 Offset: 0x1AB40E0 VA: 0x181AB56E0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x1AB4F90 Offset: 0x1AB3990 VA: 0x181AB4F90 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x1AB4DB0 Offset: 0x1AB37B0 VA: 0x181AB4DB0 Slot: 13
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_MustFlush() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x4930D0 Offset: 0x491AD0 VA: 0x1804930D0
	internal void ClearMustFlush() { }
}
