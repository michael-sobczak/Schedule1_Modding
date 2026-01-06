public struct Memory<T> : IEquatable<Memory<T>> // TypeDefIndex: 3687
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0
	private const int RemoveFlagsBitMask = 2147483647;

	// Properties
	public int Length { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E7D0 Offset: 0x105D1D0 VA: 0x18105E7D0
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x105E380 Offset: 0x105CD80 VA: 0x18105E380
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E530 Offset: 0x105CF30 VA: 0x18105E530
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x105E5B0 Offset: 0x105CFB0 VA: 0x18105E5B0
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E790 Offset: 0x105D190 VA: 0x18105E790
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105F460 Offset: 0x105DE60 VA: 0x18105F460
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x105F4D0 Offset: 0x105DED0 VA: 0x18105F4D0
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E820 Offset: 0x105D220 VA: 0x18105E820
	|-Memory<byte>.get_Length
	|-Memory<char>.get_Length
	|-Memory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E150 Offset: 0x105CB50 VA: 0x18105E150
	|-Memory<byte>.ToString
	|
	|-RVA: 0x105DCD0 Offset: 0x105C6D0 VA: 0x18105DCD0
	|-Memory<char>.ToString
	|
	|-RVA: 0x105DF00 Offset: 0x105C900 VA: 0x18105DF00
	|-Memory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105DA40 Offset: 0x105C440 VA: 0x18105DA40
	|-Memory<byte>.Slice
	|-Memory<char>.Slice
	|-Memory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105F060 Offset: 0x105DA60 VA: 0x18105F060
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x105EC60 Offset: 0x105D660 VA: 0x18105EC60
	|-Memory<char>.get_Span
	|
	|-RVA: 0x105E830 Offset: 0x105D230 VA: 0x18105E830
	|-Memory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1
	public MemoryHandle Pin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105D730 Offset: 0x105C130 VA: 0x18105D730
	|-Memory<byte>.Pin
	|
	|-RVA: 0x105D410 Offset: 0x105BE10 VA: 0x18105D410
	|-Memory<char>.Pin
	|
	|-RVA: 0x105CFF0 Offset: 0x105B9F0 VA: 0x18105CFF0
	|-Memory<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105DC50 Offset: 0x105C650 VA: 0x18105DC50
	|-Memory<byte>.ToArray
	|
	|-RVA: 0x105DAF0 Offset: 0x105C4F0 VA: 0x18105DAF0
	|-Memory<char>.ToArray
	|
	|-RVA: 0x105DB70 Offset: 0x105C570 VA: 0x18105DB70
	|-Memory<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CC10 Offset: 0x105B610 VA: 0x18105CC10
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|
	|-RVA: 0x105C940 Offset: 0x105B340 VA: 0x18105C940
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CBF0 Offset: 0x105B5F0 VA: 0x18105CBF0
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CF10 Offset: 0x105B910 VA: 0x18105CF10
	|-Memory<byte>.GetHashCode
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x105CE30 Offset: 0x105B830 VA: 0x18105CE30
	|-Memory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C7D0 Offset: 0x105B1D0 VA: 0x18105C7D0
	|-Memory<byte>.CombineHashCodes
	|-Memory<char>.CombineHashCodes
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C7E0 Offset: 0x105B1E0 VA: 0x18105C7E0
	|-Memory<byte>.CombineHashCodes
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x105C850 Offset: 0x105B250 VA: 0x18105C850
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/
}
