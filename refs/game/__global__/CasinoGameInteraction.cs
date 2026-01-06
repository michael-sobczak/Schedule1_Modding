public class CasinoGameInteraction : MonoBehaviour // TypeDefIndex: 2025
{
	// Fields
	public string GameName; // 0x20
	[Header("References")]
	public CasinoGamePlayers Players; // 0x28
	public InteractableObject IntObj; // 0x30
	public Action<Player> onLocalPlayerRequestJoin; // 0x38

	// Methods

	// RVA: 0x7CA500 Offset: 0x7C8F00 VA: 0x1807CA500
	private void Awake() { }

	// RVA: 0x7CA5F0 Offset: 0x7C8FF0 VA: 0x1807CA5F0
	private void Hovered() { }

	// RVA: 0x7CA6D0 Offset: 0x7C90D0 VA: 0x1807CA6D0
	private void Interacted() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
