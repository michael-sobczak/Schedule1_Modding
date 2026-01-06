internal class NativePagedList<T> : IDisposable // TypeDefIndex: 7111
{
	// Fields
	private readonly int k_PoolCapacity; // 0x0
	private List<NativeArray<T>> m_Pages; // 0x0
	private NativeArray<T> m_CurrentPage; // 0x0
	private int m_CurrentPageCount; // 0x0
	private List<NativeSlice<T>> m_Enumerator; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108E6C0 Offset: 0x108D0C0 VA: 0x18108E6C0
	|-NativePagedList<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x108E940 Offset: 0x108D340 VA: 0x18108E940
	|-NativePagedList<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x108E580 Offset: 0x108CF80 VA: 0x18108E580
	|-NativePagedList<NudgeJobData>..ctor
	|
	|-RVA: 0x108E800 Offset: 0x108D200 VA: 0x18108E800
	|-NativePagedList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(ref T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108CD50 Offset: 0x108B750 VA: 0x18108CD50
	|-NativePagedList<ConvertMeshJobData>.Add
	|
	|-RVA: 0x108CA10 Offset: 0x108B410 VA: 0x18108CA10
	|-NativePagedList<CopyClosingMeshJobData>.Add
	|
	|-RVA: 0x108CB80 Offset: 0x108B580 VA: 0x18108CB80
	|-NativePagedList<NudgeJobData>.Add
	|
	|-RVA: 0x108CF80 Offset: 0x108B980 VA: 0x18108CF80
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public List<NativeSlice<T>> GetPages() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108DCC0 Offset: 0x108C6C0 VA: 0x18108DCC0
	|-NativePagedList<ConvertMeshJobData>.GetPages
	|
	|-RVA: 0x108DF50 Offset: 0x108C950 VA: 0x18108DF50
	|-NativePagedList<CopyClosingMeshJobData>.GetPages
	|
	|-RVA: 0x108D7D0 Offset: 0x108C1D0 VA: 0x18108D7D0
	|-NativePagedList<NudgeJobData>.GetPages
	|
	|-RVA: 0x108DA60 Offset: 0x108C460 VA: 0x18108DA60
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.GetPages
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108E1E0 Offset: 0x108CBE0 VA: 0x18108E1E0
	|-NativePagedList<ConvertMeshJobData>.Reset
	|-NativePagedList<CopyClosingMeshJobData>.Reset
	|-NativePagedList<NudgeJobData>.Reset
	|
	|-RVA: 0x108E380 Offset: 0x108CD80 VA: 0x18108E380
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Reset
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	|-NativePagedList<ConvertMeshJobData>.get_disposed
	|-NativePagedList<CopyClosingMeshJobData>.get_disposed
	|-NativePagedList<NudgeJobData>.get_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	|-NativePagedList<ConvertMeshJobData>.set_disposed
	|-NativePagedList<CopyClosingMeshJobData>.set_disposed
	|-NativePagedList<NudgeJobData>.set_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108D1A0 Offset: 0x108BBA0 VA: 0x18108D1A0
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|
	|-RVA: 0x108D6B0 Offset: 0x108C0B0 VA: 0x18108D6B0
	|-NativePagedList<CopyClosingMeshJobData>.Dispose
	|
	|-RVA: 0x108D2C0 Offset: 0x108BCC0 VA: 0x18108D2C0
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x108D630 Offset: 0x108C030 VA: 0x18108D630
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108D3E0 Offset: 0x108BDE0 VA: 0x18108D3E0
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|-NativePagedList<CopyClosingMeshJobData>.Dispose
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x108D4C0 Offset: 0x108BEC0 VA: 0x18108D4C0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}
