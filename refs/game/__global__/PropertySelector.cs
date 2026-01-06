public class PropertySelector : MonoBehaviour // TypeDefIndex: 2690
{
	// Fields
	[SerializeField]
	[Header("References")]
	protected GameObject container; // 0x20
	[SerializeField]
	protected RectTransform buttonContainer; // 0x28
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject buttonPrefab; // 0x30
	private PropertySelector.PropertySelected pCallback; // 0x38

	// Properties
	public bool isOpen { get; }

	// Methods

	// RVA: 0x914300 Offset: 0x912D00 VA: 0x180914300
	public bool get_isOpen() { }

	// RVA: 0x913B40 Offset: 0x912540 VA: 0x180913B40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x914260 Offset: 0x912C60 VA: 0x180914260 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x913F30 Offset: 0x912930 VA: 0x180913F30 Slot: 6
	public virtual void Exit(ExitAction exit) { }

	// RVA: 0x913F90 Offset: 0x912990 VA: 0x180913F90
	public void OpenSelector(PropertySelector.PropertySelected p) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void PropertyAcquired(Property p) { }

	// RVA: 0x914220 Offset: 0x912C20 VA: 0x180914220
	private void SelectProperty(Property p) { }

	// RVA: 0x913CA0 Offset: 0x9126A0 VA: 0x180913CA0
	private void Close(bool reenableShit) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
