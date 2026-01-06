public class PropertyDropdown : MonoBehaviour // TypeDefIndex: 2688
{
	// Fields
	public Property selectedProperty; // 0x20
	private TMP_Dropdown TMP_dropdown; // 0x28
	private Dropdown dropdown; // 0x30
	private Dictionary<int, Property> intToProperty; // 0x38
	public Action onSelectionChanged; // 0x40

	// Methods

	// RVA: 0x9015F0 Offset: 0x8FFFF0 VA: 0x1809015F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9019E0 Offset: 0x9003E0 VA: 0x1809019E0
	private void PropertyAcquired(Property p) { }

	// RVA: 0x901C10 Offset: 0x900610 VA: 0x180901C10
	private void ValueChanged(int newVal) { }

	// RVA: 0x901C90 Offset: 0x900690 VA: 0x180901C90
	public void .ctor() { }
}
