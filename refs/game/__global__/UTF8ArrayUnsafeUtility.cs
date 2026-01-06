public static class UTF8ArrayUnsafeUtility // TypeDefIndex: 15916
{
	// Methods

	// RVA: 0x273D0B0 Offset: 0x273BAB0 VA: 0x18273D0B0
	public static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	// RVA: 0x273D2F0 Offset: 0x273BCF0 VA: 0x18273D2F0
	public static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	// RVA: 0x273D210 Offset: 0x273BC10 VA: 0x18273D210
	public static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, byte* src, int srcLength) { }

	// RVA: 0x273D130 Offset: 0x273BB30 VA: 0x18273D130
	public static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength) { }

	// RVA: 0x273D0F0 Offset: 0x273BAF0 VA: 0x18273D0F0
	public static CopyError Copy(char* dest, out int destLength, int destUCS2MaxLengthInChars, byte* src, int srcLength) { }

	// RVA: 0x273D350 Offset: 0x273BD50 VA: 0x18273D350
	public static CopyError Copy(char* dest, out ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength) { }

	// RVA: 0x273CEA0 Offset: 0x273B8A0 VA: 0x18273CEA0
	public static FormatError AppendUTF8Bytes(byte* dest, ref int destLength, int destCapacity, byte* src, int srcLength) { }

	// RVA: 0x273CFC0 Offset: 0x273B9C0 VA: 0x18273CFC0
	public static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength) { }

	// RVA: 0x273CF00 Offset: 0x273B900 VA: 0x18273CF00
	public static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	// RVA: 0x273CF60 Offset: 0x273B960 VA: 0x18273CF60
	public static CopyError Append(char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength) { }

	// RVA: 0x273D880 Offset: 0x273C280 VA: 0x18273D880
	public static int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB) { }

	// RVA: 0x273D6E0 Offset: 0x273C0E0 VA: 0x18273D6E0
	public static int StrCmp(char* utf16BufferA, int utf16LengthInCharsA, char* utf16BufferB, int utf16LengthInCharsB) { }

	// RVA: 0x273D3B0 Offset: 0x273BDB0 VA: 0x18273D3B0
	public static bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength) { }

	// RVA: 0x273D5A0 Offset: 0x273BFA0 VA: 0x18273D5A0
	public static int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars) { }

	// RVA: 0x273D460 Offset: 0x273BE60 VA: 0x18273D460
	public static int StrCmp(char* utf16Buffer, int utf16LengthInChars, byte* utf8Buffer, int utf8LengthInBytes) { }
}
