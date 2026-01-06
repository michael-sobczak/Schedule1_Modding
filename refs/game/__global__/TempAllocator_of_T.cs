internal class TempAllocator<T> : IDisposable // TypeDefIndex: 7133
{
	// Fields
	private readonly int m_ExcessMinCapacity; // 0x0
	private readonly int m_ExcessMaxCapacity; // 0x0
	private TempAllocator.Page<T> m_Pool; // 0x0
	private List<TempAllocator.Page<T>> m_Excess; // 0x0
	private int m_NextExcessSize; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12321F0 Offset: 0x1230BF0 VA: 0x1812321F0
	|-TempAllocator<ushort>..ctor
	|
	|-RVA: 0x1232470 Offset: 0x1230E70 VA: 0x181232470
	|-TempAllocator<Vertex>..ctor
	|
	|-RVA: 0x1232330 Offset: 0x1230D30 VA: 0x181232330
	|-TempAllocator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	|-TempAllocator<ushort>.get_disposed
	|-TempAllocator<Vertex>.get_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060
	|-TempAllocator<ushort>.set_disposed
	|-TempAllocator<Vertex>.set_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1231D70 Offset: 0x1230770 VA: 0x181231D70
	|-TempAllocator<ushort>.Dispose
	|
	|-RVA: 0x1231CC0 Offset: 0x12306C0 VA: 0x181231CC0
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0x1231BF0 Offset: 0x12305F0 VA: 0x181231BF0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1231C60 Offset: 0x1230660 VA: 0x181231C60
	|-TempAllocator<ushort>.Dispose
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0x1231B50 Offset: 0x1230550 VA: 0x181231B50
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeSlice<T> Alloc(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1231710 Offset: 0x1230110 VA: 0x181231710
	|-TempAllocator<ushort>.Alloc
	|
	|-RVA: 0x12312D0 Offset: 0x122FCD0 VA: 0x1812312D0
	|-TempAllocator<Vertex>.Alloc
	|
	|-RVA: 0x1230E80 Offset: 0x122F880 VA: 0x181230E80
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Alloc
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12321C0 Offset: 0x1230BC0 VA: 0x1812321C0
	|-TempAllocator<ushort>.Reset
	|-TempAllocator<Vertex>.Reset
	|
	|-RVA: 0x1232190 Offset: 0x1230B90 VA: 0x181232190
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1
	private void ReleaseExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1231E20 Offset: 0x1230820 VA: 0x181231E20
	|-TempAllocator<ushort>.ReleaseExcess
	|-TempAllocator<Vertex>.ReleaseExcess
	|
	|-RVA: 0x1231FA0 Offset: 0x12309A0 VA: 0x181231FA0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.ReleaseExcess
	*/
}
