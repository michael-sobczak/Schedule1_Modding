internal sealed class BitHelper // TypeDefIndex: 15660
{
	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x20012F0 Offset: 0x1FFFCF0 VA: 0x1820012F0
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2001330 Offset: 0x1FFFD30 VA: 0x182001330
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x2001260 Offset: 0x1FFFC60 VA: 0x182001260
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x20011E0 Offset: 0x1FFFBE0 VA: 0x1820011E0
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x20012D0 Offset: 0x1FFFCD0 VA: 0x1820012D0
	internal static int ToIntArrayLength(int n) { }
}
