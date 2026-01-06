public class LobbyInterface : PersistentSingleton<LobbyInterface> // TypeDefIndex: 2860
{
	// Fields
	[Header("References")]
	public Lobby Lobby; // 0x28
	public Canvas Canvas; // 0x30
	public TextMeshProUGUI LobbyTitle; // 0x38
	public RectTransform[] PlayerSlots; // 0x40
	public Button InviteButton; // 0x48
	public Button LeaveButton; // 0x50
	public GameObject InviteHint; // 0x58

	// Methods

	// RVA: 0x94B2A0 Offset: 0x949CA0 VA: 0x18094B2A0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x94BBD0 Offset: 0x94A5D0 VA: 0x18094BBD0 Slot: 4
	protected override void Start() { }

	// RVA: 0x94B8E0 Offset: 0x94A2E0 VA: 0x18094B8E0
	private void LateUpdate() { }

	// RVA: 0x94BBB0 Offset: 0x94A5B0 VA: 0x18094BBB0
	public void SetVisible(bool visible) { }

	// RVA: 0x94BA60 Offset: 0x94A460 VA: 0x18094BA60
	public void LeaveClicked() { }

	// RVA: 0x94B870 Offset: 0x94A270 VA: 0x18094B870
	public void InviteClicked() { }

	// RVA: 0x94BEF0 Offset: 0x94A8F0 VA: 0x18094BEF0
	private void UpdateButtons() { }

	// RVA: 0x94BFA0 Offset: 0x94A9A0 VA: 0x18094BFA0
	private void UpdatePlayers() { }

	// RVA: 0x94BA80 Offset: 0x94A480 VA: 0x18094BA80
	public void SetPlayer(int index, CSteamID player) { }

	// RVA: 0x94B570 Offset: 0x949F70 VA: 0x18094B570
	public void ClearPlayer(int index) { }

	// RVA: 0x94B640 Offset: 0x94A040 VA: 0x18094B640
	private Texture2D GetAvatar(CSteamID user) { }

	// RVA: 0x94C1F0 Offset: 0x94ABF0 VA: 0x18094C1F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x94BD60 Offset: 0x94A760 VA: 0x18094BD60
	private void <Awake>b__7_0() { }
}
