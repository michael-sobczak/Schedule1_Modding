internal struct IntersectionCompare : IComparer<int2> // TypeDefIndex: 9190
{
	// Fields
	public NativeArray<double2> points; // 0x0
	public NativeArray<int2> edges; // 0x10
	[FixedBuffer(typeof(double), 4)]
	public IntersectionCompare.<xvasort>e__FixedBuffer xvasort; // 0x20
	[FixedBuffer(typeof(double), 4)]
	public IntersectionCompare.<xvbsort>e__FixedBuffer xvbsort; // 0x40

	// Methods

	// RVA: 0x2B76840 Offset: 0x2B75240 VA: 0x182B76840 Slot: 4
	public int Compare(int2 a, int2 b) { }
}
