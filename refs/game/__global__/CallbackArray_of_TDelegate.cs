internal struct CallbackArray<TDelegate> // TypeDefIndex: 7802
{
	// Fields
	private bool m_CannotMutateCallbacksArray; // 0x0
	private InlinedArray<TDelegate> m_Callbacks; // 0x0
	private InlinedArray<TDelegate> m_CallbacksToAdd; // 0x0
	private InlinedArray<TDelegate> m_CallbacksToRemove; // 0x0

	// Properties
	public int length { get; }
	public TDelegate Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-CallbackArray<object>.get_length
	*/

	// RVA: -1 Offset: -1
	public TDelegate get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14396C0 Offset: 0x14380C0 VA: 0x1814396C0
	|-CallbackArray<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1439180 Offset: 0x1437B80 VA: 0x181439180
	|-CallbackArray<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void AddCallback(TDelegate dlg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1438FD0 Offset: 0x14379D0 VA: 0x181438FD0
	|-CallbackArray<object>.AddCallback
	*/

	// RVA: -1 Offset: -1
	public void RemoveCallback(TDelegate dlg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1439230 Offset: 0x1437C30 VA: 0x181439230
	|-CallbackArray<object>.RemoveCallback
	*/

	// RVA: -1 Offset: -1
	public void LockForChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1439220 Offset: 0x1437C20 VA: 0x181439220
	|-CallbackArray<object>.LockForChanges
	*/

	// RVA: -1 Offset: -1
	public void UnlockForChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14393D0 Offset: 0x1437DD0 VA: 0x1814393D0
	|-CallbackArray<object>.UnlockForChanges
	*/
}
