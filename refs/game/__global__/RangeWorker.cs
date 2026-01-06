internal struct RangeWorker // TypeDefIndex: 4033
{
	// Fields
	internal readonly IndexRange[] _indexRanges; // 0x0
	internal int _nCurrentIndexRange; // 0x8
	internal long _nStep; // 0x10
	internal long _nIncrementValue; // 0x18
	internal readonly long _nMaxIncrementValue; // 0x20
	internal readonly bool _use32BitCurrentIndex; // 0x28

	// Properties
	internal bool IsInitialized { get; }

	// Methods

	// RVA: 0x1CD57E0 Offset: 0x1CD41E0 VA: 0x181CD57E0
	internal bool get_IsInitialized() { }

	// RVA: 0x1CF3890 Offset: 0x1CF2290 VA: 0x181CF3890
	internal void .ctor(IndexRange[] ranges, int nInitialRange, long nStep, bool use32BitCurrentIndex) { }

	// RVA: 0x1CF35E0 Offset: 0x1CF1FE0 VA: 0x181CF35E0
	internal bool FindNewWork(out long nFromInclusiveLocal, out long nToExclusiveLocal) { }

	// RVA: 0x1CF3590 Offset: 0x1CF1F90 VA: 0x181CF3590
	internal bool FindNewWork32(out int nFromInclusiveLocal32, out int nToExclusiveLocal32) { }
}
