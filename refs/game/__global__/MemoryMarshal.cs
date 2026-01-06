public static class MemoryMarshal // TypeDefIndex: 4519
{
	// Methods

	// RVA: -1 Offset: -1
	public static Span<byte> AsBytes<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFF990 Offset: 0xEFE390 VA: 0x180EFF990
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0xEFFB70 Offset: 0xEFE570 VA: 0x180EFFB70
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFCB0 Offset: 0xEFE6B0 VA: 0x180EFFCB0
	|-MemoryMarshal.AsBytes<ushort>
	|
	|-RVA: 0xEFFD50 Offset: 0xEFE750 VA: 0x180EFFD50
	|-MemoryMarshal.AsBytes<uint>
	|
	|-RVA: 0xEFFA30 Offset: 0xEFE430 VA: 0x180EFFA30
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	|-MemoryMarshal.AsMemory<byte>
	|-MemoryMarshal.AsMemory<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<ushort>
	|-MemoryMarshal.GetReference<uint>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFE40 Offset: 0xEFE840 VA: 0x180EFFE40
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0xEFFE80 Offset: 0xEFE880 VA: 0x180EFFE80
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFE40 Offset: 0xEFE840 VA: 0x180EFFE40
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0xEFFE80 Offset: 0xEFE880 VA: 0x180EFFE80
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFDF0 Offset: 0xEFE7F0 VA: 0x180EFFDF0
	|-MemoryMarshal.CreateReadOnlySpan<char>
	|-MemoryMarshal.CreateReadOnlySpan<uint>
	|-MemoryMarshal.CreateReadOnlySpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFFEE0 Offset: 0xEFE8E0 VA: 0x180EFFEE0
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0xF001A0 Offset: 0xEFEBA0 VA: 0x180F001A0
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/
}
