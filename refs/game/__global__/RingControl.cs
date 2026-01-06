internal struct RingControl // TypeDefIndex: 16001
{
	// Fields
	internal readonly int Capacity; // 0x0
	internal int Current; // 0x4
	internal int Write; // 0x8
	internal int Read; // 0xC

	// Properties
	internal int Length { get; }

	// Methods

	// RVA: 0x273B410 Offset: 0x2739E10 VA: 0x18273B410
	internal void .ctor(int capacity) { }

	// RVA: 0x273B400 Offset: 0x2739E00 VA: 0x18273B400
	internal void Reset() { }

	// RVA: 0x273B390 Offset: 0x2739D90 VA: 0x18273B390
	internal int Distance(int from, int to) { }

	// RVA: 0x273B2D0 Offset: 0x2739CD0 VA: 0x18273B2D0
	internal int Available() { }

	// RVA: 0x273B3B0 Offset: 0x2739DB0 VA: 0x18273B3B0
	internal int Reserve(int count) { }

	// RVA: 0x273B2F0 Offset: 0x2739CF0 VA: 0x18273B2F0
	internal int Commit(int count) { }

	// RVA: 0x273B340 Offset: 0x2739D40 VA: 0x18273B340
	internal int Consume(int count) { }

	// RVA: 0x273B420 Offset: 0x2739E20 VA: 0x18273B420
	internal int get_Length() { }
}
