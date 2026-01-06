public struct PooledObject<T> : IDisposable // TypeDefIndex: 12138
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, IObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	|-PooledObject<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FB1B0 Offset: 0x10F9BB0 VA: 0x1810FB1B0
	|-PooledObject<object>.System.IDisposable.Dispose
	*/
}
