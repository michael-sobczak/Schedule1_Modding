internal class LinkedPool<T> // TypeDefIndex: 7105
{
	// Fields
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ResetAction; // 0x0
	private readonly int m_Limit; // 0x0
	private T m_PoolFirst; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0140 Offset: 0x18DEB40 VA: 0x1818E0140
	|-LinkedPool<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	|-LinkedPool<object>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	|-LinkedPool<object>.set_Count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0050 Offset: 0x18DEA50 VA: 0x1818E0050
	|-LinkedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0060 Offset: 0x18DEA60 VA: 0x1818E0060
	|-LinkedPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Return(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E00E0 Offset: 0x18DEAE0 VA: 0x1818E00E0
	|-LinkedPool<object>.Return
	*/
}
