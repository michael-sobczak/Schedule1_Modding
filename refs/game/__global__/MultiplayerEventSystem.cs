public class MultiplayerEventSystem : EventSystem // TypeDefIndex: 7518
{
	// Fields
	[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
	[SerializeField]
	private GameObject m_PlayerRoot; // 0x60

	// Properties
	public GameObject playerRoot { get; set; }

	// Methods

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public GameObject get_playerRoot() { }

	// RVA: 0x284ABC0 Offset: 0x28495C0 VA: 0x18284ABC0
	public void set_playerRoot(GameObject value) { }

	// RVA: 0x284AA80 Offset: 0x2849480 VA: 0x18284AA80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x284AA70 Offset: 0x2849470 VA: 0x18284AA70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x284A9A0 Offset: 0x28493A0 VA: 0x18284A9A0
	private void InitializePlayerRoot() { }

	// RVA: 0x284AAA0 Offset: 0x28494A0 VA: 0x18284AAA0 Slot: 18
	protected override void Update() { }

	// RVA: 0x284AB70 Offset: 0x2849570 VA: 0x18284AB70
	public void .ctor() { }
}
