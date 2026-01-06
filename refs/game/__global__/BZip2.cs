internal static class BZip2 // TypeDefIndex: 16638
{
	// Fields
	public static readonly int BlockSizeMultiple; // 0x0
	public static readonly int MinBlockSize; // 0x4
	public static readonly int MaxBlockSize; // 0x8
	public static readonly int MaxAlphaSize; // 0xC
	public static readonly int MaxCodeLength; // 0x10
	public static readonly char RUNA; // 0x14
	public static readonly char RUNB; // 0x16
	public static readonly int NGroups; // 0x18
	public static readonly int G_SIZE; // 0x1C
	public static readonly int N_ITERS; // 0x20
	public static readonly int MaxSelectors; // 0x24
	public static readonly int NUM_OVERSHOOT_BYTES; // 0x28
	internal static readonly int QSORT_STACK_SIZE; // 0x2C

	// Methods

	// RVA: 0x1E60B10 Offset: 0x1E5F510 VA: 0x181E60B10
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static T[][] InitRectangularArray<T>(int d1, int d2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58290 Offset: 0xE56C90 VA: 0x180E58290
	|-BZip2.InitRectangularArray<byte>
	|-BZip2.InitRectangularArray<char>
	|-BZip2.InitRectangularArray<int>
	|
	|-RVA: 0xE58370 Offset: 0xE56D70 VA: 0x180E58370
	|-BZip2.InitRectangularArray<__Il2CppFullySharedGenericType>
	*/
}
