public class TVHomeScreen : TVApp // TypeDefIndex: 635
{
	// Fields
	[Header("References")]
	public TVInterface Interface; // 0x68
	public TVApp[] Apps; // 0x70
	public RectTransform AppButtonContainer; // 0x78
	public RectTransform[] PlayerDisplays; // 0x80
	public TextMeshProUGUI TimeLabel; // 0x88
	[Header("Prefabs")]
	public GameObject AppButtonPrefab; // 0x90
	private bool skipExit; // 0x98

	// Methods

	// RVA: 0xAA7D10 Offset: 0xAA6710 VA: 0x180AA7D10 Slot: 4
	protected override void Awake() { }

	// RVA: 0xAA8160 Offset: 0xAA6B60 VA: 0x180AA8160 Slot: 5
	public override void Open() { }

	// RVA: 0xAA8110 Offset: 0xAA6B10 VA: 0x180AA8110 Slot: 6
	public override void Close() { }

	// RVA: 0xAA7CB0 Offset: 0xAA66B0 VA: 0x180AA7CB0 Slot: 8
	protected override void ActiveMinPass() { }

	// RVA: 0xAA8370 Offset: 0xAA6D70 VA: 0x180AA8370
	private void UpdateTimeLabel() { }

	// RVA: 0xAA7CC0 Offset: 0xAA66C0 VA: 0x180AA7CC0
	private void AppSelected(TVApp app) { }

	// RVA: 0xAA8180 Offset: 0xAA6B80 VA: 0x180AA8180
	private void PlayerChange(Player player) { }

	// RVA: 0xAA7C20 Offset: 0xAA6620 VA: 0x180AA7C20
	public void .ctor() { }
}
