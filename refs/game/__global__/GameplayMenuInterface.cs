public class GameplayMenuInterface : Singleton<GameplayMenuInterface> // TypeDefIndex: 2609
{
	// Fields
	public Canvas Canvas; // 0x28
	public Button PhoneButton; // 0x30
	public Button CharacterButton; // 0x38
	public RectTransform SelectionIndicator; // 0x40
	public CharacterInterface CharacterInterface; // 0x48
	private Coroutine selectionLerp; // 0x50

	// Methods

	// RVA: 0x8E4A90 Offset: 0x8E3490 VA: 0x1808E4A90 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8E4F70 Offset: 0x8E3970 VA: 0x1808E4F70 Slot: 4
	protected override void Start() { }

	// RVA: 0x8E4C60 Offset: 0x8E3660 VA: 0x1808E4C60
	public void Open() { }

	// RVA: 0x8E4C30 Offset: 0x8E3630 VA: 0x1808E4C30
	public void Close() { }

	// RVA: 0x8E4C90 Offset: 0x8E3690 VA: 0x1808E4C90
	public void PhoneClicked() { }

	// RVA: 0x8E4BB0 Offset: 0x8E35B0 VA: 0x1808E4BB0
	public void CharacterClicked() { }

	// RVA: 0x8E4D10 Offset: 0x8E3710 VA: 0x1808E4D10
	public void SetSelected(GameplayMenu.EGameplayScreen screen) { }

	// RVA: 0x8E5040 Offset: 0x8E3A40 VA: 0x1808E5040
	public void .ctor() { }
}
