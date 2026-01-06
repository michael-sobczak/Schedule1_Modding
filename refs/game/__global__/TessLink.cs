internal struct TessLink // TypeDefIndex: 9196
{
	// Fields
	internal NativeArray<int> roots; // 0x0
	internal NativeArray<int> ranks; // 0x10

	// Methods

	// RVA: 0x2A97EA0 Offset: 0x2A968A0 VA: 0x182A97EA0
	internal static TessLink CreateLink(int count, Allocator allocator) { }

	// RVA: 0x2A97F80 Offset: 0x2A96980 VA: 0x182A97F80
	internal static void DestroyLink(TessLink link) { }

	// RVA: 0x2A97FD0 Offset: 0x2A969D0 VA: 0x182A97FD0
	internal int Find(int x) { }

	// RVA: 0x2A98030 Offset: 0x2A96A30 VA: 0x182A98030
	internal void Link(int x, int y) { }
}
