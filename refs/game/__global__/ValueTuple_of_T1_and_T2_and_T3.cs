public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple // TypeDefIndex: 3758
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x527620 Offset: 0x526020 VA: 0x180527620
	|-ValueTuple<int, int, Int32Enum>..ctor
	|
	|-RVA: 0x1333E80 Offset: 0x1332880 VA: 0x181333E80
	|-ValueTuple<Int32Enum, Int32Enum, object>..ctor
	|
	|-RVA: 0x105E790 Offset: 0x105D190 VA: 0x18105E790
	|-ValueTuple<object, int, int>..ctor
	|
	|-RVA: 0x133AD70 Offset: 0x1339770 VA: 0x18133AD70
	|-ValueTuple<object, object, int>..ctor
	|
	|-RVA: 0xB0FAD0 Offset: 0xB0E4D0 VA: 0x180B0FAD0
	|-ValueTuple<object, object, object>..ctor
	|
	|-RVA: 0x133AD50 Offset: 0x1339750 VA: 0x18133AD50
	|-ValueTuple<Vector4, Vector4, Vector4>..ctor
	|
	|-RVA: 0x133ADC0 Offset: 0x13397C0 VA: 0x18133ADC0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13310E0 Offset: 0x132FAE0 VA: 0x1813310E0
	|-ValueTuple<int, int, Int32Enum>.Equals
	|
	|-RVA: 0x1331330 Offset: 0x132FD30 VA: 0x181331330
	|-ValueTuple<Int32Enum, Int32Enum, object>.Equals
	|
	|-RVA: 0x1331450 Offset: 0x132FE50 VA: 0x181331450
	|-ValueTuple<object, int, int>.Equals
	|
	|-RVA: 0x13353C0 Offset: 0x1333DC0 VA: 0x1813353C0
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x1335290 Offset: 0x1333C90 VA: 0x181335290
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x13354F0 Offset: 0x1333EF0 VA: 0x1813354F0
	|-ValueTuple<Vector4, Vector4, Vector4>.Equals
	|
	|-RVA: 0x1334FE0 Offset: 0x13339E0 VA: 0x181334FE0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1330FB0 Offset: 0x132F9B0 VA: 0x181330FB0
	|-ValueTuple<int, int, Int32Enum>.Equals
	|
	|-RVA: 0x1331200 Offset: 0x132FC00 VA: 0x181331200
	|-ValueTuple<Int32Enum, Int32Enum, object>.Equals
	|
	|-RVA: 0x1331570 Offset: 0x132FF70 VA: 0x181331570
	|-ValueTuple<object, int, int>.Equals
	|
	|-RVA: 0x1335770 Offset: 0x1334170 VA: 0x181335770
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x1335620 Offset: 0x1334020 VA: 0x181335620
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x1335120 Offset: 0x1333B20 VA: 0x181335120
	|-ValueTuple<Vector4, Vector4, Vector4>.Equals
	|
	|-RVA: 0x1334960 Offset: 0x1333360 VA: 0x181334960
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13327B0 Offset: 0x13311B0 VA: 0x1813327B0
	|-ValueTuple<int, int, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1332A50 Offset: 0x1331450 VA: 0x181332A50
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1332560 Offset: 0x1330F60 VA: 0x181332560
	|-ValueTuple<object, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x13383B0 Offset: 0x1336DB0 VA: 0x1813383B0
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1337C00 Offset: 0x1336600 VA: 0x181337C00
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1337940 Offset: 0x1336340 VA: 0x181337940
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1337D90 Offset: 0x1336790 VA: 0x181337D90
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1332D90 Offset: 0x1331790 VA: 0x181332D90
	|-ValueTuple<int, int, Int32Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x1332F70 Offset: 0x1331970 VA: 0x181332F70
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x1333140 Offset: 0x1331B40 VA: 0x181333140
	|-ValueTuple<object, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x1338730 Offset: 0x1337130 VA: 0x181338730
	|-ValueTuple<object, object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x1338B20 Offset: 0x1337520 VA: 0x181338B20
	|-ValueTuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x1338920 Offset: 0x1337320 VA: 0x181338920
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IComparable.CompareTo
	|
	|-RVA: 0x1338D10 Offset: 0x1337710 VA: 0x181338D10
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1330C50 Offset: 0x132F650 VA: 0x181330C50
	|-ValueTuple<int, int, Int32Enum>.CompareTo
	|
	|-RVA: 0x1330E90 Offset: 0x132F890 VA: 0x181330E90
	|-ValueTuple<Int32Enum, Int32Enum, object>.CompareTo
	|
	|-RVA: 0x1330D70 Offset: 0x132F770 VA: 0x181330D70
	|-ValueTuple<object, int, int>.CompareTo
	|
	|-RVA: 0x1334690 Offset: 0x1333090 VA: 0x181334690
	|-ValueTuple<object, object, int>.CompareTo
	|
	|-RVA: 0x1333EA0 Offset: 0x13328A0 VA: 0x181333EA0
	|-ValueTuple<object, object, object>.CompareTo
	|
	|-RVA: 0x13347F0 Offset: 0x13331F0 VA: 0x1813347F0
	|-ValueTuple<Vector4, Vector4, Vector4>.CompareTo
	|
	|-RVA: 0x1334000 Offset: 0x1332A00 VA: 0x181334000
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1331BF0 Offset: 0x13305F0 VA: 0x181331BF0
	|-ValueTuple<int, int, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1331F60 Offset: 0x1330960 VA: 0x181331F60
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1332260 Offset: 0x1330C60 VA: 0x181332260
	|-ValueTuple<object, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1337430 Offset: 0x1335E30 VA: 0x181337430
	|-ValueTuple<object, object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13376F0 Offset: 0x13360F0 VA: 0x1813376F0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1337090 Offset: 0x1335A90 VA: 0x181337090
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x13369B0 Offset: 0x13353B0 VA: 0x1813369B0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1331A20 Offset: 0x1330420 VA: 0x181331A20
	|-ValueTuple<int, int, Int32Enum>.GetHashCode
	|
	|-RVA: 0x1331B80 Offset: 0x1330580 VA: 0x181331B80
	|-ValueTuple<Int32Enum, Int32Enum, object>.GetHashCode
	|
	|-RVA: 0x1331AC0 Offset: 0x13304C0 VA: 0x181331AC0
	|-ValueTuple<object, int, int>.GetHashCode
	|
	|-RVA: 0x1335F50 Offset: 0x1334950 VA: 0x181335F50
	|-ValueTuple<object, object, int>.GetHashCode
	|
	|-RVA: 0x1335EB0 Offset: 0x13348B0 VA: 0x181335EB0
	|-ValueTuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x1336000 Offset: 0x1334A00 VA: 0x181336000
	|-ValueTuple<Vector4, Vector4, Vector4>.GetHashCode
	|
	|-RVA: 0x13360D0 Offset: 0x1334AD0 VA: 0x1813360D0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1332CF0 Offset: 0x13316F0 VA: 0x181332CF0
	|-ValueTuple<int, int, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1332D40 Offset: 0x1331740 VA: 0x181332D40
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1332CA0 Offset: 0x13316A0 VA: 0x181332CA0
	|-ValueTuple<object, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1338690 Offset: 0x1337090 VA: 0x181338690
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x13385B0 Offset: 0x1336FB0 VA: 0x1813385B0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x13386E0 Offset: 0x13370E0 VA: 0x1813386E0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1338600 Offset: 0x1337000 VA: 0x181338600
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13318D0 Offset: 0x13302D0 VA: 0x1813318D0
	|-ValueTuple<int, int, Int32Enum>.GetHashCodeCore
	|
	|-RVA: 0x13316A0 Offset: 0x13300A0 VA: 0x1813316A0
	|-ValueTuple<Int32Enum, Int32Enum, object>.GetHashCodeCore
	|
	|-RVA: 0x13317B0 Offset: 0x13301B0 VA: 0x1813317B0
	|-ValueTuple<object, int, int>.GetHashCodeCore
	|
	|-RVA: 0x1335BA0 Offset: 0x13345A0 VA: 0x181335BA0
	|-ValueTuple<object, object, int>.GetHashCodeCore
	|
	|-RVA: 0x1335C90 Offset: 0x1334690 VA: 0x181335C90
	|-ValueTuple<object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x1335D50 Offset: 0x1334750 VA: 0x181335D50
	|-ValueTuple<Vector4, Vector4, Vector4>.GetHashCodeCore
	|
	|-RVA: 0x13358C0 Offset: 0x13342C0 VA: 0x1813358C0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1332CF0 Offset: 0x13316F0 VA: 0x181332CF0
	|-ValueTuple<int, int, Int32Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x1332D40 Offset: 0x1331740 VA: 0x181332D40
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x1332CA0 Offset: 0x13316A0 VA: 0x181332CA0
	|-ValueTuple<object, int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x1338690 Offset: 0x1337090 VA: 0x181338690
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x13385B0 Offset: 0x1336FB0 VA: 0x1813385B0
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x13386E0 Offset: 0x13370E0 VA: 0x1813386E0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x1338600 Offset: 0x1337000 VA: 0x181338600
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1333890 Offset: 0x1332290 VA: 0x181333890
	|-ValueTuple<int, int, Int32Enum>.ToString
	|
	|-RVA: 0x1333A90 Offset: 0x1332490 VA: 0x181333A90
	|-ValueTuple<Int32Enum, Int32Enum, object>.ToString
	|
	|-RVA: 0x1333CB0 Offset: 0x13326B0 VA: 0x181333CB0
	|-ValueTuple<object, int, int>.ToString
	|
	|-RVA: 0x133AB80 Offset: 0x1339580 VA: 0x18133AB80
	|-ValueTuple<object, object, int>.ToString
	|
	|-RVA: 0x133A810 Offset: 0x1339210 VA: 0x18133A810
	|-ValueTuple<object, object, object>.ToString
	|
	|-RVA: 0x133A9C0 Offset: 0x13393C0 VA: 0x18133A9C0
	|-ValueTuple<Vector4, Vector4, Vector4>.ToString
	|
	|-RVA: 0x1339E10 Offset: 0x1338810 VA: 0x181339E10
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1333310 Offset: 0x1331D10 VA: 0x181333310
	|-ValueTuple<int, int, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x13336A0 Offset: 0x13320A0 VA: 0x1813336A0
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x13334F0 Offset: 0x1331EF0 VA: 0x1813334F0
	|-ValueTuple<object, int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x13390F0 Offset: 0x1337AF0 VA: 0x1813390F0
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x1338F60 Offset: 0x1337960 VA: 0x181338F60
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x13392A0 Offset: 0x1337CA0 VA: 0x1813392A0
	|-ValueTuple<Vector4, Vector4, Vector4>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x1339430 Offset: 0x1337E30 VA: 0x181339430
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x583670 Offset: 0x582070 VA: 0x180583670
	|-ValueTuple<int, int, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Int32Enum, Int32Enum, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<Vector4, Vector4, Vector4>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
