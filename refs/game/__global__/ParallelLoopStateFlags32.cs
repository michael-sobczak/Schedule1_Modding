internal class ParallelLoopStateFlags32 : ParallelLoopStateFlags // TypeDefIndex: 4030
{
	// Fields
	internal int _lowestBreakIteration; // 0x18

	// Properties
	internal int LowestBreakIteration { get; }

	// Methods

	// RVA: 0x1CF2080 Offset: 0x1CF0A80 VA: 0x181CF2080
	internal int get_LowestBreakIteration() { }

	// RVA: 0x1CF1FB0 Offset: 0x1CF09B0 VA: 0x181CF1FB0
	internal bool ShouldExitLoop(int CallerIteration) { }

	// RVA: 0x1CF2020 Offset: 0x1CF0A20 VA: 0x181CF2020
	internal bool ShouldExitLoop() { }

	// RVA: 0x1CF2050 Offset: 0x1CF0A50 VA: 0x181CF2050
	public void .ctor() { }
}
