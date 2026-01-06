public abstract class MemoryManager<T> // TypeDefIndex: 5029
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Span<T> GetSpan();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MemoryHandle Pin(int elementIndex = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C7C0 Offset: 0x105B1C0 VA: 0x18105C7C0
	|-MemoryManager<byte>.TryGetArray
	|-MemoryManager<char>.TryGetArray
	|-MemoryManager<__Il2CppFullySharedGenericType>.TryGetArray
	*/
}
