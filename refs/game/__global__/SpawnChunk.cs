public class SpawnChunk : Clickable // TypeDefIndex: 778
{
	// Fields
	private MeshRenderer _meshRenderer; // 0x50
	private Rigidbody _rb; // 0x58
	private Collider _collider; // 0x60
	private bool _isBroken; // 0x68
	private List<SpawnChunk> _childChunks; // 0x70
	public UnityEvent OnBreak; // 0x78

	// Properties
	private bool hasChildChunks { get; }

	// Methods

	// RVA: 0x5969B0 Offset: 0x5953B0 VA: 0x1805969B0
	private bool get_hasChildChunks() { }

	// RVA: 0x595D40 Offset: 0x594740 VA: 0x180595D40
	private void Awake() { }

	// RVA: 0x5963C0 Offset: 0x594DC0 VA: 0x1805963C0
	public void EnableChunk(Vector3 force, Vector3 torque) { }

	// RVA: 0x596250 Offset: 0x594C50 VA: 0x180596250
	public void DisableChunk(bool recursive) { }

	// RVA: 0x595EB0 Offset: 0x5948B0 VA: 0x180595EB0
	public void Break() { }

	// RVA: 0x5965A0 Offset: 0x594FA0 VA: 0x1805965A0
	public bool GetIsBroken(bool recursive = True) { }

	// RVA: 0x596860 Offset: 0x595260 VA: 0x180596860 Slot: 6
	public override void StartClick(RaycastHit hit) { }

	// RVA: 0x5966E0 Offset: 0x5950E0 VA: 0x1805966E0
	public void SetChunkOrder(int i) { }

	// RVA: 0x5968F0 Offset: 0x5952F0 VA: 0x1805968F0
	public void .ctor() { }
}
