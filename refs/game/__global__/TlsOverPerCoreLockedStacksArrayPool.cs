private sealed class TlsOverPerCoreLockedStacksArrayPool.LockedStack<T> // TypeDefIndex: 5032
{
	// Fields
	private readonly T[][] _arrays; // 0x0
	private int _count; // 0x0
	private uint _firstStackItemMS; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public bool TryPush(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055DB0 Offset: 0x10547B0 VA: 0x181055DB0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPush
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPush
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPush
	|
	|-RVA: 0x1055EB0 Offset: 0x10548B0 VA: 0x181055EB0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPush
	*/

	// RVA: -1 Offset: -1
	public T[] TryPop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055D20 Offset: 0x1054720 VA: 0x181055D20
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPop
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPop
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPop
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> pressure, int bucketSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055AC0 Offset: 0x10544C0 VA: 0x181055AC0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.Trim
	|
	|-RVA: 0x1055860 Offset: 0x1054260 VA: 0x181055860
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.Trim
	|
	|-RVA: 0x1055600 Offset: 0x1054000 VA: 0x181055600
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.Trim
	|
	|-RVA: 0x1055340 Offset: 0x1053D40 VA: 0x181055340
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055FE0 Offset: 0x10549E0 VA: 0x181055FE0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>..ctor
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>..ctor
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>..ctor
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>..ctor
	*/
}
