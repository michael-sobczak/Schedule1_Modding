internal class SortKeyBuffer // TypeDefIndex: 3507
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor(int lcid) { }

	// RVA: 0x1A98290 Offset: 0x1A96C90 VA: 0x181A98290
	public void Reset() { }

	// RVA: 0x1A98090 Offset: 0x1A96A90 VA: 0x181A98090
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x1A97500 Offset: 0x1A95F00 VA: 0x181A97500
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x1A975D0 Offset: 0x1A95FD0 VA: 0x181A975D0
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x1A97780 Offset: 0x1A96180 VA: 0x181A97780
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x1A976A0 Offset: 0x1A960A0 VA: 0x181A976A0
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x1A97440 Offset: 0x1A95E40 VA: 0x181A97440
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x1A979C0 Offset: 0x1A963C0 VA: 0x181A979C0
	public SortKey GetResultAndReset() { }

	// RVA: 0x1A97970 Offset: 0x1A96370 VA: 0x181A97970
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x1A979F0 Offset: 0x1A963F0 VA: 0x181A979F0
	public SortKey GetResult() { }
}
