public class CasinoGamePlayerDisplay : MonoBehaviour // TypeDefIndex: 2051
{
	// Fields
	public CasinoGamePlayers BindedPlayers; // 0x20
	[Header("References")]
	public TextMeshProUGUI TitleLabel; // 0x28
	public RectTransform[] PlayerEntries; // 0x30

	// Methods

	// RVA: 0x7E2440 Offset: 0x7E0E40 VA: 0x1807E2440
	public void RefreshPlayers() { }

	// RVA: 0x7E2900 Offset: 0x7E1300 VA: 0x1807E2900
	public void RefreshScores() { }

	// RVA: 0x7E2330 Offset: 0x7E0D30 VA: 0x1807E2330
	public void Bind(CasinoGamePlayers players) { }

	// RVA: 0x7E2A90 Offset: 0x7E1490 VA: 0x1807E2A90
	public void Unbind() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
