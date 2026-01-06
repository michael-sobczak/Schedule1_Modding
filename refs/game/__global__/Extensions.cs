public static class Extensions // TypeDefIndex: 16018
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(UnsafeParallelHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA09E0 Offset: 0xE9F3E0 VA: 0x180EA09E0
	|-Extensions.ToArray<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	// RVA: 0x2747060 Offset: 0x2745A60 VA: 0x182747060
	public static void AddNBC(ref UnsafeAppendBuffer buffer, string value) { }

	[NotBurstCompatible]
	[Extension]
	// RVA: 0x27471C0 Offset: 0x2745BC0 VA: 0x1827471C0
	public static byte[] ToBytesNBC(ref UnsafeAppendBuffer buffer) { }

	[Extension]
	[NotBurstCompatible]
	// RVA: 0x27470E0 Offset: 0x2745AE0 VA: 0x1827470E0
	public static void ReadNextNBC(ref UnsafeAppendBuffer.Reader reader, out string value) { }
}
