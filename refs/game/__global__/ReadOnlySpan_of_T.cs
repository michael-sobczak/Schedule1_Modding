public struct ReadOnlySpan<T> // TypeDefIndex: 3715
{
	// Fields
	internal readonly ByReference<T> _pointer; // 0x0
	private readonly int _length; // 0x0

	// Properties
	[IsReadOnly]
	public T Item { get; }
	public int Length { get; }
	public bool IsEmpty { get; }
	public static ReadOnlySpan<T> Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A07B0 Offset: 0x119F1B0 VA: 0x1811A07B0
	|-ReadOnlySpan<byte>..ctor
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<ushort>..ctor
	|-ReadOnlySpan<uint>..ctor
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlySpan<jvalue>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0850 Offset: 0x119F250 VA: 0x1811A0850
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x11A0730 Offset: 0x119F130 VA: 0x1811A0730
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x11A07D0 Offset: 0x119F1D0 VA: 0x1811A07D0
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x11A0950 Offset: 0x119F350 VA: 0x1811A0950
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11A08D0 Offset: 0x119F2D0 VA: 0x1811A08D0
	|-ReadOnlySpan<jvalue>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A06E0 Offset: 0x119F0E0 VA: 0x1811A06E0
	|-ReadOnlySpan<byte>..ctor
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<ushort>..ctor
	|-ReadOnlySpan<uint>..ctor
	|-ReadOnlySpan<jvalue>..ctor
	|
	|-RVA: 0x11A0A30 Offset: 0x119F430 VA: 0x1811A0A30
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ref T ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0D60 Offset: 0x10EF760 VA: 0x1810F0D60
	|-ReadOnlySpan<byte>..ctor
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<ushort>..ctor
	|-ReadOnlySpan<uint>..ctor
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlySpan<jvalue>..ctor
	*/

	[NonVersionable]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0B20 Offset: 0x119F520 VA: 0x1811A0B20
	|-ReadOnlySpan<byte>.get_Item
	|
	|-RVA: 0x11A0BE0 Offset: 0x119F5E0 VA: 0x1811A0BE0
	|-ReadOnlySpan<char>.get_Item
	|-ReadOnlySpan<ushort>.get_Item
	|
	|-RVA: 0x11A0C10 Offset: 0x119F610 VA: 0x1811A0C10
	|-ReadOnlySpan<int>.get_Item
	|-ReadOnlySpan<uint>.get_Item
	|
	|-RVA: 0x11A0B50 Offset: 0x119F550 VA: 0x1811A0B50
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x11A0C40 Offset: 0x119F640 VA: 0x1811A0C40
	|-ReadOnlySpan<jvalue>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119EAE0 Offset: 0x119D4E0 VA: 0x18119EAE0
	|-ReadOnlySpan<byte>.CopyTo
	|
	|-RVA: 0x119E9C0 Offset: 0x119D3C0 VA: 0x18119E9C0
	|-ReadOnlySpan<char>.CopyTo
	|-ReadOnlySpan<ushort>.CopyTo
	|
	|-RVA: 0x119EA50 Offset: 0x119D450 VA: 0x18119EA50
	|-ReadOnlySpan<int>.CopyTo
	|-ReadOnlySpan<uint>.CopyTo
	|
	|-RVA: 0x119E8D0 Offset: 0x119D2D0 VA: 0x18119E8D0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x119EB70 Offset: 0x119D570 VA: 0x18119EB70
	|-ReadOnlySpan<jvalue>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0530 Offset: 0x119EF30 VA: 0x1811A0530
	|-ReadOnlySpan<byte>.TryCopyTo
	|
	|-RVA: 0x11A03B0 Offset: 0x119EDB0 VA: 0x1811A03B0
	|-ReadOnlySpan<char>.TryCopyTo
	|-ReadOnlySpan<ushort>.TryCopyTo
	|
	|-RVA: 0x11A05C0 Offset: 0x119EFC0 VA: 0x1811A05C0
	|-ReadOnlySpan<int>.TryCopyTo
	|-ReadOnlySpan<uint>.TryCopyTo
	|
	|-RVA: 0x11A0440 Offset: 0x119EE40 VA: 0x1811A0440
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.TryCopyTo
	|
	|-RVA: 0x11A0650 Offset: 0x119F050 VA: 0x1811A0650
	|-ReadOnlySpan<jvalue>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119FA50 Offset: 0x119E450 VA: 0x18119FA50
	|-ReadOnlySpan<byte>.ToString
	|
	|-RVA: 0x119FF00 Offset: 0x119E900 VA: 0x18119FF00
	|-ReadOnlySpan<char>.ToString
	|
	|-RVA: 0x11A0220 Offset: 0x119EC20 VA: 0x1811A0220
	|-ReadOnlySpan<int>.ToString
	|
	|-RVA: 0x11A0090 Offset: 0x119EA90 VA: 0x1811A0090
	|-ReadOnlySpan<ushort>.ToString
	|
	|-RVA: 0x119FBE0 Offset: 0x119E5E0 VA: 0x18119FBE0
	|-ReadOnlySpan<uint>.ToString
	|
	|-RVA: 0x119F8C0 Offset: 0x119E2C0 VA: 0x18119F8C0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0x119FD70 Offset: 0x119E770 VA: 0x18119FD70
	|-ReadOnlySpan<jvalue>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119F140 Offset: 0x119DB40 VA: 0x18119F140
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x119EEA0 Offset: 0x119D8A0 VA: 0x18119EEA0
	|-ReadOnlySpan<char>.Slice
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x119EDA0 Offset: 0x119D7A0 VA: 0x18119EDA0
	|-ReadOnlySpan<int>.Slice
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x119F070 Offset: 0x119DA70 VA: 0x18119F070
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x119ED20 Offset: 0x119D720 VA: 0x18119ED20
	|-ReadOnlySpan<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119F1C0 Offset: 0x119DBC0 VA: 0x18119F1C0
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x119EF20 Offset: 0x119D920 VA: 0x18119EF20
	|-ReadOnlySpan<char>.Slice
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x119ECA0 Offset: 0x119D6A0 VA: 0x18119ECA0
	|-ReadOnlySpan<int>.Slice
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x119EFA0 Offset: 0x119D9A0 VA: 0x18119EFA0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	|
	|-RVA: 0x119EE20 Offset: 0x119D820 VA: 0x18119EE20
	|-ReadOnlySpan<jvalue>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119F620 Offset: 0x119E020 VA: 0x18119F620
	|-ReadOnlySpan<byte>.ToArray
	|
	|-RVA: 0x119F240 Offset: 0x119DC40 VA: 0x18119F240
	|-ReadOnlySpan<char>.ToArray
	|-ReadOnlySpan<ushort>.ToArray
	|
	|-RVA: 0x119F390 Offset: 0x119DD90 VA: 0x18119F390
	|-ReadOnlySpan<int>.ToArray
	|-ReadOnlySpan<uint>.ToArray
	|
	|-RVA: 0x119F4E0 Offset: 0x119DEE0 VA: 0x18119F4E0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x119F770 Offset: 0x119E170 VA: 0x18119F770
	|-ReadOnlySpan<jvalue>.ToArray
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-ReadOnlySpan<byte>.get_Length
	|-ReadOnlySpan<char>.get_Length
	|-ReadOnlySpan<int>.get_Length
	|-ReadOnlySpan<ushort>.get_Length
	|-ReadOnlySpan<uint>.get_Length
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Length
	|-ReadOnlySpan<jvalue>.get_Length
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0B10 Offset: 0x119F510 VA: 0x1811A0B10
	|-ReadOnlySpan<byte>.get_IsEmpty
	|-ReadOnlySpan<char>.get_IsEmpty
	|-ReadOnlySpan<int>.get_IsEmpty
	|-ReadOnlySpan<ushort>.get_IsEmpty
	|-ReadOnlySpan<uint>.get_IsEmpty
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_IsEmpty
	|-ReadOnlySpan<jvalue>.get_IsEmpty
	*/

	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119EC00 Offset: 0x119D600 VA: 0x18119EC00
	|-ReadOnlySpan<byte>.Equals
	|-ReadOnlySpan<char>.Equals
	|-ReadOnlySpan<int>.Equals
	|-ReadOnlySpan<ushort>.Equals
	|-ReadOnlySpan<uint>.Equals
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Equals
	|-ReadOnlySpan<jvalue>.Equals
	*/

	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119EC50 Offset: 0x119D650 VA: 0x18119EC50
	|-ReadOnlySpan<byte>.GetHashCode
	|-ReadOnlySpan<char>.GetHashCode
	|-ReadOnlySpan<int>.GetHashCode
	|-ReadOnlySpan<ushort>.GetHashCode
	|-ReadOnlySpan<uint>.GetHashCode
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.GetHashCode
	|-ReadOnlySpan<jvalue>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A0C70 Offset: 0x119F670 VA: 0x1811A0C70
	|-ReadOnlySpan<byte>.op_Implicit
	|-ReadOnlySpan<char>.op_Implicit
	|-ReadOnlySpan<int>.op_Implicit
	|-ReadOnlySpan<ushort>.op_Implicit
	|-ReadOnlySpan<uint>.op_Implicit
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.op_Implicit
	|-ReadOnlySpan<jvalue>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64110 Offset: 0xE62B10 VA: 0x180E64110
	|-ReadOnlySpan<byte>.get_Empty
	|-ReadOnlySpan<char>.get_Empty
	|-ReadOnlySpan<int>.get_Empty
	|-ReadOnlySpan<ushort>.get_Empty
	|-ReadOnlySpan<uint>.get_Empty
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Empty
	|-ReadOnlySpan<jvalue>.get_Empty
	*/
}
