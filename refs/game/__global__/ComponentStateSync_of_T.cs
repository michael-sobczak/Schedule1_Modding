public class ComponentStateSync<T> : SyncBase, ICustomSync // TypeDefIndex: 18103
{
	// Fields
	[CompilerGenerated]
	private T <Component>k__BackingField; // 0x0
	[CompilerGenerated]
	private ComponentStateSync.StateChanged<T> OnChange; // 0x0

	// Properties
	public bool Enabled { get; set; }
	public T Component { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_Enabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B68B0 Offset: 0x14B52B0 VA: 0x1814B68B0
	|-ComponentStateSync<object>.get_Enabled
	*/

	// RVA: -1 Offset: -1
	public void set_Enabled(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6A00 Offset: 0x14B5400 VA: 0x1814B6A00
	|-ComponentStateSync<object>.set_Enabled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Component() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	|-ComponentStateSync<object>.get_Component
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Component(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	|-ComponentStateSync<object>.set_Component
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnChange(ComponentStateSync.StateChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B67E0 Offset: 0x14B51E0 VA: 0x1814B67E0
	|-ComponentStateSync<object>.add_OnChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnChange(ComponentStateSync.StateChanged<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6930 Offset: 0x14B5330 VA: 0x1814B6930
	|-ComponentStateSync<object>.remove_OnChange
	*/

	// RVA: -1 Offset: -1
	public void Initialize(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	|-ComponentStateSync<object>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void SetState(bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B64A0 Offset: 0x14B4EA0 VA: 0x1814B64A0
	|-ComponentStateSync<object>.SetState
	*/

	// RVA: -1 Offset: -1
	private bool GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6350 Offset: 0x14B4D50 VA: 0x1814B6350
	|-ComponentStateSync<object>.GetState
	*/

	// RVA: -1 Offset: -1
	private void AddOperation(T component, bool prev, bool next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B61E0 Offset: 0x14B4BE0 VA: 0x1814B61E0
	|-ComponentStateSync<object>.AddOperation
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6680 Offset: 0x14B5080 VA: 0x1814B6680
	|-ComponentStateSync<object>.WriteDelta
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override void WriteFull(PooledWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B67A0 Offset: 0x14B51A0 VA: 0x1814B67A0
	|-ComponentStateSync<object>.WriteFull
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6370 Offset: 0x14B4D70 VA: 0x1814B6370
	|-ComponentStateSync<object>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public object GetSerializedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B62F0 Offset: 0x14B4CF0 VA: 0x1814B62F0
	|-ComponentStateSync<object>.GetSerializedType
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B67D0 Offset: 0x14B51D0 VA: 0x1814B67D0
	|-ComponentStateSync<object>..ctor
	*/
}
