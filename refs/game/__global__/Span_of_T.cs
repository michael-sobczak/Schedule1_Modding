public struct Span<T> // TypeDefIndex: 3721
{
	// Fields
	internal readonly ByReference<T> _pointer; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public T Item { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A07B0 Offset: 0x119F1B0 VA: 0x1811A07B0
	|-Span<byte>..ctor
	|-Span<char>..ctor
	|-Span<int>..ctor
	|-Span<ushort>..ctor
	|-Span<uint>..ctor
	|-Span<jvalue>..ctor
	|
	|-RVA: 0x11E0520 Offset: 0x11DEF20 VA: 0x1811E0520
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0850 Offset: 0x119F250 VA: 0x1811A0850
	|-Span<byte>..ctor
	|
	|-RVA: 0x11A0730 Offset: 0x119F130 VA: 0x1811A0730
	|-Span<char>..ctor
	|-Span<ushort>..ctor
	|
	|-RVA: 0x11A07D0 Offset: 0x119F1D0 VA: 0x1811A07D0
	|-Span<int>..ctor
	|-Span<uint>..ctor
	|
	|-RVA: 0x11E0300 Offset: 0x11DED00 VA: 0x1811E0300
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11A08D0 Offset: 0x119F2D0 VA: 0x1811A08D0
	|-Span<jvalue>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A06E0 Offset: 0x119F0E0 VA: 0x1811A06E0
	|-Span<byte>..ctor
	|-Span<char>..ctor
	|-Span<int>..ctor
	|-Span<ushort>..ctor
	|-Span<uint>..ctor
	|-Span<jvalue>..ctor
	|
	|-RVA: 0x11E0220 Offset: 0x11DEC20 VA: 0x1811E0220
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ref T ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0D60 Offset: 0x10EF760 VA: 0x1810F0D60
	|-Span<byte>..ctor
	|-Span<char>..ctor
	|-Span<int>..ctor
	|-Span<ushort>..ctor
	|-Span<uint>..ctor
	|-Span<__Il2CppFullySharedGenericType>..ctor
	|-Span<jvalue>..ctor
	*/

	[Intrinsic]
	[NonVersionable]
	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0B20 Offset: 0x119F520 VA: 0x1811A0B20
	|-Span<byte>.get_Item
	|
	|-RVA: 0x11A0BE0 Offset: 0x119F5E0 VA: 0x1811A0BE0
	|-Span<char>.get_Item
	|-Span<ushort>.get_Item
	|
	|-RVA: 0x11A0C10 Offset: 0x119F610 VA: 0x1811A0C10
	|-Span<int>.get_Item
	|-Span<uint>.get_Item
	|
	|-RVA: 0x11E06C0 Offset: 0x11DF0C0 VA: 0x1811E06C0
	|-Span<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x11A0C40 Offset: 0x119F640 VA: 0x1811A0C40
	|-Span<jvalue>.get_Item
	*/

	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD820 Offset: 0x11DC220 VA: 0x1811DD820
	|-Span<byte>.GetPinnableReference
	|-Span<char>.GetPinnableReference
	|-Span<int>.GetPinnableReference
	|-Span<ushort>.GetPinnableReference
	|-Span<uint>.GetPinnableReference
	|-Span<__Il2CppFullySharedGenericType>.GetPinnableReference
	|-Span<jvalue>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD430 Offset: 0x11DBE30 VA: 0x1811DD430
	|-Span<byte>.Clear
	|
	|-RVA: 0x11DD3F0 Offset: 0x11DBDF0 VA: 0x1811DD3F0
	|-Span<char>.Clear
	|-Span<ushort>.Clear
	|
	|-RVA: 0x11DD410 Offset: 0x11DBE10 VA: 0x1811DD410
	|-Span<int>.Clear
	|-Span<uint>.Clear
	|
	|-RVA: 0x11DE710 Offset: 0x11DD110 VA: 0x1811DE710
	|-Span<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x11DE830 Offset: 0x11DD230 VA: 0x1811DE830
	|-Span<jvalue>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Fill(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD760 Offset: 0x11DC160 VA: 0x1811DD760
	|-Span<byte>.Fill
	|
	|-RVA: 0x11DD6B0 Offset: 0x11DC0B0 VA: 0x1811DD6B0
	|-Span<char>.Fill
	|-Span<ushort>.Fill
	|
	|-RVA: 0x11DD600 Offset: 0x11DC000 VA: 0x1811DD600
	|-Span<int>.Fill
	|
	|-RVA: 0x11DD780 Offset: 0x11DC180 VA: 0x1811DD780
	|-Span<uint>.Fill
	|
	|-RVA: 0x11DEA80 Offset: 0x11DD480 VA: 0x1811DEA80
	|-Span<__Il2CppFullySharedGenericType>.Fill
	|
	|-RVA: 0x11DE9D0 Offset: 0x11DD3D0 VA: 0x1811DE9D0
	|-Span<jvalue>.Fill
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD570 Offset: 0x11DBF70 VA: 0x1811DD570
	|-Span<byte>.CopyTo
	|
	|-RVA: 0x11DD4E0 Offset: 0x11DBEE0 VA: 0x1811DD4E0
	|-Span<char>.CopyTo
	|-Span<ushort>.CopyTo
	|
	|-RVA: 0x11DD450 Offset: 0x11DBE50 VA: 0x1811DD450
	|-Span<int>.CopyTo
	|-Span<uint>.CopyTo
	|
	|-RVA: 0x11DE8E0 Offset: 0x11DD2E0 VA: 0x1811DE8E0
	|-Span<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x11DE850 Offset: 0x11DD250 VA: 0x1811DE850
	|-Span<jvalue>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DE370 Offset: 0x11DCD70 VA: 0x1811DE370
	|-Span<byte>.TryCopyTo
	|
	|-RVA: 0x11DE250 Offset: 0x11DCC50 VA: 0x1811DE250
	|-Span<char>.TryCopyTo
	|-Span<ushort>.TryCopyTo
	|
	|-RVA: 0x11DE2E0 Offset: 0x11DCCE0 VA: 0x1811DE2E0
	|-Span<int>.TryCopyTo
	|-Span<uint>.TryCopyTo
	|
	|-RVA: 0x11E00A0 Offset: 0x11DEAA0 VA: 0x1811E00A0
	|-Span<__Il2CppFullySharedGenericType>.TryCopyTo
	|
	|-RVA: 0x11E0190 Offset: 0x11DEB90 VA: 0x1811E0190
	|-Span<jvalue>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DE400 Offset: 0x11DCE00 VA: 0x1811DE400
	|-Span<byte>.op_Implicit
	|-Span<char>.op_Implicit
	|-Span<int>.op_Implicit
	|-Span<ushort>.op_Implicit
	|-Span<uint>.op_Implicit
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	|-Span<jvalue>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DDDA0 Offset: 0x11DC7A0 VA: 0x1811DDDA0
	|-Span<byte>.ToString
	|
	|-RVA: 0x11DDA80 Offset: 0x11DC480 VA: 0x1811DDA80
	|-Span<char>.ToString
	|
	|-RVA: 0x11DDC10 Offset: 0x11DC610 VA: 0x1811DDC10
	|-Span<int>.ToString
	|
	|-RVA: 0x11DDF30 Offset: 0x11DC930 VA: 0x1811DDF30
	|-Span<ushort>.ToString
	|
	|-RVA: 0x11DE0C0 Offset: 0x11DCAC0 VA: 0x1811DE0C0
	|-Span<uint>.ToString
	|
	|-RVA: 0x11DFD80 Offset: 0x11DE780 VA: 0x1811DFD80
	|-Span<__Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0x11DFF10 Offset: 0x11DE910 VA: 0x1811DFF10
	|-Span<jvalue>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119F140 Offset: 0x119DB40 VA: 0x18119F140
	|-Span<byte>.Slice
	|
	|-RVA: 0x119EEA0 Offset: 0x119D8A0 VA: 0x18119EEA0
	|-Span<char>.Slice
	|-Span<ushort>.Slice
	|
	|-RVA: 0x119EDA0 Offset: 0x119D7A0 VA: 0x18119EDA0
	|-Span<int>.Slice
	|-Span<uint>.Slice
	|
	|-RVA: 0x11DFA10 Offset: 0x11DE410 VA: 0x1811DFA10
	|-Span<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x119ED20 Offset: 0x119D720 VA: 0x18119ED20
	|-Span<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119F1C0 Offset: 0x119DBC0 VA: 0x18119F1C0
	|-Span<byte>.Slice
	|
	|-RVA: 0x119EF20 Offset: 0x119D920 VA: 0x18119EF20
	|-Span<char>.Slice
	|-Span<ushort>.Slice
	|
	|-RVA: 0x119ECA0 Offset: 0x119D6A0 VA: 0x18119ECA0
	|-Span<int>.Slice
	|-Span<uint>.Slice
	|
	|-RVA: 0x11DF940 Offset: 0x11DE340 VA: 0x1811DF940
	|-Span<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x119EE20 Offset: 0x119D820 VA: 0x18119EE20
	|-Span<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104DD00 Offset: 0x104C700 VA: 0x18104DD00
	|-Span<byte>.ToArray
	|
	|-RVA: 0x104DBB0 Offset: 0x104C5B0 VA: 0x18104DBB0
	|-Span<char>.ToArray
	|-Span<ushort>.ToArray
	|
	|-RVA: 0x11DD830 Offset: 0x11DC230 VA: 0x1811DD830
	|-Span<int>.ToArray
	|
	|-RVA: 0x11DD930 Offset: 0x11DC330 VA: 0x1811DD930
	|-Span<uint>.ToArray
	|
	|-RVA: 0x11DFC30 Offset: 0x11DE630 VA: 0x1811DFC30
	|-Span<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x11DFAE0 Offset: 0x11DE4E0 VA: 0x1811DFAE0
	|-Span<jvalue>.ToArray
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-Span<byte>.get_Length
	|-Span<char>.get_Length
	|-Span<int>.get_Length
	|-Span<ushort>.get_Length
	|-Span<uint>.get_Length
	|-Span<__Il2CppFullySharedGenericType>.get_Length
	|-Span<jvalue>.get_Length
	*/

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119EC00 Offset: 0x119D600 VA: 0x18119EC00
	|-Span<byte>.Equals
	|-Span<char>.Equals
	|-Span<int>.Equals
	|-Span<ushort>.Equals
	|-Span<uint>.Equals
	|-Span<__Il2CppFullySharedGenericType>.Equals
	|-Span<jvalue>.Equals
	*/

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119EC50 Offset: 0x119D650 VA: 0x18119EC50
	|-Span<byte>.GetHashCode
	|-Span<char>.GetHashCode
	|-Span<int>.GetHashCode
	|-Span<ushort>.GetHashCode
	|-Span<uint>.GetHashCode
	|-Span<__Il2CppFullySharedGenericType>.GetHashCode
	|-Span<jvalue>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0C70 Offset: 0x119F670 VA: 0x1811A0C70
	|-Span<byte>.op_Implicit
	|-Span<char>.op_Implicit
	|-Span<int>.op_Implicit
	|-Span<ushort>.op_Implicit
	|-Span<uint>.op_Implicit
	|-Span<jvalue>.op_Implicit
	|
	|-RVA: 0x11E0750 Offset: 0x11DF150 VA: 0x1811E0750
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	*/
}
