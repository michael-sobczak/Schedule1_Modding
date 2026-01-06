public class CombatNPCDetector : MonoBehaviour // TypeDefIndex: 2280
{
	// Fields
	public bool DetectOnlyInCombat; // 0x20
	public UnityEvent onDetected; // 0x28
	public float ContactTimeForDetection; // 0x30
	private bool inContact; // 0x34
	private NPC npcInContact; // 0x38
	private float contactTime; // 0x40

	// Methods

	// RVA: 0x83F4F0 Offset: 0x83DEF0 VA: 0x18083F4F0
	private void Awake() { }

	// RVA: 0x83F5B0 Offset: 0x83DFB0 VA: 0x18083F5B0
	private void FixedUpdate() { }

	// RVA: 0x83F610 Offset: 0x83E010 VA: 0x18083F610
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x83F790 Offset: 0x83E190 VA: 0x18083F790
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x83F870 Offset: 0x83E270 VA: 0x18083F870
	public void .ctor() { }
}
