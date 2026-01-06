internal class RangeManager // TypeDefIndex: 4034
{
	// Fields
	internal readonly IndexRange[] _indexRanges; // 0x10
	internal readonly bool _use32BitCurrentIndex; // 0x18
	internal int _nCurrentIndexRangeToAssign; // 0x1C
	internal long _nStep; // 0x20

	// Methods

	// RVA: 0x1CF33C0 Offset: 0x1CF1DC0 VA: 0x181CF33C0
	internal void .ctor(long nFromInclusive, long nToExclusive, long nStep, int nNumExpectedWorkers) { }

	// RVA: 0x1CF3320 Offset: 0x1CF1D20 VA: 0x181CF3320
	internal RangeWorker RegisterNewWorker() { }
}
