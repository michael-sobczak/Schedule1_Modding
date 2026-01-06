public struct UnsafeHashMapBucketData // TypeDefIndex: 15977
{
	// Fields
	public readonly byte* values; // 0x0
	public readonly byte* keys; // 0x8
	public readonly byte* next; // 0x10
	public readonly byte* buckets; // 0x18
	public readonly int bucketCapacityMask; // 0x20

	// Methods

	// RVA: 0x273FFC0 Offset: 0x273E9C0 VA: 0x18273FFC0
	internal void .ctor(byte* v, byte* k, byte* n, byte* b, int bcm) { }
}
