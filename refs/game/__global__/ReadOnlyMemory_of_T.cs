public struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>> // TypeDefIndex: 3714
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public ReadOnlySpan<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E7D0 Offset: 0x105D1D0 VA: 0x18105E7D0
	|-ReadOnlyMemory<byte>..ctor
	|-ReadOnlyMemory<char>..ctor
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E530 Offset: 0x105CF30 VA: 0x18105E530
	|-ReadOnlyMemory<byte>..ctor
	|-ReadOnlyMemory<char>..ctor
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E820 Offset: 0x105D220 VA: 0x18105E820
	|-ReadOnlyMemory<byte>.get_Length
	|-ReadOnlyMemory<char>.get_Length
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119D0A0 Offset: 0x119BAA0 VA: 0x18119D0A0
	|-ReadOnlyMemory<byte>.ToString
	|
	|-RVA: 0x119D7E0 Offset: 0x119C1E0 VA: 0x18119D7E0
	|-ReadOnlyMemory<char>.ToString
	|
	|-RVA: 0x119D420 Offset: 0x119BE20 VA: 0x18119D420
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119E490 Offset: 0x119CE90 VA: 0x18119E490
	|-ReadOnlyMemory<byte>.get_Span
	|
	|-RVA: 0x119DB60 Offset: 0x119C560 VA: 0x18119DB60
	|-ReadOnlyMemory<char>.get_Span
	|
	|-RVA: 0x119DF90 Offset: 0x119C990 VA: 0x18119DF90
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119CCB0 Offset: 0x119B6B0 VA: 0x18119CCB0
	|-ReadOnlyMemory<byte>.Equals
	|-ReadOnlyMemory<char>.Equals
	|
	|-RVA: 0x119CA70 Offset: 0x119B470 VA: 0x18119CA70
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ReadOnlyMemory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CBF0 Offset: 0x105B5F0 VA: 0x18105CBF0
	|-ReadOnlyMemory<byte>.Equals
	|-ReadOnlyMemory<char>.Equals
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119CED0 Offset: 0x119B8D0 VA: 0x18119CED0
	|-ReadOnlyMemory<byte>.GetHashCode
	|-ReadOnlyMemory<char>.GetHashCode
	|
	|-RVA: 0x119CFB0 Offset: 0x119B9B0 VA: 0x18119CFB0
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C7D0 Offset: 0x105B1D0 VA: 0x18105C7D0
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|-ReadOnlyMemory<char>.CombineHashCodes
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C7E0 Offset: 0x105B1E0 VA: 0x18105C7E0
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|-ReadOnlyMemory<char>.CombineHashCodes
	|
	|-RVA: 0x119C980 Offset: 0x119B380 VA: 0x18119C980
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	internal object GetObjectStartLength(out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119D090 Offset: 0x119BA90 VA: 0x18119D090
	|-ReadOnlyMemory<byte>.GetObjectStartLength
	|-ReadOnlyMemory<char>.GetObjectStartLength
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetObjectStartLength
	*/
}
