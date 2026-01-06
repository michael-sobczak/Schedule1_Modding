public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple // TypeDefIndex: 3755
{
	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: 0x1C94E90 Offset: 0x1C93890 VA: 0x181C94E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x1C95000 Offset: 0x1C93A00 VA: 0x181C95000 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x1C95050 Offset: 0x1C93A50 VA: 0x181C95050 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x1C94EE0 Offset: 0x1C938E0 VA: 0x181C94EE0 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x1C951A0 Offset: 0x1C93BA0 VA: 0x181C951A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C95170 Offset: 0x1C93B70 VA: 0x181C95170 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }

	// RVA: 0x1C94590 Offset: 0x1C92F90 VA: 0x181C94590
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x1C94BC0 Offset: 0x1C935C0 VA: 0x181C94BC0
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	// RVA: 0x1C94AB0 Offset: 0x1C934B0 VA: 0x181C94AB0
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	// RVA: 0x1C94600 Offset: 0x1C93000 VA: 0x181C94600
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	// RVA: 0x1C94750 Offset: 0x1C93150 VA: 0x181C94750
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	// RVA: 0x1C948E0 Offset: 0x1C932E0 VA: 0x181C948E0
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	// RVA: 0x1C94C80 Offset: 0x1C93680 VA: 0x181C94C80
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }
}
