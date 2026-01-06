public abstract class ACSelection<T> : MonoBehaviour // TypeDefIndex: 3174
{
	// Fields
	[Header("References")]
	public GameObject ButtonPrefab; // 0x0
	[Header("Settings")]
	public int PropertyIndex; // 0x0
	public List<T> Options; // 0x0
	public bool Nullable; // 0x0
	public int DefaultOptionIndex; // 0x0
	protected List<GameObject> buttons; // 0x0
	protected int SelectedOptionIndex; // 0x0
	public UnityEvent<T> onValueChange; // 0x0
	public UnityEvent<T, int> onValueChangeWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE2440 Offset: 0xFE0E40 VA: 0x180FE2440
	|-ACSelection<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public void SelectOption(int index, bool notify = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE2700 Offset: 0xFE1100 VA: 0x180FE2700
	|-ACSelection<object>.SelectOption
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CallValueChange();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ACSelection<object>.CallValueChange
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetOptionLabel(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ACSelection<object>.GetOptionLabel
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetAssetPathIndex(string path);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ACSelection<object>.GetAssetPathIndex
	*/

	// RVA: -1 Offset: -1
	private void SetButtonHighlighted(int buttonIndex, bool h) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE27E0 Offset: 0xFE11E0 VA: 0x180FE27E0
	|-ACSelection<object>.SetButtonHighlighted
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE28A0 Offset: 0xFE12A0 VA: 0x180FE28A0
	|-ACSelection<object>..ctor
	*/
}
