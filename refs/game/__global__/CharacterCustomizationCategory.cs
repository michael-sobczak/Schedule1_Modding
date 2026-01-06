public class CharacterCustomizationCategory : MonoBehaviour // TypeDefIndex: 2968
{
	// Fields
	public string CategoryName; // 0x20
	[Header("References")]
	public TextMeshProUGUI TitleText; // 0x28
	public Button BackButton; // 0x30
	public ScrollRect ScrollRect; // 0x38
	private CharacterCustomizationUI ui; // 0x40
	private CharacterCustomizationOption[] options; // 0x48
	public UnityEvent onOpen; // 0x50
	public UnityEvent onClose; // 0x58

	// Methods

	// RVA: 0x978590 Offset: 0x976F90 VA: 0x180978590
	private void Awake() { }

	// RVA: 0x978AC0 Offset: 0x9774C0 VA: 0x180978AC0
	public void Open() { }

	// RVA: 0x9789F0 Offset: 0x9773F0 VA: 0x1809789F0
	public void Back() { }

	// RVA: 0x978EA0 Offset: 0x9778A0 VA: 0x180978EA0
	private void OptionSelected(CharacterCustomizationOption option) { }

	// RVA: 0x978CF0 Offset: 0x9776F0 VA: 0x180978CF0
	private void OptionDeselected(CharacterCustomizationOption option) { }

	// RVA: 0x978D20 Offset: 0x977720 VA: 0x180978D20
	private void OptionPurchased(CharacterCustomizationOption option) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
