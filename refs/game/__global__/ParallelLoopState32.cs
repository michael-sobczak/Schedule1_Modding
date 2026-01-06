internal class ParallelLoopState32 : ParallelLoopState // TypeDefIndex: 4028
{
	// Fields
	private readonly ParallelLoopStateFlags32 _sharedParallelStateFlags; // 0x18
	private int _currentIteration; // 0x20

	// Properties
	internal int CurrentIteration { set; }

	// Methods

	// RVA: 0x1CF1F60 Offset: 0x1CF0960 VA: 0x181CF1F60
	internal void .ctor(ParallelLoopStateFlags32 sharedParallelStateFlags) { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	internal void set_CurrentIteration(int value) { }
}
