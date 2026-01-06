internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 7911
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	internal void .ctor() { }

	// RVA: 0x23AFBA0 Offset: 0x23AE5A0 VA: 0x1823AFBA0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void set_StartOffset(int value) { }

	// RVA: 0x23AFC60 Offset: 0x23AE660 VA: 0x1823AFC60
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x23AFB40 Offset: 0x23AE540 VA: 0x1823AFB40
	internal bool CanReplaceAt(int index) { }
}
