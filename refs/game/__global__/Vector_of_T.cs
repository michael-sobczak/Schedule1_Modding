public struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 4788
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> s_zero; // 0x0
	private static readonly Vector<T> s_one; // 0x0
	private static readonly Vector<T> s_allOnes; // 0x0

	// Properties
	public static int Count { get; }
	public static Vector<T> Zero { get; }
	public T Item { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13AA440 Offset: 0x13A8E40 VA: 0x1813AA440
	|-Vector<ushort>.get_Count
	|-Vector<ulong>.get_Count
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13ABB80 Offset: 0x13AA580 VA: 0x1813ABB80
	|-Vector<ushort>.get_Zero
	|-Vector<ulong>.get_Zero
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139FC10 Offset: 0x139E610 VA: 0x18139FC10
	|-Vector<ushort>.InitializeCount
	|
	|-RVA: 0x13A0130 Offset: 0x139EB30 VA: 0x1813A0130
	|-Vector<ulong>.InitializeCount
	|
	|-RVA: 0x13B30F0 Offset: 0x13B1AF0 VA: 0x1813B30F0
	|-Vector<__Il2CppFullySharedGenericStructType>.InitializeCount
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A7650 Offset: 0x13A6050 VA: 0x1813A7650
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x13A2F40 Offset: 0x13A1940 VA: 0x1813A2F40
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x13B4E90 Offset: 0x13B3890 VA: 0x1813B4E90
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A5CF0 Offset: 0x13A46F0 VA: 0x1813A5CF0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x13A75B0 Offset: 0x13A5FB0 VA: 0x1813A75B0
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x13B8E30 Offset: 0x13B7830 VA: 0x1813B8E30
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A5D90 Offset: 0x13A4790 VA: 0x1813A5D90
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x13A69A0 Offset: 0x13A53A0 VA: 0x1813A69A0
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x13B8230 Offset: 0x13B6C30 VA: 0x1813B8230
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944D0 Offset: 0x492ED0 VA: 0x1804944D0
	|-Vector<ushort>..ctor
	|-Vector<ulong>..ctor
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13AA4E0 Offset: 0x13A8EE0 VA: 0x1813AA4E0
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0x13AB030 Offset: 0x13A9A30 VA: 0x1813AB030
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0x13B8F00 Offset: 0x13B7900 VA: 0x1813B8F00
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13881F0 Offset: 0x1386BF0 VA: 0x1813881F0
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x1388350 Offset: 0x1386D50 VA: 0x181388350
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x13AC000 Offset: 0x13AAA00 VA: 0x1813AC000
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397E90 Offset: 0x1396890 VA: 0x181397E90
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x13986C0 Offset: 0x13970C0 VA: 0x1813986C0
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x13AED70 Offset: 0x13AD770 VA: 0x1813AED70
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139A3B0 Offset: 0x1398DB0 VA: 0x18139A3B0
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0x139C580 Offset: 0x139AF80 VA: 0x18139C580
	|-Vector<ulong>.GetHashCode
	|
	|-RVA: 0x13B0190 Offset: 0x13AEB90 VA: 0x1813B0190
	|-Vector<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2180 Offset: 0x13A0B80 VA: 0x1813A2180
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x13A2260 Offset: 0x13A0C60 VA: 0x1813A2260
	|-Vector<ulong>.ToString
	|
	|-RVA: 0x13B44C0 Offset: 0x13B2EC0 VA: 0x1813B44C0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2740 Offset: 0x13A1140 VA: 0x1813A2740
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x13A2340 Offset: 0x13A0D40 VA: 0x1813A2340
	|-Vector<ulong>.ToString
	|
	|-RVA: 0x13B45D0 Offset: 0x13B2FD0 VA: 0x1813B45D0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13ABC20 Offset: 0x13AA620 VA: 0x1813ABC20
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0x13ABCC0 Offset: 0x13AA6C0 VA: 0x1813ABCC0
	|-Vector<ulong>.op_Equality
	|
	|-RVA: 0x13B9AB0 Offset: 0x13B84B0 VA: 0x1813B9AB0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13ABDE0 Offset: 0x13AA7E0 VA: 0x1813ABDE0
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0x13ABEF0 Offset: 0x13AA8F0 VA: 0x1813ABEF0
	|-Vector<ulong>.op_Inequality
	|
	|-RVA: 0x13B9BE0 Offset: 0x13B85E0 VA: 0x1813B9BE0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	[Intrinsic]
	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13ABD60 Offset: 0x13AA760 VA: 0x1813ABD60
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0x13ABDA0 Offset: 0x13AA7A0 VA: 0x1813ABDA0
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0x13B9B80 Offset: 0x13B8580 VA: 0x1813B9B80
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1395B40 Offset: 0x1394540 VA: 0x181395B40
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x1393800 Offset: 0x1392200 VA: 0x181393800
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x13AC190 Offset: 0x13AAB90 VA: 0x1813AC190
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A0650 Offset: 0x139F050 VA: 0x1813A0650
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0x13A13F0 Offset: 0x139FDF0 VA: 0x1813A13F0
	|-Vector<ulong>.ScalarEquals
	|
	|-RVA: 0x13B3610 Offset: 0x13B2010 VA: 0x1813B3610
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139E750 Offset: 0x139D150 VA: 0x18139E750
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0x139F1B0 Offset: 0x139DBB0 VA: 0x18139F1B0
	|-Vector<ulong>.GetOneValue
	|
	|-RVA: 0x13B2650 Offset: 0x13B1050 VA: 0x1813B2650
	|-Vector<__Il2CppFullySharedGenericStructType>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398EF0 Offset: 0x13978F0 VA: 0x181398EF0
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0x1399950 Offset: 0x1398350 VA: 0x181399950
	|-Vector<ulong>.GetAllBitsSetValue
	|
	|-RVA: 0x13AF6E0 Offset: 0x13AE0E0 VA: 0x1813AF6E0
	|-Vector<__Il2CppFullySharedGenericStructType>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2D40 Offset: 0x13A1740 VA: 0x1813A2D40
	|-Vector<ushort>..cctor
	|
	|-RVA: 0x13A2B40 Offset: 0x13A1540 VA: 0x1813A2B40
	|-Vector<ulong>..cctor
	|
	|-RVA: 0x13B4B20 Offset: 0x13B3520 VA: 0x1813B4B20
	|-Vector<__Il2CppFullySharedGenericStructType>..cctor
	*/
}
