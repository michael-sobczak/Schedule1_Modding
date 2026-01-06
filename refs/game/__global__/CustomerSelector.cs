public class CustomerSelector : MonoBehaviour // TypeDefIndex: 2784
{
	// Fields
	public GameObject ButtonPrefab; // 0x20
	[Header("References")]
	public RectTransform EntriesContainer; // 0x28
	public UnityEvent<Customer> onCustomerSelected; // 0x30
	private List<RectTransform> customerEntries; // 0x38
	private Dictionary<RectTransform, Customer> entryToCustomer; // 0x40

	// Methods

	// RVA: 0x929F00 Offset: 0x928900 VA: 0x180929F00
	public void Awake() { }

	// RVA: 0x92A8F0 Offset: 0x9292F0 VA: 0x18092A8F0
	public void Start() { }

	// RVA: 0x92A630 Offset: 0x929030 VA: 0x18092A630
	private void OnDestroy() { }

	// RVA: 0x92A530 Offset: 0x928F30 VA: 0x18092A530
	private void Exit(ExitAction action) { }

	// RVA: 0x92A770 Offset: 0x929170 VA: 0x18092A770
	public void Open() { }

	// RVA: 0x6FE090 Offset: 0x6FCA90 VA: 0x1806FE090
	public void Close() { }

	// RVA: 0x92A110 Offset: 0x928B10 VA: 0x18092A110
	private void CreateEntry(Customer customer) { }

	// RVA: 0x92A470 Offset: 0x928E70 VA: 0x18092A470
	private void CustomerSelected(Customer customer) { }

	// RVA: 0x92A990 Offset: 0x929390 VA: 0x18092A990
	public void .ctor() { }
}
