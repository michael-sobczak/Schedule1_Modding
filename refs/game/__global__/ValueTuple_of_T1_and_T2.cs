public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple // TypeDefIndex: 3757
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1330B80 Offset: 0x132F580 VA: 0x181330B80
	|-ValueTuple<bool, object>..ctor
	|
	|-RVA: 0x1330B60 Offset: 0x132F560 VA: 0x181330B60
	|-ValueTuple<int, bool>..ctor
	|
	|-RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	|-ValueTuple<int, int>..ctor
	|-ValueTuple<int, Scene>..ctor
	|-ValueTuple<uint, uint>..ctor
	|
	|-RVA: 0x1330B50 Offset: 0x132F550 VA: 0x181330B50
	|-ValueTuple<int, IntPtr>..ctor
	|
	|-RVA: 0xD59F60 Offset: 0xD58960 VA: 0x180D59F60
	|-ValueTuple<int, object>..ctor
	|-ValueTuple<Int32Enum, object>..ctor
	|
	|-RVA: 0x1330BC0 Offset: 0x132F5C0 VA: 0x181330BC0
	|-ValueTuple<int, Vector2Int>..ctor
	|-ValueTuple<Int32Enum, Vector2>..ctor
	|
	|-RVA: 0x1330BA0 Offset: 0x132F5A0 VA: 0x181330BA0
	|-ValueTuple<IntPtr, object>..ctor
	|
	|-RVA: 0x1330C10 Offset: 0x132F610 VA: 0x181330C10
	|-ValueTuple<object, ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x1330BD0 Offset: 0x132F5D0 VA: 0x181330BD0
	|-ValueTuple<object, bool>..ctor
	|
	|-RVA: 0xD900B0 Offset: 0xD8EAB0 VA: 0x180D900B0
	|-ValueTuple<object, int>..ctor
	|
	|-RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	|-ValueTuple<object, object>..ctor
	|
	|-RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	|-ValueTuple<float, float>..ctor
	|
	|-RVA: 0xD3EC80 Offset: 0xD3D680 VA: 0x180D3EC80
	|-ValueTuple<Vector3, Quaternion>..ctor
	|
	|-RVA: 0x1330C00 Offset: 0x132F600 VA: 0x181330C00
	|-ValueTuple<Vector4, Vector2Int>..ctor
	|
	|-RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	|-ValueTuple<Vector4, Vector4>..ctor
	|
	|-RVA: 0x10EFFD0 Offset: 0x10EE9D0 VA: 0x1810EFFD0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320650 Offset: 0x131F050 VA: 0x181320650
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x1320040 Offset: 0x131EA40 VA: 0x181320040
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x131F3F0 Offset: 0x131DDF0 VA: 0x18131F3F0
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x131FBE0 Offset: 0x131E5E0 VA: 0x18131FBE0
	|-ValueTuple<int, IntPtr>.Equals
	|
	|-RVA: 0x131F2D0 Offset: 0x131DCD0 VA: 0x18131F2D0
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x131FE20 Offset: 0x131E820 VA: 0x18131FE20
	|-ValueTuple<int, Scene>.Equals
	|
	|-RVA: 0x1320FA0 Offset: 0x131F9A0 VA: 0x181320FA0
	|-ValueTuple<int, Vector2Int>.Equals
	|
	|-RVA: 0x131FAC0 Offset: 0x131E4C0 VA: 0x18131FAC0
	|-ValueTuple<Int32Enum, object>.Equals
	|
	|-RVA: 0x1321B20 Offset: 0x1320520 VA: 0x181321B20
	|-ValueTuple<Int32Enum, Vector2>.Equals
	|
	|-RVA: 0x13209C0 Offset: 0x131F3C0 VA: 0x1813209C0
	|-ValueTuple<IntPtr, object>.Equals
	|
	|-RVA: 0x131F1A0 Offset: 0x131DBA0 VA: 0x18131F1A0
	|-ValueTuple<object, ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x131F080 Offset: 0x131DA80 VA: 0x18131F080
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x131F500 Offset: 0x131DF00 VA: 0x18131F500
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x1320530 Offset: 0x131EF30 VA: 0x181320530
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x13208A0 Offset: 0x131F2A0 VA: 0x1813208A0
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x131FF30 Offset: 0x131E930 VA: 0x18131FF30
	|-ValueTuple<uint, uint>.Equals
	|
	|-RVA: 0x1320770 Offset: 0x131F170 VA: 0x181320770
	|-ValueTuple<Vector3, Quaternion>.Equals
	|
	|-RVA: 0x1321910 Offset: 0x1320310 VA: 0x181321910
	|-ValueTuple<Vector4, Vector2Int>.Equals
	|
	|-RVA: 0x131FD00 Offset: 0x131E700 VA: 0x18131FD00
	|-ValueTuple<Vector4, Vector4>.Equals
	|
	|-RVA: 0x1320150 Offset: 0x131EB50 VA: 0x181320150
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320450 Offset: 0x131EE50 VA: 0x181320450
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x1321E00 Offset: 0x1320800 VA: 0x181321E00
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x1321D20 Offset: 0x1320720 VA: 0x181321D20
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x1321C40 Offset: 0x1320640 VA: 0x181321C40
	|-ValueTuple<int, IntPtr>.Equals
	|
	|-RVA: 0x131F9E0 Offset: 0x131E3E0 VA: 0x18131F9E0
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x1321EE0 Offset: 0x13208E0 VA: 0x181321EE0
	|-ValueTuple<int, Scene>.Equals
	|
	|-RVA: 0x131F820 Offset: 0x131E220 VA: 0x18131F820
	|-ValueTuple<int, Vector2Int>.Equals
	|
	|-RVA: 0x1321A40 Offset: 0x1320440 VA: 0x181321A40
	|-ValueTuple<Int32Enum, object>.Equals
	|
	|-RVA: 0x13211D0 Offset: 0x131FBD0 VA: 0x1813211D0
	|-ValueTuple<Int32Enum, Vector2>.Equals
	|
	|-RVA: 0x131F900 Offset: 0x131E300 VA: 0x18131F900
	|-ValueTuple<IntPtr, object>.Equals
	|
	|-RVA: 0x131F620 Offset: 0x131E020 VA: 0x18131F620
	|-ValueTuple<object, ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x13213C0 Offset: 0x131FDC0 VA: 0x1813213C0
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x1320290 Offset: 0x131EC90 VA: 0x181320290
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x1320370 Offset: 0x131ED70 VA: 0x181320370
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x1320AE0 Offset: 0x131F4E0 VA: 0x181320AE0
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x1320EC0 Offset: 0x131F8C0 VA: 0x181320EC0
	|-ValueTuple<uint, uint>.Equals
	|
	|-RVA: 0x1320BB0 Offset: 0x131F5B0 VA: 0x181320BB0
	|-ValueTuple<Vector3, Quaternion>.Equals
	|
	|-RVA: 0x131EF80 Offset: 0x131D980 VA: 0x18131EF80
	|-ValueTuple<Vector4, Vector2Int>.Equals
	|
	|-RVA: 0x13210C0 Offset: 0x131FAC0 VA: 0x1813210C0
	|-ValueTuple<Vector4, Vector4>.Equals
	|
	|-RVA: 0x13214A0 Offset: 0x131FEA0 VA: 0x1813214A0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1327B20 Offset: 0x1326520 VA: 0x181327B20
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328900 Offset: 0x1327300 VA: 0x181328900
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328CE0 Offset: 0x13276E0 VA: 0x181328CE0
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329AC0 Offset: 0x13284C0 VA: 0x181329AC0
	|-ValueTuple<int, IntPtr>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329580 Offset: 0x1327F80 VA: 0x181329580
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x132A0D0 Offset: 0x1328AD0 VA: 0x18132A0D0
	|-ValueTuple<int, Scene>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329130 Offset: 0x1327B30 VA: 0x181329130
	|-ValueTuple<int, Vector2Int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329740 Offset: 0x1328140 VA: 0x181329740
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1327F30 Offset: 0x1326930 VA: 0x181327F30
	|-ValueTuple<Int32Enum, Vector2>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329F10 Offset: 0x1328910 VA: 0x181329F10
	|-ValueTuple<IntPtr, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328730 Offset: 0x1327130 VA: 0x181328730
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328B20 Offset: 0x1327520 VA: 0x181328B20
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329900 Offset: 0x1328300 VA: 0x181329900
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328160 Offset: 0x1326B60 VA: 0x181328160
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329350 Offset: 0x1327D50 VA: 0x181329350
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x132A2F0 Offset: 0x1328CF0 VA: 0x18132A2F0
	|-ValueTuple<uint, uint>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1327CE0 Offset: 0x13266E0 VA: 0x181327CE0
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1329CE0 Offset: 0x13286E0 VA: 0x181329CE0
	|-ValueTuple<Vector4, Vector2Int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1328F00 Offset: 0x1327900 VA: 0x181328F00
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x13282B0 Offset: 0x1326CB0 VA: 0x1813282B0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132B540 Offset: 0x1329F40 VA: 0x18132B540
	|-ValueTuple<bool, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x132BAC0 Offset: 0x132A4C0 VA: 0x18132BAC0
	|-ValueTuple<int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C5B0 Offset: 0x132AFB0 VA: 0x18132C5B0
	|-ValueTuple<int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x132ABE0 Offset: 0x13295E0 VA: 0x18132ABE0
	|-ValueTuple<int, IntPtr>.System.IComparable.CompareTo
	|
	|-RVA: 0x132BE60 Offset: 0x132A860 VA: 0x18132BE60
	|-ValueTuple<int, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C780 Offset: 0x132B180 VA: 0x18132C780
	|-ValueTuple<int, Scene>.System.IComparable.CompareTo
	|
	|-RVA: 0x132B710 Offset: 0x132A110 VA: 0x18132B710
	|-ValueTuple<int, Vector2Int>.System.IComparable.CompareTo
	|
	|-RVA: 0x132BC90 Offset: 0x132A690 VA: 0x18132BC90
	|-ValueTuple<Int32Enum, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x132AF80 Offset: 0x1329980 VA: 0x18132AF80
	|-ValueTuple<Int32Enum, Vector2>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C030 Offset: 0x132AA30 VA: 0x18132C030
	|-ValueTuple<IntPtr, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x132CD70 Offset: 0x132B770 VA: 0x18132CD70
	|-ValueTuple<object, ValueTuple<object, int>>.System.IComparable.CompareTo
	|
	|-RVA: 0x132ADB0 Offset: 0x13297B0 VA: 0x18132ADB0
	|-ValueTuple<object, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x132B8F0 Offset: 0x132A2F0 VA: 0x18132B8F0
	|-ValueTuple<object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C950 Offset: 0x132B350 VA: 0x18132C950
	|-ValueTuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C200 Offset: 0x132AC00 VA: 0x18132C200
	|-ValueTuple<float, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x132C3E0 Offset: 0x132ADE0 VA: 0x18132C3E0
	|-ValueTuple<uint, uint>.System.IComparable.CompareTo
	|
	|-RVA: 0x132B350 Offset: 0x1329D50 VA: 0x18132B350
	|-ValueTuple<Vector3, Quaternion>.System.IComparable.CompareTo
	|
	|-RVA: 0x132B160 Offset: 0x1329B60 VA: 0x18132B160
	|-ValueTuple<Vector4, Vector2Int>.System.IComparable.CompareTo
	|
	|-RVA: 0x132CF60 Offset: 0x132B960 VA: 0x18132CF60
	|-ValueTuple<Vector4, Vector4>.System.IComparable.CompareTo
	|
	|-RVA: 0x132CB20 Offset: 0x132B520 VA: 0x18132CB20
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131E6F0 Offset: 0x131D0F0 VA: 0x18131E6F0
	|-ValueTuple<bool, object>.CompareTo
	|
	|-RVA: 0x131ED10 Offset: 0x131D710 VA: 0x18131ED10
	|-ValueTuple<int, bool>.CompareTo
	|
	|-RVA: 0x131DB60 Offset: 0x131C560 VA: 0x18131DB60
	|-ValueTuple<int, int>.CompareTo
	|
	|-RVA: 0x131DE00 Offset: 0x131C800 VA: 0x18131DE00
	|-ValueTuple<int, IntPtr>.CompareTo
	|
	|-RVA: 0x131EEB0 Offset: 0x131D8B0 VA: 0x18131EEB0
	|-ValueTuple<int, object>.CompareTo
	|
	|-RVA: 0x131E510 Offset: 0x131CF10 VA: 0x18131E510
	|-ValueTuple<int, Scene>.CompareTo
	|
	|-RVA: 0x131EDE0 Offset: 0x131D7E0 VA: 0x18131EDE0
	|-ValueTuple<int, Vector2Int>.CompareTo
	|
	|-RVA: 0x131E350 Offset: 0x131CD50 VA: 0x18131E350
	|-ValueTuple<Int32Enum, object>.CompareTo
	|
	|-RVA: 0x131E420 Offset: 0x131CE20 VA: 0x18131E420
	|-ValueTuple<Int32Enum, Vector2>.CompareTo
	|
	|-RVA: 0x131DFA0 Offset: 0x131C9A0 VA: 0x18131DFA0
	|-ValueTuple<IntPtr, object>.CompareTo
	|
	|-RVA: 0x131DD00 Offset: 0x131C700 VA: 0x18131DD00
	|-ValueTuple<object, ValueTuple<object, int>>.CompareTo
	|
	|-RVA: 0x131DED0 Offset: 0x131C8D0 VA: 0x18131DED0
	|-ValueTuple<object, bool>.CompareTo
	|
	|-RVA: 0x131E1B0 Offset: 0x131CBB0 VA: 0x18131E1B0
	|-ValueTuple<object, int>.CompareTo
	|
	|-RVA: 0x131DC30 Offset: 0x131C630 VA: 0x18131DC30
	|-ValueTuple<object, object>.CompareTo
	|
	|-RVA: 0x131E280 Offset: 0x131CC80 VA: 0x18131E280
	|-ValueTuple<float, float>.CompareTo
	|
	|-RVA: 0x131EC40 Offset: 0x131D640 VA: 0x18131EC40
	|-ValueTuple<uint, uint>.CompareTo
	|
	|-RVA: 0x131E070 Offset: 0x131CA70 VA: 0x18131E070
	|-ValueTuple<Vector3, Quaternion>.CompareTo
	|
	|-RVA: 0x131DA60 Offset: 0x131C460 VA: 0x18131DA60
	|-ValueTuple<Vector4, Vector2Int>.CompareTo
	|
	|-RVA: 0x131E5E0 Offset: 0x131CFE0 VA: 0x18131E5E0
	|-ValueTuple<Vector4, Vector4>.CompareTo
	|
	|-RVA: 0x131E7C0 Offset: 0x131D1C0 VA: 0x18131E7C0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13270B0 Offset: 0x1325AB0 VA: 0x1813270B0
	|-ValueTuple<bool, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1324300 Offset: 0x1322D00 VA: 0x181324300
	|-ValueTuple<int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1324D90 Offset: 0x1323790 VA: 0x181324D90
	|-ValueTuple<int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13245D0 Offset: 0x1322FD0 VA: 0x1813245D0
	|-ValueTuple<int, IntPtr>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13260F0 Offset: 0x1324AF0 VA: 0x1813260F0
	|-ValueTuple<int, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1325E20 Offset: 0x1324820 VA: 0x181325E20
	|-ValueTuple<int, Scene>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1326B00 Offset: 0x1325500 VA: 0x181326B00
	|-ValueTuple<int, Vector2Int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1324B20 Offset: 0x1323520 VA: 0x181324B20
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1325B30 Offset: 0x1324530 VA: 0x181325B30
	|-ValueTuple<Int32Enum, Vector2>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1326360 Offset: 0x1324D60 VA: 0x181326360
	|-ValueTuple<IntPtr, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13258A0 Offset: 0x13242A0 VA: 0x1813258A0
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13248B0 Offset: 0x13232B0 VA: 0x1813248B0
	|-ValueTuple<object, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1325630 Offset: 0x1324030 VA: 0x181325630
	|-ValueTuple<object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1327610 Offset: 0x1326010 VA: 0x181327610
	|-ValueTuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1325060 Offset: 0x1323A60 VA: 0x181325060
	|-ValueTuple<float, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1326DE0 Offset: 0x13257E0 VA: 0x181326DE0
	|-ValueTuple<uint, uint>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1327810 Offset: 0x1326210 VA: 0x181327810
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1327320 Offset: 0x1325D20 VA: 0x181327320
	|-ValueTuple<Vector4, Vector2Int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1325340 Offset: 0x1323D40 VA: 0x181325340
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13265D0 Offset: 0x1324FD0 VA: 0x1813265D0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13234B0 Offset: 0x1321EB0 VA: 0x1813234B0
	|-ValueTuple<bool, object>.GetHashCode
	|
	|-RVA: 0x13235E0 Offset: 0x1321FE0 VA: 0x1813235E0
	|-ValueTuple<int, bool>.GetHashCode
	|
	|-RVA: 0x1324050 Offset: 0x1322A50 VA: 0x181324050
	|-ValueTuple<int, int>.GetHashCode
	|-ValueTuple<uint, uint>.GetHashCode
	|
	|-RVA: 0x13240E0 Offset: 0x1322AE0 VA: 0x1813240E0
	|-ValueTuple<int, IntPtr>.GetHashCode
	|
	|-RVA: 0x1324170 Offset: 0x1322B70 VA: 0x181324170
	|-ValueTuple<int, object>.GetHashCode
	|-ValueTuple<IntPtr, object>.GetHashCode
	|
	|-RVA: 0x13238B0 Offset: 0x13222B0 VA: 0x1813238B0
	|-ValueTuple<int, Scene>.GetHashCode
	|
	|-RVA: 0x13237C0 Offset: 0x13221C0 VA: 0x1813237C0
	|-ValueTuple<int, Vector2Int>.GetHashCode
	|
	|-RVA: 0x1323860 Offset: 0x1322260 VA: 0x181323860
	|-ValueTuple<Int32Enum, object>.GetHashCode
	|
	|-RVA: 0x1323750 Offset: 0x1322150 VA: 0x181323750
	|-ValueTuple<Int32Enum, Vector2>.GetHashCode
	|
	|-RVA: 0x1323560 Offset: 0x1321F60 VA: 0x181323560
	|-ValueTuple<object, ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x13236A0 Offset: 0x13220A0 VA: 0x1813236A0
	|-ValueTuple<object, bool>.GetHashCode
	|
	|-RVA: 0x13241F0 Offset: 0x1322BF0 VA: 0x1813241F0
	|-ValueTuple<object, int>.GetHashCode
	|
	|-RVA: 0x1323440 Offset: 0x1321E40 VA: 0x181323440
	|-ValueTuple<object, object>.GetHashCode
	|
	|-RVA: 0x1323FC0 Offset: 0x13229C0 VA: 0x181323FC0
	|-ValueTuple<float, float>.GetHashCode
	|
	|-RVA: 0x1323360 Offset: 0x1321D60 VA: 0x181323360
	|-ValueTuple<Vector3, Quaternion>.GetHashCode
	|
	|-RVA: 0x1323F20 Offset: 0x1322920 VA: 0x181323F20
	|-ValueTuple<Vector4, Vector2Int>.GetHashCode
	|
	|-RVA: 0x1324270 Offset: 0x1322C70 VA: 0x181324270
	|-ValueTuple<Vector4, Vector4>.GetHashCode
	|
	|-RVA: 0x1323940 Offset: 0x1322340 VA: 0x181323940
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132AA10 Offset: 0x1329410 VA: 0x18132AA10
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A970 Offset: 0x1329370 VA: 0x18132A970
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A650 Offset: 0x1329050 VA: 0x18132A650
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A740 Offset: 0x1329140 VA: 0x18132A740
	|-ValueTuple<int, IntPtr>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A510 Offset: 0x1328F10 VA: 0x18132A510
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A8D0 Offset: 0x13292D0 VA: 0x18132A8D0
	|-ValueTuple<int, Scene>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A920 Offset: 0x1329320 VA: 0x18132A920
	|-ValueTuple<int, Vector2Int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A6F0 Offset: 0x13290F0 VA: 0x18132A6F0
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A5B0 Offset: 0x1328FB0 VA: 0x18132A5B0
	|-ValueTuple<Int32Enum, Vector2>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132AAB0 Offset: 0x13294B0 VA: 0x18132AAB0
	|-ValueTuple<IntPtr, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A560 Offset: 0x1328F60 VA: 0x18132A560
	|-ValueTuple<object, ValueTuple<object, int>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132AA60 Offset: 0x1329460 VA: 0x18132AA60
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A880 Offset: 0x1329280 VA: 0x18132A880
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A7E0 Offset: 0x13291E0 VA: 0x18132A7E0
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A790 Offset: 0x1329190 VA: 0x18132A790
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A600 Offset: 0x1329000 VA: 0x18132A600
	|-ValueTuple<uint, uint>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A9C0 Offset: 0x13293C0 VA: 0x18132A9C0
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132AB00 Offset: 0x1329500 VA: 0x18132AB00
	|-ValueTuple<Vector4, Vector2Int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132A6A0 Offset: 0x13290A0 VA: 0x18132A6A0
	|-ValueTuple<Vector4, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x132AB50 Offset: 0x1329550 VA: 0x18132AB50
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13230E0 Offset: 0x1321AE0 VA: 0x1813230E0
	|-ValueTuple<bool, object>.GetHashCodeCore
	|
	|-RVA: 0x1322580 Offset: 0x1320F80 VA: 0x181322580
	|-ValueTuple<int, bool>.GetHashCodeCore
	|
	|-RVA: 0x1322880 Offset: 0x1321280 VA: 0x181322880
	|-ValueTuple<int, int>.GetHashCodeCore
	|
	|-RVA: 0x1322B20 Offset: 0x1321520 VA: 0x181322B20
	|-ValueTuple<int, IntPtr>.GetHashCodeCore
	|
	|-RVA: 0x1322970 Offset: 0x1321370 VA: 0x181322970
	|-ValueTuple<int, object>.GetHashCodeCore
	|
	|-RVA: 0x1322CE0 Offset: 0x13216E0 VA: 0x181322CE0
	|-ValueTuple<int, Scene>.GetHashCodeCore
	|
	|-RVA: 0x1322A30 Offset: 0x1321430 VA: 0x181322A30
	|-ValueTuple<int, Vector2Int>.GetHashCodeCore
	|
	|-RVA: 0x1323020 Offset: 0x1321A20 VA: 0x181323020
	|-ValueTuple<Int32Enum, object>.GetHashCodeCore
	|
	|-RVA: 0x1322F30 Offset: 0x1321930 VA: 0x181322F30
	|-ValueTuple<Int32Enum, Vector2>.GetHashCodeCore
	|
	|-RVA: 0x13232A0 Offset: 0x1321CA0 VA: 0x1813232A0
	|-ValueTuple<IntPtr, object>.GetHashCodeCore
	|
	|-RVA: 0x1322DD0 Offset: 0x13217D0 VA: 0x181322DD0
	|-ValueTuple<object, ValueTuple<object, int>>.GetHashCodeCore
	|
	|-RVA: 0x13224B0 Offset: 0x1320EB0 VA: 0x1813224B0
	|-ValueTuple<object, bool>.GetHashCodeCore
	|
	|-RVA: 0x1322C10 Offset: 0x1321610 VA: 0x181322C10
	|-ValueTuple<object, int>.GetHashCodeCore
	|
	|-RVA: 0x1322EA0 Offset: 0x13218A0 VA: 0x181322EA0
	|-ValueTuple<object, object>.GetHashCodeCore
	|
	|-RVA: 0x13221A0 Offset: 0x1320BA0 VA: 0x1813221A0
	|-ValueTuple<float, float>.GetHashCodeCore
	|
	|-RVA: 0x13220B0 Offset: 0x1320AB0 VA: 0x1813220B0
	|-ValueTuple<uint, uint>.GetHashCodeCore
	|
	|-RVA: 0x13222A0 Offset: 0x1320CA0 VA: 0x1813222A0
	|-ValueTuple<Vector3, Quaternion>.GetHashCodeCore
	|
	|-RVA: 0x13223B0 Offset: 0x1320DB0 VA: 0x1813223B0
	|-ValueTuple<Vector4, Vector2Int>.GetHashCodeCore
	|
	|-RVA: 0x13231A0 Offset: 0x1321BA0 VA: 0x1813231A0
	|-ValueTuple<Vector4, Vector4>.GetHashCodeCore
	|
	|-RVA: 0x1322670 Offset: 0x1321070 VA: 0x181322670
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132AA10 Offset: 0x1329410 VA: 0x18132AA10
	|-ValueTuple<bool, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A970 Offset: 0x1329370 VA: 0x18132A970
	|-ValueTuple<int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A650 Offset: 0x1329050 VA: 0x18132A650
	|-ValueTuple<int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A740 Offset: 0x1329140 VA: 0x18132A740
	|-ValueTuple<int, IntPtr>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A510 Offset: 0x1328F10 VA: 0x18132A510
	|-ValueTuple<int, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A8D0 Offset: 0x13292D0 VA: 0x18132A8D0
	|-ValueTuple<int, Scene>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A920 Offset: 0x1329320 VA: 0x18132A920
	|-ValueTuple<int, Vector2Int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A6F0 Offset: 0x13290F0 VA: 0x18132A6F0
	|-ValueTuple<Int32Enum, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A5B0 Offset: 0x1328FB0 VA: 0x18132A5B0
	|-ValueTuple<Int32Enum, Vector2>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132AAB0 Offset: 0x13294B0 VA: 0x18132AAB0
	|-ValueTuple<IntPtr, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A560 Offset: 0x1328F60 VA: 0x18132A560
	|-ValueTuple<object, ValueTuple<object, int>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132AA60 Offset: 0x1329460 VA: 0x18132AA60
	|-ValueTuple<object, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A880 Offset: 0x1329280 VA: 0x18132A880
	|-ValueTuple<object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A7E0 Offset: 0x13291E0 VA: 0x18132A7E0
	|-ValueTuple<object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A790 Offset: 0x1329190 VA: 0x18132A790
	|-ValueTuple<float, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A600 Offset: 0x1329000 VA: 0x18132A600
	|-ValueTuple<uint, uint>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A9C0 Offset: 0x13293C0 VA: 0x18132A9C0
	|-ValueTuple<Vector3, Quaternion>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132AB00 Offset: 0x1329500 VA: 0x18132AB00
	|-ValueTuple<Vector4, Vector2Int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132A6A0 Offset: 0x13290A0 VA: 0x18132A6A0
	|-ValueTuple<Vector4, Vector4>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x132AB50 Offset: 0x1329550 VA: 0x18132AB50
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132F6B0 Offset: 0x132E0B0 VA: 0x18132F6B0
	|-ValueTuple<bool, object>.ToString
	|
	|-RVA: 0x132F200 Offset: 0x132DC00 VA: 0x18132F200
	|-ValueTuple<int, bool>.ToString
	|
	|-RVA: 0x1330420 Offset: 0x132EE20 VA: 0x181330420
	|-ValueTuple<int, int>.ToString
	|
	|-RVA: 0x132FFA0 Offset: 0x132E9A0 VA: 0x18132FFA0
	|-ValueTuple<int, IntPtr>.ToString
	|
	|-RVA: 0x1330700 Offset: 0x132F100 VA: 0x181330700
	|-ValueTuple<int, object>.ToString
	|
	|-RVA: 0x132FE00 Offset: 0x132E800 VA: 0x18132FE00
	|-ValueTuple<int, Scene>.ToString
	|
	|-RVA: 0x132F9B0 Offset: 0x132E3B0 VA: 0x18132F9B0
	|-ValueTuple<int, Vector2Int>.ToString
	|
	|-RVA: 0x132F070 Offset: 0x132DA70 VA: 0x18132F070
	|-ValueTuple<Int32Enum, object>.ToString
	|
	|-RVA: 0x1330290 Offset: 0x132EC90 VA: 0x181330290
	|-ValueTuple<Int32Enum, Vector2>.ToString
	|
	|-RVA: 0x132E810 Offset: 0x132D210 VA: 0x18132E810
	|-ValueTuple<IntPtr, object>.ToString
	|
	|-RVA: 0x132FB30 Offset: 0x132E530 VA: 0x18132FB30
	|-ValueTuple<object, ValueTuple<object, int>>.ToString
	|
	|-RVA: 0x132F520 Offset: 0x132DF20 VA: 0x18132F520
	|-ValueTuple<object, bool>.ToString
	|
	|-RVA: 0x132F840 Offset: 0x132E240 VA: 0x18132F840
	|-ValueTuple<object, int>.ToString
	|
	|-RVA: 0x13305A0 Offset: 0x132EFA0 VA: 0x1813305A0
	|-ValueTuple<object, object>.ToString
	|
	|-RVA: 0x132F3A0 Offset: 0x132DDA0 VA: 0x18132F3A0
	|-ValueTuple<float, float>.ToString
	|
	|-RVA: 0x13309D0 Offset: 0x132F3D0 VA: 0x1813309D0
	|-ValueTuple<uint, uint>.ToString
	|
	|-RVA: 0x1330870 Offset: 0x132F270 VA: 0x181330870
	|-ValueTuple<Vector3, Quaternion>.ToString
	|
	|-RVA: 0x1330120 Offset: 0x132EB20 VA: 0x181330120
	|-ValueTuple<Vector4, Vector2Int>.ToString
	|
	|-RVA: 0x132FCA0 Offset: 0x132E6A0 VA: 0x18132FCA0
	|-ValueTuple<Vector4, Vector4>.ToString
	|
	|-RVA: 0x132E980 Offset: 0x132D380 VA: 0x18132E980
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132E720 Offset: 0x132D120 VA: 0x18132E720
	|-ValueTuple<bool, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DB80 Offset: 0x132C580 VA: 0x18132DB80
	|-ValueTuple<int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E3C0 Offset: 0x132CDC0 VA: 0x18132E3C0
	|-ValueTuple<int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DF40 Offset: 0x132C940 VA: 0x18132DF40
	|-ValueTuple<int, IntPtr>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DD70 Offset: 0x132C770 VA: 0x18132DD70
	|-ValueTuple<int, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E2C0 Offset: 0x132CCC0 VA: 0x18132E2C0
	|-ValueTuple<int, Scene>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E0F0 Offset: 0x132CAF0 VA: 0x18132E0F0
	|-ValueTuple<int, Vector2Int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E1D0 Offset: 0x132CBD0 VA: 0x18132E1D0
	|-ValueTuple<Int32Enum, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DE40 Offset: 0x132C840 VA: 0x18132DE40
	|-ValueTuple<Int32Enum, Vector2>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E570 Offset: 0x132CF70 VA: 0x18132E570
	|-ValueTuple<IntPtr, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E020 Offset: 0x132CA20 VA: 0x18132E020
	|-ValueTuple<object, ValueTuple<object, int>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DC80 Offset: 0x132C680 VA: 0x18132DC80
	|-ValueTuple<object, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E4A0 Offset: 0x132CEA0 VA: 0x18132E4A0
	|-ValueTuple<object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132D770 Offset: 0x132C170 VA: 0x18132D770
	|-ValueTuple<object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132D830 Offset: 0x132C230 VA: 0x18132D830
	|-ValueTuple<float, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132E640 Offset: 0x132D040 VA: 0x18132E640
	|-ValueTuple<uint, uint>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132DAB0 Offset: 0x132C4B0 VA: 0x18132DAB0
	|-ValueTuple<Vector3, Quaternion>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132D910 Offset: 0x132C310 VA: 0x18132D910
	|-ValueTuple<Vector4, Vector2Int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132D9E0 Offset: 0x132C3E0 VA: 0x18132D9E0
	|-ValueTuple<Vector4, Vector4>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x132D140 Offset: 0x132BB40 VA: 0x18132D140
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0
	|-ValueTuple<bool, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, IntPtr>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, Scene>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<int, Vector2Int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Int32Enum, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Int32Enum, Vector2>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<IntPtr, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, ValueTuple<object, int>>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<float, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<uint, uint>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Vector3, Quaternion>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Vector4, Vector2Int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Vector4, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
